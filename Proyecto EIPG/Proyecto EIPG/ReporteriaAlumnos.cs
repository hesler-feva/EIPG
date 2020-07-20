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
    public partial class ReporteriaAlumnos : Form
    {
        public ReporteriaAlumnos()
        {
            InitializeComponent();
        }

        private void ReporteriaAlumnos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'finalDataSet1.SP_listar_alumno' Puede moverla o quitarla según sea necesario.
            this.reportalumTableAdapter.Fill(this.finalDataSet.reportalum);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
