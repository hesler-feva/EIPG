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
    public partial class Transaccion_Mat_Mensu : Form
    {
        public Transaccion_Mat_Mensu()
        {
            InitializeComponent();
        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblSaldo_Estudiante_Click(object sender, EventArgs e)
        {

        }

        //evento load de transaccion de matricula
        private void Transaccion_Mat_Mensu_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            //cargar los datos de la clase de usuario cache
            Lbl_Nombre_conta.Text = cache_usuario.Usuario;
            Lbl_Identidad_Conta.Text = cache_usuario.Id;
            DateTime fecha = DateTime.Today;
            lbl_fecha_transaccion_matricula.Text = fecha.ToString("dd/MM/yyy");
        }

        //boton finalizar transaccion para registrar la tranasaccion en la base de datos
        private void btnFinalizar_Transac_Click(object sender, EventArgs e)
        {
            int motivo = 1, cuenta = 1;

            int monto;

            monto = Int32.Parse(Txt_Monto_Cancelar.Text);

            if (monto < 100 || Txt_Monto_Cancelar.Equals("") || monto>16100)
            {
                error.SetError(Txt_Monto_Cancelar, "Introduzca un dato correcto");
                Txt_Monto_Cancelar.Focus();
                MessageBox.Show("Error, debe ingresar el monto a pagar. Minimo 100 lempiras y maximo 16100");
            }
            else
            {
                try
                {
                    Procedimientos_Almacenados proc = new Procedimientos_Almacenados();

                    proc.Ingresar_otros_ingresos("Matricula", Txt_ID_estudiante.Text, Convert.ToDateTime(lbl_fecha_transaccion_matricula.Text), double.Parse(Txt_Monto_Cancelar.Text), motivo, cuenta);
                    MessageBox.Show("Guardado con exito");
                    proc.Restar_Saldo(Txt_ID_estudiante.Text, Convert.ToDecimal(Txt_Monto_Cancelar.Text));
                    Txt_ID_estudiante.Clear(); Txt_Nombre_Estudiante.Clear(); Txt_ID_Padre.Clear(); Txt_Nombre_Padre.Clear(); Txt_Monto_Cancelar.Clear();lblSaldo_Alum.Text = "0.00";
                }
                catch (Exception )
                {
                    System.Windows.Forms.MessageBox.Show("Los datos no pueden estar vacios ");
                }
            }
        }

        //validacion de tipo ASCII para solo ingresar numeros
        private void tbxMonto_Cancelar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 0 && e.KeyChar <= 7) || (e.KeyChar >= 9 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo numeros");
                e.Handled = true;
            }
        }

        private void tbxMonto_Cancelar_TextChanged(object sender, EventArgs e)
        {
            
        }

        //validacion en caso que el usuario de click sobre el boton de salir por error
        private void Transaccion_Mat_Mensu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Ingresos_Matricula_Mensualidad imm = new Ingresos_Matricula_Mensualidad();
                imm.Show();
            }
        }

        private void Txt_Nombre_Estudiante_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
