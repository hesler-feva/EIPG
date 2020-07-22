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
    public partial class Menu_Contabilidad : Form
    {
        public Menu_Contabilidad()
        {
            InitializeComponent();
        }

        //boton ingreso contable
        private void btnRegistroIngreso_Conta_Click(object sender, EventArgs e)
        {
            this.Close();//cierra este formulario
            Ingresos_Conta ingre_conta = new Ingresos_Conta();//hace la instancia con el formulario de ingreso contable
            ingre_conta.Show();//abre el menu de ingreso contable
        }

        //boton de egreso contable
        private void btnRegistroEgreso_conta_Click(object sender, EventArgs e)
        {
            this.Close();//cierra este formulario
            Egresos_Varios egre_var = new Egresos_Varios();//hace la instancia con el formulario de egreso contable
            egre_var.Show();//abre el formulario de egreso contable
          
        }

        //boton de reporte de ingreso contable
        private void btnReporteIngresos_Conta_Click(object sender, EventArgs e)
        {
            this.Close();//cierra este formulario
            Reporte_Ingre_Conta repor_ingre_cont = new Reporte_Ingre_Conta();//hace la instancia con el formulario de ingresos contable reportes
            repor_ingre_cont.Show();//abre el formulario de reportes de ingresos
        }

        //boton reporte egreso contable
        private void btnReporte_Egresos_Conta_Click(object sender, EventArgs e)
        {
            this.Close();//cierra este formulario
            Reportes_Egre_Conta repor_egre_cont = new Reportes_Egre_Conta();//hace la instancia con reporte de egreso contable
            repor_egre_cont.Show();//abre el formulario de reporte de egreso contable
        }

        //boton de reporte general
        private void btnReporteGeneral_Conta_Click(object sender, EventArgs e)
        {
            this.Close();//cierra este formulario
            Reporte_General_Conta repor_gen_cont = new Reporte_General_Conta();//hace la instancia con reporte general contable
            repor_gen_cont.Show();//abre el formulario de reporte contable general
        }

        //boton salir cierra este formulario
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //evento load de menu contable
        private void Menu_Contabilidad_Load(object sender, EventArgs e)
        {
            //carga los datos del usuario de la clase de usuarios cache   
            lblNombre_conta.Text = cache_usuario.Usuario;
            lblIdentidad_Conta.Text = cache_usuario.Id;
        }

        private void PnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            menu mn = new menu(); //Instancia del formulario menu
            this.Close(); //Se cierra el formulario actual
            mn.Show(); //se muestra el formulario menu
        }
    }
}
