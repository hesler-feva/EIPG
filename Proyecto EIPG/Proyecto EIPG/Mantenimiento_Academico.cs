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
    public partial class Mantenimiento_Academico : Form
    {
        public Mantenimiento_Academico()
        {
            InitializeComponent();
        }

        private void Lbl_Infor_Personal_Emple_Click(object sender, EventArgs e)
        {

        }
        //validacion para cambiar el panel
        private void abrir_panel(object form_hija)
        {
            if (this.panel_cambio.Controls.Count>0)
            {
                this.panel_cambio.Controls.RemoveAt(0);
            }
            Form fh = form_hija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel_cambio.Controls.Add(fh);
            this.panel_cambio.Tag = fh;
            fh.Show();
        }
        //boton añadir carrera
        private void Btn_Añadir_Carrera_Click(object sender, EventArgs e)
        {
            abrir_panel(new Panel_carrera());//llamado del panel
        }

        private void pnlIngreso_Emple_Paint(object sender, PaintEventArgs e)
        {

        }
        //boton regresar
        private void Btn_Regresar_Click(object sender, EventArgs e)
        {
            Menu_Admin ma = new Menu_Admin();//instancia con el menu administrativo
            this.Close();//cierra esta ventana 
            ma.Show();//abre el menu administrativo
        }

        private void Btn_Añadir_Seccion_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_Cargar_Mensualidad_Click(object sender, EventArgs e)
        {
            abrir_panel(new panel_cargar_mensualidad());//llama el panel de cargar mensualidad
        }

        private void Mantenimiento_Academico_Load(object sender, EventArgs e)
        {
            //cargar los labels con los datos almacenados en la clase de cache usuario
            Lbl_Nombre_admin.Text = cache_usuario.Usuario;
            Lbl_Identidad_Admin.Text = cache_usuario.Id;
        }
    }
}
