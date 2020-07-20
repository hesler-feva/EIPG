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
    public partial class ReporteAlumnosGrado : Form
    {
        public ReporteAlumnosGrado()
        {
            InitializeComponent();
        }
        public int parametro { set; get; }
        private void ReporteAlumnosGrado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'finalDataSet.AlumnosPorGrado' Puede moverla o quitarla según sea necesario.
            this.AlumnosPorGradoTableAdapter.Fill(this.finalDataSet.AlumnosPorGrado,parametro);
            this.reportViewer1.RefreshReport();

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
