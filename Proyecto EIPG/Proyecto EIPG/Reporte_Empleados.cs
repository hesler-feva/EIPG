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
    public partial class Reporte_Empleados : Form
    {
        public Reporte_Empleados()
        {
            InitializeComponent();
        }
        //varibale para asignar los valores que se enviaran a otro formulario
        public int i=0;
        String id_usuario,id_contrasena,id_rol, id_estado_civil, id_estado_emp, id_genero_emp, id_empleado, primer_nombre_emp, segundo_nombre_emp, primer_apellido_emp, segundo_apellido_emp, correo, telefono, direccion, titulo, post_grado, experiencia;

        private void Lbl_Nombre_Admin_Click(object sender, EventArgs e)
        {

        }

        //funcion para llenar el datagid con empleados de acuerdo al estado inactivo
        private void rdbn_E_inactivo_CheckedChanged(object sender, EventArgs e)
        {
            string estado = " ";

            if (rdbn_E_inactivo.Checked == true)
                estado = "2";


            Procedimientos_Almacenados proc = new Procedimientos_Almacenados();
            dataGridView1.DataSource = proc.Reporte_empleado_por_estado(estado);

        }

        //funcion para llenar el datagid con empleados de acuerdo al estado activo
        private void rdbn_E_activo_CheckedChanged(object sender, EventArgs e)
        {
            string estado = " ";

            if (rdbn_E_activo.Checked == true)
                estado = "1";


            Procedimientos_Almacenados proc = new Procedimientos_Almacenados();
            dataGridView1.DataSource = proc.Reporte_empleado_por_estado(estado);

        }

        //evento load del formulario de reporte empleados
        private void Reporte_Empleados_Load(object sender, EventArgs e)
        {
            //cargar los datos del usuario que se encuentran en la clase de usuario cache
            Lbl_Nombre_Admin.Text = cache_usuario.Usuario;
            Lbl_Identidad_Admin.Text = cache_usuario.Id;
            Procedimientos_Almacenados proc = new Procedimientos_Almacenados();
            dataGridView1.DataSource = proc.listar_Empleado();
            Txt_NoIdentidad_empleado.Clear();
            Txt_NoIdentidad_empleado.Focus();
         
        }

        //boton generar reporte con los datos que se encuetran en el datagrid
        private void btnGenerar_Reporte_Click(object sender, EventArgs e)
        {
            reporteria_empleados re = new reporteria_empleados();
            ReporteriaEmpleadoAct repact = new ReporteriaEmpleadoAct();

            if(rdbn_E_activo.Checked==true)
            {
                repact.parametro = 1;
                repact.ShowDialog();

            }
            
                if(rdbn_E_inactivo.Checked==true)
                {
                    repact.parametro = 2;
                    repact.ShowDialog();
                }

                if(rdbn_E_activo.Checked==false && rdbn_E_inactivo.Checked==false)
                    {
                        re.ShowDialog();
                    }
               
            
        }
        //boton regresa cierra este formulario
        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //boton refrescar sirve para listar nuevamente todos los empleados despues de realizar una busqueda
        private void btn_refrescar_Click(object sender, EventArgs e)
        {
            Reporte_Empleados ra = new Reporte_Empleados();
            this.Hide();
            ra.Show();
        }

        private void rdbn_morosos_CheckedChanged(object sender, EventArgs e)
        {

        }

        public int valor = 0;
        
        //validacion de la identidad o nombre ingresado donde no se permiten espacion
        private void txbNoIdentidad_empleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 0 && e.KeyChar <= 7) || (e.KeyChar >= 9 && e.KeyChar <= 44) || (e.KeyChar >= 46 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar >= 255))
            {
                MessageBox.Show("Ingrese solo Letras o numeros, no se permiten espacios");
                e.Handled = true;
            }
        }

        
        decimal salario;
        DateTime fecha;
        private void pnlReporte_Alum_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            
        }

        //boton buscar alumno
        private void btnBuscar_Alum_Click(object sender, EventArgs e)
        {
            if (Txt_NoIdentidad_empleado.Text.Trim().Equals(""))//primero valida que no este el campo en blanco
            {
                error.SetError(Txt_NoIdentidad_empleado, "Introduzca los datos correctamente");
                Txt_NoIdentidad_empleado.Focus();
            }
            else
            {
                //en caso que no este en blanco manda a llamar los datos al procedimiento almacenado
                error.Clear();
                Procedimientos_Almacenados proc = new Procedimientos_Almacenados();
                dataGridView1.DataSource = proc.Buscar_Empleado(Txt_NoIdentidad_empleado.Text);
                Txt_NoIdentidad_empleado.Clear();
                Txt_NoIdentidad_empleado.Focus();
                MessageBox.Show("Para modificar de doble click sobre el empleado que desea modificar");
            }

            
        }

        //funcion por si el empleado presiona el boton de cerrar formulario por equivocacion
        private void Reporte_Empleados_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Menu_Admin ma = new Menu_Admin();
                ma.Show();
            }
        }

        //funcion para asignar los valores de la linea selecciona al hacer clic en una variable
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            if (i != -1)
            {
              //asignacion del valor de la celda en la varibale
                id_empleado = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value.ToString());
                primer_nombre_emp = Convert.ToString(dataGridView1.Rows[i].Cells[1].Value.ToString());
                segundo_nombre_emp = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value.ToString());
                primer_apellido_emp = Convert.ToString(dataGridView1.Rows[i].Cells[3].Value.ToString());
                segundo_apellido_emp = Convert.ToString(dataGridView1.Rows[i].Cells[4].Value.ToString());
                fecha = Convert.ToDateTime(dataGridView1.Rows[i].Cells[5].Value.ToString());
                correo = Convert.ToString(dataGridView1.Rows[i].Cells[6].Value.ToString());
                telefono = Convert.ToString(dataGridView1.Rows[i].Cells[7].Value.ToString());
                direccion = Convert.ToString(dataGridView1.Rows[i].Cells[8].Value.ToString());
                salario = Convert.ToDecimal(dataGridView1.Rows[i].Cells[9].Value.ToString());
                titulo = Convert.ToString(dataGridView1.Rows[i].Cells[10].Value.ToString());
                post_grado = Convert.ToString(dataGridView1.Rows[i].Cells[11].Value.ToString());
                experiencia = Convert.ToString(dataGridView1.Rows[i].Cells[12].Value.ToString());
                 id_genero_emp = dataGridView1.Rows[i].Cells[13].Value.ToString();
                id_estado_emp = dataGridView1.Rows[i].Cells[14].Value.ToString();
                id_estado_civil = dataGridView1.Rows[i].Cells[15].Value.ToString();
                id_rol = dataGridView1.Rows[i].Cells[16].Value.ToString();
                id_usuario = Convert.ToString(dataGridView1.Rows[i].Cells[17].Value.ToString());
                id_contrasena = Convert.ToString(dataGridView1.Rows[i].Cells[18].Value.ToString());
                // usuario_empe = dataGridView1.Rows[i].Cells[17].Value.ToString();
                if (reportes.Reporte_empleado == 0) //si es una actualizacion del empleado manda las variables al formulario del empleado
                {
                    Ingresar_Empleado ie = new Ingresar_Empleado();
                    ie.seleccion1 = 1;
                    ie.Cmb_Estado_Empleado_.Enabled = true;
                    ie.Lbl_Estado_Empleado.Enabled = true;
                    ie.Mask_No_Identidad_Emple.Text = id_empleado;
                    ie.Txb_Primer_Nombre_Emple.Text = primer_nombre_emp;
                    ie.Txt_Segundo_Nombre_Emple.Text = segundo_nombre_emp;
                    ie.Txt_Primer_Apellido_Emple.Text = primer_apellido_emp;
                    ie.Txt_Segundo_Apellido_Emple.Text = segundo_apellido_emp;
                    ie.Txt_Correo_Emple.Text = correo;
                    ie.Mask_NumeroFijo_Emp.Text = telefono;
                    ie.Txt_Direccion_Emple.Text = direccion;
                    ie.Txt_Salario_Emple.Text = salario.ToString();
                    ie.Txt_Titulo_Emple.Text = titulo;
                    ie.Txt_Post_Grado_Emple.Text = post_grado;
                    ie.Txt_Experiencia_Emple.Text = experiencia;
                    ie.cmbGenero_Emple = id_genero_emp;
                    ie.cmbEstado_Empleado = id_estado_emp;
                    ie.cmb_estado_civil = id_estado_civil;
                    ie.cmb_nivel_acceso = id_rol;
                    ie.Txt_Usuario_Emple.Text = id_usuario;
                    reportes.Usuario = id_usuario;
                    reportes.Contrasena = id_contrasena;
                    ie.Txt_Contraseña_Emple.Text = reportes.Contrasena;

                    ie.Btn_Actualizar.Enabled = true;
                    ie.Btn_Guardar.Enabled = false;

                    this.Hide();
                    ie.ShowDialog();
                }
                else//en caso contrario los manda al formulario de pago de salario
                {
                    Egresos_Varios ev = new Egresos_Varios();
                    ev.indice = 1;
                    ev.Msk_Identidad.Text = id_empleado;
                    ev.Txt_Nombre_Cliente.Text = (primer_nombre_emp +" "+ segundo_nombre_emp +" "+ primer_apellido_emp +" "+ segundo_apellido_emp);
                    ev.Txt_Descripcion.Text = "Pago Salario";
                    ev.Txt_Monto.Text = salario.ToString();
                    this.Hide();
                    ev.Show();
                }
               
            }
        }
    }
}
