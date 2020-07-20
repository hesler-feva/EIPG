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
    public partial class Reporte_General_Conta : Form
    {
        public Reporte_General_Conta()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //evento load del formulario reporte general contable
        private void Reporte_General_Conta_Load(object sender, EventArgs e)
        {
            //carga los datos del usuario de la clase usuario cache
            Lbl_Nombre_conta.Text = cache_usuario.Usuario;
            Lbl_Identidad_conta.Text = cache_usuario.Id;
            //carga los datos de los datagrid
            Procedimientos_Almacenados proc = new Procedimientos_Almacenados();
            dgvIngresos.DataSource = proc.reporte_ingresos_administrativo();
            dgvEgresos.DataSource = proc.reporte_egresos_administrativo();
            Txt_Total_Ingresos_Conta.Text = proc.reporte_total_ingresos();
            Txt_Total_Egresos_Conta.Text = proc.reporte_total_egresos();
            double ingresos, egresos;
            if (Txt_Total_Ingresos_Conta.Text.Equals(""))
            {
                ingresos = 0;
            }
            else
                ingresos = double.Parse(Txt_Total_Ingresos_Conta.Text);
            if (Txt_Total_Egresos_Conta.Text.Equals(""))
            {
                egresos = 0;
            }
            else
                egresos = double.Parse(Txt_Total_Egresos_Conta.Text);
            Txt_GranTotal_Conta.Text = Convert.ToString(ingresos - egresos);
        }

        //boton buscar nos permite listar un reporte de una fecha determinada
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
                dgvIngresos.DataSource = proc.reporte_ingresos_por_fecha(Dtp_Inicial.Value, Dtp_Final.Value);
                dgvEgresos.DataSource = proc.reporte_egresos_por_fecha(Dtp_Inicial.Value, Dtp_Final.Value);
                Txt_Total_Ingresos_Conta.Text = proc.total_ingresos_por_fecha(Dtp_Inicial.Value, Dtp_Final.Value);
                Txt_Total_Egresos_Conta.Text = proc.total_egresos_por_fecha(Dtp_Inicial.Value, Dtp_Final.Value);

                double egresos, ingresos;
                ////
                if (string.IsNullOrEmpty(Txt_Total_Egresos_Conta.Text))
                    egresos = 0;
                else
                    egresos = double.Parse(Txt_Total_Egresos_Conta.Text);

                if (string.IsNullOrEmpty(Txt_Total_Ingresos_Conta.Text))
                    ingresos = 0;
                else
                    ingresos = double.Parse(Txt_Total_Ingresos_Conta.Text);
                Txt_GranTotal_Conta.Text = Convert.ToString(ingresos - egresos);

            }
        }

        //el boton generar reporte nos hace un reporte con los datos contenidos en los datagrid
        private void btnGenerar_Reporte_Click(object sender, EventArgs e)
        {
            reporteriageneral reg = new reporteriageneral();
            reg.fechai = Dtp_Inicial.Value;
            reg.fechaf = Dtp_Final.Value;
            reg.ShowDialog();
        }

        //validacion en caso que el usuario presione por error el boton de salir del formulario
        private void Reporte_General_Conta_FormClosing(object sender, FormClosingEventArgs e)
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

        private void PnlReporte_Conta_Admin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
