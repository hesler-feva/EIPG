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
    public partial class Reportes_Egre_Conta : Form
    {
        public Reportes_Egre_Conta()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reportes_Egre_Conta_Load(object sender, EventArgs e)
        {
            Lbl_Nombre_admin.Text = cache_usuario.Usuario;
            Lbl_Identidad_Admin.Text = cache_usuario.Id;
            Procedimientos_Almacenados proc = new Procedimientos_Almacenados();
            dgbReporte_egre_Conta.DataSource = proc.reporte_egresos();
            Txt_Total_Egresos_Conta.Text = proc.reporte_total_egresos();
        }

        private void dgbReporte_egre_Conta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                dgbReporte_egre_Conta.DataSource = proc.reporte_egresos_por_fecha(Dtp_Inicial.Value, Dtp_Final.Value);
                Txt_Total_Egresos_Conta.Text = proc.total_egresos_por_fecha(Dtp_Inicial.Value, Dtp_Final.Value);

                double ingresos;

                if (string.IsNullOrEmpty(Txt_Total_Egresos_Conta.Text))
                    ingresos = 0;
                else
                    ingresos = double.Parse(Txt_Total_Egresos_Conta.Text);

            }
        }

        private void btnGenerar_Reporte_Click(object sender, EventArgs e)
        {
            reporteriaegresos ree = new reporteriaegresos();
            ree.fechai = Dtp_Inicial.Value;
            ree.fechaf = Dtp_Final.Value;

            ree.ShowDialog();
        }

        private void Reportes_Egre_Conta_FormClosing(object sender, FormClosingEventArgs e)
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
