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
    public partial class reporteria_empleados : Form
    {
        public reporteria_empleados()
        {
            InitializeComponent();
        }

        private void reporteria_empleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'finalDataSet.reportemplead' Puede moverla o quitarla según sea necesario.
            this.reportempleadTableAdapter.Fill(this.finalDataSet.reportemplead);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
