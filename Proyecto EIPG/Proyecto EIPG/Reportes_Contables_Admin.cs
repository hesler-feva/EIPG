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
    public partial class Reportes_Contables_Admin : Form
    {
        public Reportes_Contables_Admin()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbxTotal_Ingresos_Admin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pnlReporte_Conta_Admin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Reportes_Contables_Admin_Load(object sender, EventArgs e)
        {
            Lbl_Nombre_admin.Text = cache_usuario.Usuario;
            Lbl_Identidad_Admin.Text = cache_usuario.Id;
            Procedimientos_Almacenados proc = new Procedimientos_Almacenados();
            dtvingresos_reporte.DataSource = proc.reporte_ingresos_administrativo();
            dtvegresos_reporte.DataSource = proc.reporte_egresos_administrativo();
            Txt_Total_Ingresos_Admin.Text = proc.reporte_total_ingresos();
            Txt_Total_Egresos_Admin.Text = proc.reporte_total_egresos();
            double ingresos, egresos;
            ingresos = double.Parse(Txt_Total_Ingresos_Admin.Text);
            egresos = double.Parse(Txt_Total_Egresos_Admin.Text);
            Txt_GranTotal_Admin.Text = Convert.ToString(ingresos - egresos);
        }

        private void btnBuscar_Factura_Click(object sender, EventArgs e)
        {
            string fecha = "2/02/2008";
            DateTime fecha_inicio = DateTime.Parse(fecha);

            if (Dtp_Final.Value < Dtp_Inicial.Value)
            {
                MessageBox.Show("La fecha final debe ser mayor a la fecha inicial");
                Dtp_Final.Focus();

            }

            else if (Dtp_Final.Value > DateTime.Now || Dtp_Inicial.Value > DateTime.Now)
            {
                MessageBox.Show("Fecha incorrecta");

            }
            else if (Dtp_Inicial.Value < fecha_inicio)
            {
                MessageBox.Show("Fecha incorrecta");
                Dtp_Inicial.Focus();
            }
            else
            {
                Procedimientos_Almacenados proc = new Procedimientos_Almacenados();
                dtvingresos_reporte.DataSource = proc.reporte_ingresos_por_fecha(Dtp_Inicial.Value, Dtp_Final.Value);
                dtvegresos_reporte.DataSource = proc.reporte_egresos_por_fecha(Dtp_Inicial.Value, Dtp_Final.Value);
                Txt_Total_Ingresos_Admin.Text = proc.total_ingresos_por_fecha(Dtp_Inicial.Value, Dtp_Final.Value);
                Txt_Total_Egresos_Admin.Text = proc.total_egresos_por_fecha(Dtp_Inicial.Value, Dtp_Final.Value);

                double egresos, ingresos;
                ////
                if (string.IsNullOrEmpty(Txt_Total_Egresos_Admin.Text))
                    egresos = 0;
                else
                    egresos = double.Parse(Txt_Total_Egresos_Admin.Text);

                if (string.IsNullOrEmpty(Txt_Total_Ingresos_Admin.Text))
                    ingresos = 0;
                else
                    ingresos = double.Parse(Txt_Total_Ingresos_Admin.Text);
                Txt_GranTotal_Admin.Text = Convert.ToString(ingresos - egresos);

            }
        }

        private void Reportes_Contables_Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Menu_Contabilidad ma = new Menu_Contabilidad();
                ma.Show();
            }
        }
    }
}
