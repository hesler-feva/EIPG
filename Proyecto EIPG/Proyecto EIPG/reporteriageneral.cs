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
    public partial class reporteriageneral : Form
    {
        public reporteriageneral()
        {
            InitializeComponent();
        }
        public DateTime fechai { set; get; }
        public DateTime fechaf { set; get; }
        private void reporteriageneral_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'finalDataSet.ingresosfecha' Puede moverla o quitarla según sea necesario.
            this.ingresosfechaTableAdapter.Fill(this.finalDataSet.ingresosfecha,fechai,fechaf);
            // TODO: esta línea de código carga datos en la tabla 'finalDataSet.engresosfecha' Puede moverla o quitarla según sea necesario.
            this.engresosfechaTableAdapter.Fill(this.finalDataSet.engresosfecha,fechai,fechaf);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
