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
    public partial class reporteriaegresos : Form
    {
        public reporteriaegresos()
        {
            InitializeComponent();
        }
        public DateTime fechai { set; get; }
        public DateTime fechaf { set; get; }
        private void reporteriaegresos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'finalDataSet.engresosfecha' Puede moverla o quitarla según sea necesario.
            this.engresosfechaTableAdapter.Fill(this.finalDataSet.engresosfecha,fechai,fechaf);

            this.reportViewer1.RefreshReport();
        }
    }
}
