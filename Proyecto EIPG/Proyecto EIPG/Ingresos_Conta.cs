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
    public partial class Ingresos_Conta : Form
    {
        public Ingresos_Conta()
        {
            InitializeComponent();
        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
        //boton de registrar la mensualidad 
        private void btnRegistroIngreso_MatYmensu_Click(object sender, EventArgs e)
        {
            this.Close();//cierra este formulario
            Ingresos_Matricula_Mensualidad ingre_matymensu = new Ingresos_Matricula_Mensualidad(); //hace instancia con el boton de ingresos matricula mensualidad
            ingre_matymensu.Show(); //abre el frmulario de matricula formulario
        }
        //boton registro de otros ingresos
        private void btnRegistroIngreso_Otros_Click(object sender, EventArgs e)
        {
            this.Close();//cierra este formulario
            Otros_ingresos otros_ingre = new Otros_ingresos();//instancia con el formulario de otros ingresos
            otros_ingre.Show();//abre el formulario de otros ingresos
        }

        //boton regresar
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();//cierra este formulario
            Menu_Contabilidad mc = new Menu_Contabilidad();//hace una instancia con el menu contable
            mc.Show();//abre el formulario de menu contable
        }

        //ingresos contables evento load
        private void Ingresos_Conta_Load(object sender, EventArgs e)
        {
           //carga los labels con los datos que se encuentran en la clase de cache usuario
            Lbl_Nombre_conta.Text = cache_usuario.Usuario;
            Lbl_Identidad_Conta.Text = cache_usuario.Id;
        }

        private void Lbl_Identidad_Conta_Click(object sender, EventArgs e)
        {

        }
    }
}
