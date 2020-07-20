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
    public partial class Egresos_Varios : Form
    {
        public Egresos_Varios()
        {
            InitializeComponent();
        }

        public int indice = 0;
         /*Boton Regresar
         Con el boton regresar le indicamos que cierre la pestaña actual y qeu haga la instancia con el 
         formulario que queremos regresar en este caso el menu de contablidad y le decimos que se abra
             */
        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu_Contabilidad mc = new Menu_Contabilidad();
            mc.Show();
        }

       
        private void Egresos_Varios_Load(object sender, EventArgs e)
        {
            Cmb_Motivo.Focus(); //hacemos un enfoque sobre el combobox para que el usuario tome una decision
            Lbl_Nombre_conta.Text = cache_usuario.Usuario; //cargamos el label con el nombre que se contiene en la clase cache usuario
            Lbl_Identidad_Conta.Text = cache_usuario.Id; //cargamos el label de identidad con la identidad que se contiene en la clase de cache usuario
            DateTime fecha = DateTime.Today; //cargamos la fecha con el dia que se realizara el egreso
            lbl_fecha_transaccion.Text =fecha.ToString("dd/MM/yyy"); //le decimos como queremos que se presente la fecha dia, mes, año
            Procedimientos_Almacenados proc = new Procedimientos_Almacenados(); //hacemos una instancia con la clase procedimiento almacenado
            Cmb_Motivo.DataSource = proc.motivo_egreso(); // le decimos al combobox que tome los datos que esta funcion le regresara
            Cmb_Motivo.DisplayMember = "descripcion_motivo_egreso"; //los items del combobox tomaran los datos de la columna description motivo de egreso
            Cmb_Motivo.ValueMember = "id_motivos_egreos"; //y los indices del combobox seran los de la columna id motivo de egreso
            Cmb_Motivo.SelectedIndex = indice; //para asignar los valores de acuerdo al indice del combobox
        }

        private void tbxID_Padre_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxID_Padre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validacion de tecla precionada validada con codigo ASCII en caso que se cumpla la condicion presentara "ingrese solo numeros"
            if ((e.KeyChar >= 0 && e.KeyChar <= 7) || (e.KeyChar >= 9 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo numeros");
                e.Handled = true;
            }
        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFinalizar_Transac_Click(object sender, EventArgs e)
        {
            //el boton finalizar transaccion 
            Procedimientos_Almacenados proc = new Procedimientos_Almacenados(); //hacemos una instancia con la clase de procedimientos almacenados
            //validamos que no quede ningun campo vacio en caso que se cumpla la validacion lanza la advertencia
            if (Cmb_Motivo.SelectedIndex == 0 || Msk_Identidad.Text == "" || Txt_Nombre_Cliente.Text.Equals("") || Txt_Monto.Text.Equals("") || Txt_Descripcion.Text.Equals(""))
            {
                MessageBox.Show("Error, no debe dejar campos vacios");
            }
            else //en caso contrario entra a otra decision
            {
                //se presenta esta decision ya que si es un pago de salario solo se hala el id del empleado en caso contrario se registra el id de la persona a quien se le da el egreso
                if (Cmb_Motivo.SelectedIndex == 1) //si el indice del combobox es 1 se realiza el siguiente proceso
              {
                    //primero llamamaos a la funcion egresos a traves de la instancia y le mandamos los datos que queremos que registre
                    proc.Egresos(Txt_Nombre_Cliente.Text, Txt_Descripcion.Text, Convert.ToDateTime(lbl_fecha_transaccion.Text), Convert.ToDecimal(Txt_Monto.Text), 1, 2, Msk_Identidad.Text);
                    Txt_Nombre_Cliente.Clear(); Txt_Descripcion.Clear(); Txt_Monto.Clear(); Msk_Identidad.Clear();
                    MessageBox.Show("Transaccion Exitosa");
                }
                else
                {
                    //primero llamamaos a la funcion egresos a traves de la instancia y le mandamos los datos que queremos que registre
                    proc.Egresos2(Txt_Nombre_Cliente.Text, Txt_Descripcion.Text, Convert.ToDateTime(lbl_fecha_transaccion.Text), Convert.ToDecimal(Txt_Monto.Text), 1, 2, Msk_Identidad.Text);
                    Txt_Nombre_Cliente.Clear(); Txt_Descripcion.Clear(); Txt_Monto.Clear(); Msk_Identidad.Clear();
                    MessageBox.Show("Transaccion Exitosa");
                }
            }
        }

        private void cmb_motivo_RightToLeftChanged(object sender, EventArgs e)
        {

        }

        private void cmb_motivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int bandera=0; //variable que nos servira como indicador
            //si el motivo es la opcion 1 pago de salario entra al siguiente bloque 
            if (Cmb_Motivo.SelectedIndex == 1)
            {
                Btn_Limpiar.Enabled = false; //deshabilitamos el boton de limpiar ya que no se llenara ningun combobox si no que se traera de la base de datos
                bandera++; //le decimos al valor de bandera que aumente en 1
                if (bandera>=1) //si la bandera es igual o mayor que 1 entra al siguiente bloque
                {
                    //deshabilitamos todos los datos de entrada y en el texbox de descripcion toma el valor de pago salario
                    Txt_Nombre_Cliente.Enabled = false; // 
                    Msk_Identidad.Enabled = false;
                    Btn_Buscar.Enabled = true;
                    Txt_Descripcion.Enabled = false;
                    Txt_Monto.Enabled = false;
                    Txt_Descripcion.Text = "Pago Salario";
                }
                else
                {
                    //si la condicion anterior no se cumple entonces se limpian todos los comboox y se deshabilitan 
                    Btn_Buscar.Focus();
                    Msk_Identidad.Clear();
                    Txt_Monto.Clear();
                    Txt_Nombre_Cliente.Clear();
                    Txt_Nombre_Cliente.Enabled = false;
                    Msk_Identidad.Enabled = false;
                    Btn_Buscar.Enabled = true;
                    Txt_Descripcion.Enabled = false;
                    Txt_Monto.Enabled = false;
                    Txt_Descripcion.Text = "Pago Salario";
                }
                
            }
            else //si el motivo no es un pago de salario hace lo siguiente
            {
                //habilita todos los campos de entrada
                Btn_Limpiar.Enabled = true;
                Btn_Buscar.Enabled = false;
                Txt_Nombre_Cliente.Enabled = true;
                Msk_Identidad.Enabled = true;
                Btn_Buscar.Enabled = false;
                Txt_Descripcion.Enabled = true;
                Txt_Monto.Enabled = true;
                Txt_Descripcion.Text = "";
            }
        }

        private void tbxNombre_Cliente_Validated(object sender, EventArgs e)
        {
           
        }

        private void tbxNombre_Cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validamos que solo puede ingresar letra(tambien caracteres especiales) en caso contrario mostrara el mensaje ingrese solo letras
            if ((e.KeyChar >= 0 && e.KeyChar <= 7) || (e.KeyChar >= 9 && e.KeyChar <= 31) || (e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar >= 255))
            {
                MessageBox.Show("Ingrese solo Letras");
                e.Handled = true;
            }
        }

        private void txt_descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validamos que solo puede ingresar letras(sin caracteres especiales) en caso contrario mostrara el mensaje ingrese solo letras
            if ((e.KeyChar >= 0 && e.KeyChar <= 7) || (e.KeyChar >= 9 && e.KeyChar <= 31) || (e.KeyChar >= 33 && e.KeyChar <= 39) || (e.KeyChar >= 42 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47) || (e.KeyChar >= 60 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar >= 255))
            {
                MessageBox.Show("No se permiten caracteres especiales");
                e.Handled = true;
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            reportes.Reporte_empleado = 1; //en el formulario reportes hay una variable global publica establecida como bandera para que en el momento que se cierre sepa a que formulario regresar
            Reporte_Empleados re = new Reporte_Empleados(); //intancia a reporte empledos
            //re.valor = 1;
            re.Show(); //que abra el formulario de reportes
            this.Hide(); //que cierre el formulario actual
        }

        private void Egresos_Varios_FormClosing(object sender, FormClosingEventArgs e)
        {
            //validacion en caso que por accidente cierre el formulario
            if (MessageBox.Show("¿Está seguro que desea salir?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Menu_Contabilidad mc = new Menu_Contabilidad();
                mc.Show();
            }
        }

        private void Btn_limpiar_Click(object sender, EventArgs e)
        {
            //el boton limpiar lo que hace es dejar en blanco todos los texbox
            Msk_Identidad.Clear();
            Txt_Nombre_Cliente.Clear();
            Txt_Monto.Clear();
            Txt_Descripcion.Clear();
        }
    }
}
