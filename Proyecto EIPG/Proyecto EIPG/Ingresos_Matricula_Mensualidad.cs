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
    public partial class Ingresos_Matricula_Mensualidad : Form
    {
        public Ingresos_Matricula_Mensualidad()
        {
            InitializeComponent();
        }

        //boton realizar transaccion
        private void btnRealizar_Transac_Click(object sender, EventArgs e)
        {
            Transaccion_Mat_Mensu transa = new Transaccion_Mat_Mensu();//instancia con la tansaccion de matricula mensualidad
            if (Txt_ID_estudiante.Text.Equals("")) //validacion si el id usuario esta vacio no deja avanzar y manda un mensaje al usuario
            {
                MessageBox.Show("debe seleccionar un alumno para realizar la transaccion");
            }
            else {
                //en caso contrario envias los datos de este formulario al formulario de transaccion matricula mensual
                transa.Txt_ID_estudiante.Text = Txt_ID_estudiante.Text;
                transa.Txt_Nombre_Estudiante.Text = Txt_Nombre_Estudiante.Text;
                transa.Txt_ID_Padre.Text = Txt_ID_Padre.Text;
                transa.Txt_Nombre_Padre.Text = Txt_Nombre_Padre.Text;
                transa.lblSaldo_Alum.Text = Txt_Saldo_Estudiante.Text;
                transa.Show();
                this.Hide();
            }
        }

        //el boton regresar solo cierra este formulario
        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //boton buscar alumno 
        private void btnBuscar_Alum_Click(object sender, EventArgs e)
        {
            reportes.Reporte_alumno = 2;//le envia un valor bandera para indicar que debe regresar a este formulario
            Reporte_Alumnos ra = new Reporte_Alumnos();//instancia con el formulario de reporte alumnos
            this.Hide();//minimiza este formulario
            ra.Show();//abre el formulario de reporte alumnos
            MessageBox.Show("doble Click sobre el alumno que desea");//le indica que de doble clic para obtener los datos de un alumno
        }

        private void tbxID_estudiante_TextChanged(object sender, EventArgs e)
        {

        }

        //evento load 
        private void Ingresos_Matricula_Mensualidad_Load(object sender, EventArgs e)
        {
            //carga los labels con los datos almacenados en cache usuario
            Lbl_Nombre_conta.Text = cache_usuario.Usuario;
            Lbl_Identidad_Conta.Text = cache_usuario.Id;
        }

        //validacion en caso que el usuario presione el boton de salir por accidente 
        private void Ingresos_Matricula_Mensualidad_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Ingresos_Conta mc = new Ingresos_Conta();
                mc.Show();
            }
        }

        private void PnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
