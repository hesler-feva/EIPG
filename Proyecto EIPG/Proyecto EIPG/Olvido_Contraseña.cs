using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Proyecto_EIPG
{
    public partial class RecuperarContraseña : Form
    {
        public RecuperarContraseña()
        {
            InitializeComponent();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRecuperarContrasena_Click(object sender, EventArgs e)
        {
            //hace la instancia con el servidor de sql
            SqlConnection sc = new SqlConnection("Data Source= (local);Initial Catalog=final;Integrated Security=True");
            {


                SqlCommand cmd = new SqlCommand("sp_validarcorreo", sc);//declara la variable de comando


                cmd.CommandType = CommandType.StoredProcedure;//le dice que es de tipo procedimeinto almacenado
                cmd.Parameters.AddWithValue("@correo", Txt_Correo_Electronico.Text);//envia el valor del correo
                try
                {
                    sc.Open();//abre la conexion
                    SqlDataReader lector = cmd.ExecuteReader(); //ejecuta la lectura del procedimiento
                    if (lector.Read())
                    {

                        GenerarNuevaContrasena(Txt_Correo_Electronico.Text);//le envia el correo para decirle que a ese usuario se le restaurara la contraseña
                    }
                    else
                    {
                        MessageBox.Show("Correo no encontrado"); //si el correo no  existe entonces muestra este mensaje
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        //funcion de generar nueva contraseña
        public void GenerarNuevaContrasena(string email)
        {
            Random rd = new Random(DateTime.Now.Millisecond);//hace un radom con la fecha
            int nuevaContrasena = rd.Next(100000, 999999); //crea la nueva contraseña
            //instancia con el servidor de sql
            SqlConnection sc = new SqlConnection("Data Source= (local);Initial Catalog=final;Integrated Security=True");


            SqlCommand cmd = new SqlCommand("nuevacontraseña", sc);//comando de sql

            cmd.CommandType = CommandType.StoredProcedure;//le dice que es de tipo procedimiento almacenado

            cmd.Parameters.AddWithValue("@correo", email);//le envia el correo
            cmd.Parameters.AddWithValue("@contrasena", nuevaContrasena);//le envia la contraseña
            try
            {
                sc.Open();
                int filasAfectadas = cmd.ExecuteNonQuery();
                if (filasAfectadas != 0)
                {
                    EnviarCorreoContrasena(nuevaContrasena, email);
                }
            }
            catch
            {

            }
        }

        //funcion para enviar al correo la contraseña creada
        private void EnviarCorreoContrasena(int contrasenaNueva, string correo)
        {
            string contraseña = this.Contrasena;
            string mensaje = string.Empty;
            //Creando el correo electronico
            string destinatario = correo;
            string remitente = "labspoo111@gmail.com";
            string asunto = "Nueva contraseña Instituto Gualaco";
            string cuerpoDelMesaje = "Su nueva contraseña es" + " " + Convert.ToString(contrasenaNueva);
            MailMessage ms = new MailMessage(remitente, destinatario, asunto, cuerpoDelMesaje);


            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("labspoo111@gmail.com", contraseña);

            try
            {
                Task.Run(() =>
                {

                    smtp.Send(ms);
                    ms.Dispose();
                    MessageBox.Show("Correo enviado, revise su correo");
                }
                );

                MessageBox.Show("Esta tarea puede tardar unos segundos, por favor espere.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar correo electronico: " + ex.Message);
            }
        }


        public string Contrasena
        {
            get
            { return "Laboratorios2"; }
        }

        //evento leave
        private void txtCorreoElectronico_Leave(object sender, EventArgs e)
        {
            if (validar_email(Txt_Correo_Electronico.Text))
            {
            }
            else
            {

                MessageBox.Show("Direccion de correo electronico no valido, el correo debe tener el formato: ejemplo@dominio.com," +
                    "Por favor use un direccion de correo electronico valida", "Validacion de Correo Electronico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        //validar los caracteres que se pueden ingresar en el correo
        private Boolean validar_email(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
    

}
