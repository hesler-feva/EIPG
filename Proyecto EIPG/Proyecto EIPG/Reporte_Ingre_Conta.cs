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
    public partial class Reporte_Ingre_Conta : Form
    {
        public Reporte_Ingre_Conta()
        {
            InitializeComponent();
        }

        private void pnlReporte_Conta_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //evento load del formulario reporte ingresos contables
        private void Reporte_Ingre_Conta_Load(object sender, EventArgs e)
        {
            //carga los datos del usuario de la clase de usuarios cache
            Lbl_Nombre_conta.Text = cache_usuario.Usuario;
            Lbl_Identidad_Conta.Text = cache_usuario.Id;
            //carga los datos a los datagrid atraves de los procedimeintos almacenados
            Procedimientos_Almacenados proc = new Procedimientos_Almacenados();
           dgvReporte_Ingre_Conta.DataSource = proc.reporte_ingresos();
           Txt_total.Text = proc.reporte_total_ingresos();
        }

        //boton buscar permite llenar un datagrid de acuerdo a la fecha que se le manda en el procedmiento almacenado
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
                dgvReporte_Ingre_Conta.DataSource = proc.reporte_ingresos_por_fecha(Dtp_Inicial.Value, Dtp_Final.Value);
                Txt_total.Text = proc.total_ingresos_por_fecha(Dtp_Inicial.Value, Dtp_Final.Value);

                double ingresos;

                if (string.IsNullOrEmpty(Txt_total.Text))
                    ingresos = 0;
                else
                    ingresos = double.Parse(Txt_total.Text);

            }
        }

        //boton generar el reporte lo genera con los datos presentados en el datagrid
        private void btnGenerar_Reporte_Click(object sender, EventArgs e)
        {
            reporteriaingresos rei = new reporteriaingresos();
                rei.fechai = Dtp_Inicial.Value;
                rei.fechaf = Dtp_Final.Value;
            rei.ShowDialog();

        }

        private void Reporte_Ingre_Conta_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Reporte_Ingre_Conta_FormClosing(object sender, FormClosingEventArgs e)
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
