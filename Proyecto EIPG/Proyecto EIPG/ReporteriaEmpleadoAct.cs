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
    public partial class ReporteriaEmpleadoAct : Form
    {
        public ReporteriaEmpleadoAct()
        {
            InitializeComponent();
        }
        public int parametro { set; get; }
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'finalDataSet.reporte_empleado_por_estado' Puede moverla o quitarla según sea necesario.
            this.reporte_empleado_por_estadoTableAdapter.Fill(this.finalDataSet.reporte_empleado_por_estado,parametro);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
