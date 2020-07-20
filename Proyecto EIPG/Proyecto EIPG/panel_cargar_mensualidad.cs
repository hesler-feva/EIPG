using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
namespace Proyecto_EIPG
{
    public partial class panel_cargar_mensualidad : Form
    {
        Procedimientos_Almacenados procedimientos = new Procedimientos_Almacenados();
        public panel_cargar_mensualidad()
        {
            InitializeComponent();
        }

        //panel cargar mensualidad evento load
        private void panel_cargar_mensualidad_Load(object sender, EventArgs e)
        {
            //se cargan los combobox con los datos que retornan los procedimientos almacenados
            procedimientos.listar_grado_academico(Cmb_Nivel_Academico);
            dataGridView1.DataSource = procedimientos.listar_Precio_Grados();
        }

        //boton actualizar
        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            borrar_mensaje_error();//llama la funcion de error y borra las advertencias anteriores
            DialogResult result; //variable para hacer una pregunta de si o no al usuario
            string nivel; 
            nivel = Cmb_Nivel_Academico.Text; //se le asigna el valor del combobox a la variable nivel
            result = MessageBox.Show("¿Desea aumentar la mensualidad a la modalidad de " + nivel + "?" , "Confirmacion",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (validaciones() && DialogResult.Yes == result)//validacion en caso que se cumplan las validacion y la respuesta del usuario sea si
            {
                double porcentaje;
                porcentaje = double.Parse(comboBox1.Text) / 100;//convierte el valor del porcentaje que se incrementara
                procedimientos.Aumento_Mensualidad(Convert.ToDecimal(porcentaje), nivel);//le manda el porcentaje y el nivel academico a el procedimiento almacenado
                MessageBox.Show("Cambios realizados con exito");
                //regresa los combobox a sus valores iniciales
                Cmb_Nivel_Academico.SelectedIndex = 0;
                comboBox1.SelectedIndex = 0;
                //actualiza el datagrid
                dataGridView1.DataSource = procedimientos.listar_Precio_Grados();
            }

        }

        //funcion borrar mensaje error
        private void borrar_mensaje_error()
        {
            errorProvider1.SetError(comboBox1, "");
            errorProvider1.SetError(Cmb_Nivel_Academico, "");
        }

        //funcion de validaciones en caso que algun campo este vacio
        private bool validaciones()
        {
            bool ok = true;
            //nivel academico
            if (Cmb_Nivel_Academico.Text.Equals("Seleccione"))
            {
                ok = false;
                errorProvider1.SetError(Cmb_Nivel_Academico, "Seleccione Un Nivel Academico");
            }

            //porcentaje
            if (comboBox1.Text.Equals(""))
            {
                ok = false;
                errorProvider1.SetError(comboBox1, "Seleccione Un Porcentaje");
            }
            return ok;
        }
        //boton nuevo
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Cmb_Nivel_Academico.SelectedIndex = 0;
            Cmb_Nivel_Academico.Enabled = true;
            Cmb_Nivel_Academico.Enabled = false;
        }

        //validacion de la tecla presionada
        private void Txt_porcentaje_a_cargar_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator)
            {

                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if(char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
