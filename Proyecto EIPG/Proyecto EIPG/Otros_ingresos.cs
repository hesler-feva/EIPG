using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos_usuarios.cache;

namespace Proyecto_EIPG
{
    public partial class Otros_ingresos : Form
    {
        public Otros_ingresos()
        {
            InitializeComponent();
        }

        //boton regresar cierra este formulario
        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //boton finalizar transaccion 
        private void btnFinalizar_Transac_Click(object sender, EventArgs e)
        {
            int motivo = 2, cuenta=1;

            

            int monto=0;
            if (Txt_Monto.Text.Equals(""))//valida que el monto no este vacio
            {
                MessageBox.Show("no puede dejar datos vacios");
            }
            else
                monto = Int32.Parse(Txt_Monto.Text); //si no esta vacio le asigna el valor a la variable monto

            if (monto <=0 || monto > 16100)//si motno es mayor que 16100 o menor que 0 nos muestra el error
            {
                error.SetError(Txt_Monto, "Introduzca un dato correcto");
                Txt_Monto.Focus();
                MessageBox.Show("Error, debe ingresar el monto. Maximo 16100 de lempiras y minimo de 1 lempira");
            }
            else
            {
                //en caso contrario realiza la transaccion
                try
                {
                    Procedimientos_Almacenados proc = new Procedimientos_Almacenados();//hace la instancia con la clase de procedimiento almacenado

                    proc.Ingresar_otros_ingresos(Txt_Descripcion_Ingreso.Text, Msk_ID_Cliente.Text, Convert.ToDateTime(lbl_fecha_Otro_ingreso.Text), double.Parse(Txt_Monto.Text), motivo, cuenta);//le manda los datos al procedimiento
                    MessageBox.Show("Guardado con exito");//muestra el mensaje guardado cone exito
                    Txt_Descripcion_Ingreso.Clear(); Msk_ID_Cliente.Clear(); Txt_Monto.Clear();//limpia todos los campos anteriores
                }
                catch (Exception )
                {
                    //en caso que un campo este vacio sql no lo puede registrar y se presenta el mensaje de advertencia
                    System.Windows.Forms.MessageBox.Show("Los datos no pueden estar vacios ");
                }
            }
        }

        private void Msk_ID_Cliente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        //validacion de la id del cliente donde debe ser igual a 15 caracteres
        private void Msk_ID_Cliente_Validated(object sender, EventArgs e)
        {
            if (Msk_ID_Cliente.Text.Length < 15)
            {
                error.SetError(Msk_ID_Cliente, "Introduzca la Identidad correctamente");
                Msk_ID_Cliente.Focus();

            }
            else
            {
                error.Clear();
            }
        }

        //validacion ASCII que permite solo ingreso de numeros
        private void txt_monto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 0 && e.KeyChar <= 7) || (e.KeyChar >= 9 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo numeros");
                e.Handled = true;
            }
        }

        //evento load de otros ingresos
        private void Otros_ingresos_Load(object sender, EventArgs e)
        {
            //carga los datos del usuario de la clase de cache de usuario
            Lbl_Nombre_Conta.Text = cache_usuario.Usuario;
            Lbl_Identidad_Conta.Text = cache_usuario.Id;
            DateTime fecha = DateTime.Today;
            lbl_fecha_Otro_ingreso.Text = fecha.ToString("dd/MM/yyy");
        }

        //validacion con ASCII que no permite el ingreso de caracteres espeiales
        private void txt_descripcion_ingreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 0 && e.KeyChar <= 7) || (e.KeyChar >= 9 && e.KeyChar <= 31) || (e.KeyChar >= 33 && e.KeyChar <= 39) || (e.KeyChar >= 42 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47) || (e.KeyChar >= 60 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar >= 255))
            {
                MessageBox.Show("No se permiten caracteres especiales");
                e.Handled = true;
            }

        }

        private void txt_descripcion_ingreso_Validated(object sender, EventArgs e)
        {

        }

        //validacion en caso que el usuario presione por error el boton de cerrar el formulario
        private void Otros_ingresos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Ingresos_Conta ic = new Ingresos_Conta();
                ic.Show();
            }
        }

        private void PnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
