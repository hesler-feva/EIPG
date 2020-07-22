using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_EIPG
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }
        public String Nombre2;
        public static String Nombre;
        
        //boton menu administrativo
        private void btn_menu_administrativo_Click(object sender, EventArgs e)
        {
            Menu_Admin ma = new Menu_Admin();//instancia con el menu administrativo
            ma.lblNombre_admin.Text = Nombre;//le envia al label de menu administrativo el valor de la variable nombre
            this.Close();//cierra este dormulario
            ma.Show();//abre el formulario de menu administrativo
        }

        //boton de menu contable
        private void btn_menu_contable_Click(object sender, EventArgs e)
        {
            Menu_Contabilidad mc = new Menu_Contabilidad();//instancia con el menu contable
            mc.lblNombre_conta.Text = Nombre;//le manda el valor del nombre
            this.Close();//cierra este formulario
            mc.Show();//abre el formulario de menu contable
        }

        //boton salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();//cierra este formulario
            Form1 f = new Form1();//hace una instancia con el login
            f.Show();//abre el login
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        //boton cerrar este formulario
        private void menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            //hace una instancia con el login que abra el login en caso de que este cierre
            Form1 login = new Form1();
            login.Show();
        }

        private void Btn_Mantenimiento_Academico_Click(object sender, EventArgs e)
        {
            Mantenimiento_Academico MA = new Mantenimiento_Academico();//hace la instancia
            this.Close();//cierra este formulario
            MA.Show();//abre el formulario de mantenimiento
        }
    }
}
