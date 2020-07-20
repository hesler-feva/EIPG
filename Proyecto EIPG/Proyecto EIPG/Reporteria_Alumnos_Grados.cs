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
    public partial class Reporteria_Alumnos_Grados : Form
    {
       public string estado = " ";
        public Reporteria_Alumnos_Grados()
        {
            InitializeComponent();
        }
        Procedimientos_Almacenados procedimientos = new Procedimientos_Almacenados();//instancia con la clase de procedimeintos alamacenados
        //funcion para enviar un valor dependiendo del grado seleccionado a la funcion de reporte alumno por grado
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Procedimientos_Almacenados proc = new Procedimientos_Almacenados();
            

            if (Cmb_Grado.SelectedIndex==1)
            {
                estado = "1";
                dataGridView1.DataSource = proc.Reporte_alumno_por_grado(estado);
            }
            if (Cmb_Grado.SelectedIndex == 2)
            {
                estado = "2";
                dataGridView1.DataSource = proc.Reporte_alumno_por_grado(estado);
            }
            if (Cmb_Grado.SelectedIndex == 3)
            {
                estado = "3";
                dataGridView1.DataSource = proc.Reporte_alumno_por_grado(estado);
            }
            if (Cmb_Grado.SelectedIndex == 4)
            {
                estado = "4";
                dataGridView1.DataSource = proc.Reporte_alumno_por_grado(estado);
            }
            if (Cmb_Grado.SelectedIndex == 5)
            {
                estado = "5";
                dataGridView1.DataSource = proc.Reporte_alumno_por_grado(estado);
            }
            if (Cmb_Grado.SelectedIndex == 6)
            {
                estado = "6";
                dataGridView1.DataSource = proc.Reporte_alumno_por_grado(estado);
            }
            if (Cmb_Grado.SelectedIndex == 7)
            {
                estado = "7";
                dataGridView1.DataSource = proc.Reporte_alumno_por_grado(estado);
            }
            if (Cmb_Grado.SelectedIndex == 8)
            {
                estado = "8";
                dataGridView1.DataSource = proc.Reporte_alumno_por_grado(estado);
            }
            if (Cmb_Grado.SelectedIndex == 9)
            {
                estado = "9";
                dataGridView1.DataSource = proc.Reporte_alumno_por_grado(estado);
            }
            if (Cmb_Grado.SelectedIndex == 10)
            {
                estado = "10";
                dataGridView1.DataSource = proc.Reporte_alumno_por_grado(estado);
            }
            if (Cmb_Grado.SelectedIndex == 11)
            {
                estado = "11";
                dataGridView1.DataSource = proc.Reporte_alumno_por_grado(estado);
            }
            if (Cmb_Grado.SelectedIndex == 12)
            {
                estado = "12";
                dataGridView1.DataSource = proc.Reporte_alumno_por_grado(estado);
            }





        }

        //boton regresar cierra este formulario y abrel el de reporte de alumnos
        private void btn_regresar_Click(object sender, EventArgs e)
        {
            Reporte_Alumnos repor_alum = new Reporte_Alumnos();
            this.Close();
            repor_alum.Show();
        }

        //evento de reporte de alumnos load
        private void Reporteria_Alumnos_Grados_Load(object sender, EventArgs e)
        {
            //varga el combobox de los grados con la funcion de listar grado cursando
            Cmb_Grado.DataSource = procedimientos.listar_grado_cursando();
            Cmb_Grado.DisplayMember = "descripcion_grado_cursando";
            Cmb_Grado.ValueMember = "id_grado_cursando";
            
        }
        
        //boton geenera reporte de lo que se presenta en el data grid
        private void btn_generar_rep_Click(object sender, EventArgs e)
        {
            if (Cmb_Grado.SelectedIndex == 0 || estado == "0")
            {
                MessageBox.Show("Seleccione un Grado para imprimir.");
                Cmb_Grado.Focus();

            }
            else
            {
                ReporteAlumnosGrado rag = new ReporteAlumnosGrado();
                rag.parametro = int.Parse(estado);
                rag.ShowDialog();
            }
        }

        private void Pnl_cont_report_grados_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
