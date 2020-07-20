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
    public partial class Panel_carrera : Form
    {
        Procedimientos_Almacenados procedimientos = new Procedimientos_Almacenados();

        public Panel_carrera()
        {
            InitializeComponent();
        }

        private void Panel_carrera_Load(object sender, EventArgs e)
        {
          
            procedimientos.listar_grado_academico(Cmb_Nivel_Academico);
        }
    }
}
