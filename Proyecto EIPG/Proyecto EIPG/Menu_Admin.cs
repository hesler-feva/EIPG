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
    public partial class Menu_Admin : Form
    {
        public Menu_Admin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        //boton reporte de docentes
        private void btnReporte_Docen_Click(object sender, EventArgs e)
        {
            Reporte_Empleados repor_emple = new Reporte_Empleados();//intancia con el formulario de reporteria de docentes
            this.Close();//cierra este formulario
            repor_emple.Show();//abre el formulario de docentes
            MessageBox.Show("Para modificar de doble click sobre el Empleado que desea modificar.\n Si decide buscar un empleado por identidad debe introducir los guiones");
        }
        
        //boton ingreso de alumnos
        private void btnIngreso_Alum_Click(object sender, EventArgs e)
        {
            //hace la instancia con el formulario de ingreso de alumnos y habilita los botones menos el de actualizar y los combobox innecesarios
            Ingresar_Alumno ingre_alum = new Ingresar_Alumno();
            ingre_alum.Btn_Guardar.Enabled = true;
            ingre_alum.Btn_Actualizar.Enabled = false;
            ingre_alum.Cmb_Estado_Alumno_.Enabled = false;
            ingre_alum.Lbl_Estado_Alumno.Enabled = false;
            this.Close();
            ingre_alum.Show();
       
        }

        //boton ingreso de empleado 
        private void btnIngreso_Emple_Click(object sender, EventArgs e)
        {
            //hace la instancia con este formulario y ddeshabulita algunos botones 
            Ingresar_Empleado ingre_emple = new Ingresar_Empleado();
            ingre_emple.Btn_Actualizar.Enabled = false;
            ingre_emple.Btn_Guardar.Enabled = true;
            ingre_emple.Cmb_Estado_Empleado_.Enabled = false;
            ingre_emple.Lbl_Estado_Empleado.Enabled = false;
            this.Close();
            ingre_emple.Show();
        }

        //boton reporte alumnos
        private void btnReporte_Alum_Click(object sender, EventArgs e)
        {
            Reporte_Alumnos repor_alum = new Reporte_Alumnos();//hace la instancia con el fromulario de reportes de alumno
            this.Close(); //cierra este formulario
            repor_alum.Show();  //abre el formulario de reportes de alumno
            reportes.Reporte_alumno = 1; //le envia un valor bandera para que el fomulario sepa que tiene que regresar a este formulario
            repor_alum.valor = 1; //envia el valor de 1 como bandera para que regrese a este
            MessageBox.Show("Para modificar de doble click sobre el alumno que desea modificar.\n Si decide buscar un alumno por identidad debe introducir los guiones");
        }

        //boton reporte contable
        private void btnReporte_Contable_Click(object sender, EventArgs e)
        {
            Procedimientos_Almacenados proc = new Procedimientos_Almacenados();//hace la instancia con procedimiento almacenado
            proc.cierre_de_anio(); //llama a la funcion de cierre de año en caso de ser el mes 12
            proc.Historial_cierre_anio(); //manda los datos a la tabla de historial academico
            proc.limpieza_alumnos();//limpia la tabla de alumnos
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //evento load del menu administrativo
        private void Menu_Admin_Load(object sender, EventArgs e)
        {
            //carga los datos de los usuarios con los datos almacenados en la clase de usuarios cache
            lblNombre_admin.Text = cache_usuario.Usuario;
            lblIdentidad_Admin.Text = cache_usuario.Id;
            DateTime fecha = new DateTime();//carga la fecha del dia ingresado
            //decision si el mes es 12 mostrar el boton de cierre de año solo para el cargo de director
            if (fecha.ToString("MM/yyyy").Equals(fecha.ToString("12/yyyy")) && lbl_Cargo.Equals("Director"))
            {
                Btn_Cierre_de_año.Visible = true;
            }
        }

        private void Menu_Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void Btn_Mantenimiento_Academico_Click(object sender, EventArgs e)
        {
            
        }

        //boton de mantenimiento academico
        private void button1_Click(object sender, EventArgs e)
        {
             Mantenimiento_Academico MA = new Mantenimiento_Academico();//hace la instancia
            this.Close();//cierra este formulario
            MA.Show();//abre el formulario de mantenimiento
        }
    }
}
