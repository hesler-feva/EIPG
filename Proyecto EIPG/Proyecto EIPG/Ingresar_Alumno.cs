using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Datos_usuarios.cache;
namespace Proyecto_EIPG
{
    public partial class Ingresar_Alumno : Form
    {
        //variables globales para su uso en la validacion cuando se registran alumnos o se carga el formulario
        public string Correo;
        public string Arroba = "a";
        public int  Seleccion=0;
        public String  Cmb_Genero_Alu, Cmb_Estado_Alumno, Cmb_Grado_Alu, Cmb_Genero_Pariente;

        public Ingresar_Alumno()
        {
            InitializeComponent();
        }

        private void pnlIngreso_Alum_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Boton guardar
            Procedimientos_Almacenados proc = new Procedimientos_Almacenados();//instancia con la clase procedimiento almacenado
            int Consultar = proc.Verificar_Existencia(Mask_NoIdentidad_Alum.Text); //primero verifica que el alumno ingresado no este ya matriculado en la institucion
            int Consultar2 = proc.Verificar_Existencia_padre(Mask_No_Identidad_padre.Text);//verifica que el padre del alumno no este matricula en caso que este se le aumenta la cantidad de hijos
            int nivel = 0;

            if (validar_email(Txt_Correo_Padre.Text)) //manda a llamar la validacion de correo en caso contrario lo deja vacio
            {
            }
            else
            {
                Txt_Correo_Padre.Text = "";
            }

            //si la validacion de existencia de alumno anterior da positivo entonces nos muestra un error
            if (Consultar == 1)
            {
                MessageBox.Show("Error, el Alumno ya ha sido ingresado");

            }
            else
            {
                //validacion en caso que la identidad del alumno no puede ser la misma que la identidad del padre
                if (Mask_NoIdentidad_Alum.Text.Equals(Mask_No_Identidad_padre.Text))
                {
                    MessageBox.Show("Identidad de alumno no puede ser igual que Identidad de padre");
                }
                else
                {
                    //se valida que todos los combobox esten seleccionados ya que los texbox tienen validaciones aparte
                    if (Cmb_Genero_Alumno.SelectedIndex == 0 || Cmb_Grado.SelectedIndex == 0 || Cmb_Genero_Padre.SelectedIndex == 0)
                    {
                        MessageBox.Show("Error, datos no pueden quedar vacios");
                    }
                    else
                    {
                        //si no da ninguno de los problemas anteriores se procede a registrar al alumno
                        try
                        {
                            //primero validamos que la edad del alumno valla de acuerdo con el grado ("Esta validacion solo se hace para el primer nivel academico")
                            if ((int.Parse(Txt_Edad_Alum.Text) > 8 && Cmb_Grado.SelectedIndex == 1) || (int.Parse(Txt_Edad_Alum.Text) <5 && Cmb_Grado.SelectedIndex == 1) )
                            {
                                MessageBox.Show("Error, la edad no permite la inscripcion del niño en el grado seleccionado");
                            }
                            else
                            {
                              //asignamos los indices de los combobox a una variable
                                if (Cmb_Grado.SelectedIndex == 1)
                                {
                                    nivel = 1;
                                }
                                if (Cmb_Grado.SelectedIndex > 1 && Cmb_Grado.SelectedIndex < 8)
                                {
                                    nivel = 2;
                                }
                                if (Cmb_Grado.SelectedIndex > 7 && Cmb_Grado.SelectedIndex < 11)
                                {
                                    nivel = 3;
                                }
                                if (Cmb_Grado.SelectedIndex > 11)
                                {
                                    nivel = 4;
                                }
                                if (Consultar2==1)//si el padre ya esta registrado entonces se le da un descuento y no se registra el padre solo se le aumenta la cantidad de hijos en la intitucion
                                {
                                    double descuento = 0;
                                    descuento = double.Parse(Txt_Mensualidad.Text) -(double.Parse(Txt_Mensualidad.Text) * 0.10);//se calcula el descuento

                                    proc.aumentar_hijos_pariente(Mask_No_Identidad_padre.Text);//aumenta la cantidad de hijos del padre
                                    proc.Ingresar_Alumno(Mask_NoIdentidad_Alum.Text, Txt_PrimerNombre_Alum.Text, Txt_SegundoNombre_Alum.Text, Txt_Primer_Apelldo_Alum.Text, Txt_SegundoApellido_Alum.Text, Dtp_Fecha_Nacimiento_Alum.Value, Mask_No_Identidad_padre.Text, Txt_EstadoSalud_Alum.Text, Cmb_Genero_Alumno.SelectedIndex, 1, nivel, Cmb_Grado.SelectedIndex, Convert.ToDecimal(descuento)+650);//registrar el alumno
                                    //una vez ingresado el alumno se procede a limpiar todos los campos antes llenados
                                    Mask_No_Identidad_padre.Clear(); Txt_Primer_Nombre_Padre.Clear(); Txt_Segundo_Nombre_Padre.Clear(); Txt_Primer_Apellido_Padre.Clear(); Txt_Segundo_Apellido_Padre.Clear(); Txt_Correo_Padre.Clear(); Mask_NumeroMovil_Padre.Clear(); Txt_Direccion_Padre.Clear(); Txt_Edad_Padre.Clear();
                                    Mask_NoIdentidad_Alum.Clear(); Txt_PrimerNombre_Alum.Clear(); Txt_SegundoNombre_Alum.Clear(); Txt_Primer_Apelldo_Alum.Clear(); Txt_SegundoApellido_Alum.Clear(); Mask_No_Identidad_padre.Clear(); Txt_EstadoSalud_Alum.Clear(); Txt_Edad_Alum.Clear();
                                    Cmb_Genero_Alumno.SelectedIndex = 0; Cmb_Grado.SelectedIndex = 0; Cmb_Genero_Padre.SelectedIndex = 0;
                                    Dtp_Fecha_Nacimiento_Alum.Value = Convert.ToDateTime("31/12/1998"); Dtp_FechaNacimiento_Padre.Value = Convert.ToDateTime("31 / 12 / 1995");
                                    Txt_Edad_Alum.Text = ""; Txt_Edad_Padre.Text = ""; Txt_Mensualidad.Text = "";
                                    MessageBox.Show("guardado con exito"); //se muestra el mensaje guardado con exito
                                }
                                else
                                {
                                    //en caso de que el padre no tenga ningun otro hijo en la institucion se registra con normalidad
                                    proc.Ingresar_Pariente(Mask_No_Identidad_padre.Text, Txt_Primer_Nombre_Padre.Text, Txt_Segundo_Nombre_Padre.Text, Txt_Primer_Apellido_Padre.Text, Txt_Segundo_Apellido_Padre.Text, Dtp_FechaNacimiento_Padre.Value, Txt_Correo_Padre.Text, Mask_NumeroMovil_Padre.Text, Txt_Direccion_Padre.Text, Cmb_Genero_Padre.SelectedIndex,1);
                                    proc.Ingresar_Alumno(Mask_NoIdentidad_Alum.Text, Txt_PrimerNombre_Alum.Text, Txt_SegundoNombre_Alum.Text, Txt_Primer_Apelldo_Alum.Text, Txt_SegundoApellido_Alum.Text, Dtp_Fecha_Nacimiento_Alum.Value, Mask_No_Identidad_padre.Text, Txt_EstadoSalud_Alum.Text, Cmb_Genero_Alumno.SelectedIndex, 1, nivel, Cmb_Grado.SelectedIndex, Convert.ToDecimal(double.Parse(Txt_Mensualidad.Text) + 650));
                                    Mask_No_Identidad_padre.Clear(); Txt_Primer_Nombre_Padre.Clear(); Txt_Segundo_Nombre_Padre.Clear(); Txt_Primer_Apellido_Padre.Clear(); Txt_Segundo_Apellido_Padre.Clear(); Txt_Correo_Padre.Clear(); Mask_NumeroMovil_Padre.Clear(); Txt_Direccion_Padre.Clear(); Txt_Edad_Padre.Clear();
                                    Mask_NoIdentidad_Alum.Clear(); Txt_PrimerNombre_Alum.Clear(); Txt_SegundoNombre_Alum.Clear(); Txt_Primer_Apelldo_Alum.Clear(); Txt_SegundoApellido_Alum.Clear(); Mask_No_Identidad_padre.Clear(); Txt_EstadoSalud_Alum.Clear(); Txt_Edad_Alum.Clear();
                                    Cmb_Genero_Alumno.SelectedIndex = 0; Cmb_Grado.SelectedIndex = 0; Cmb_Genero_Padre.SelectedIndex = 0;
                                    Dtp_Fecha_Nacimiento_Alum.Value = Convert.ToDateTime("31/12/1998"); Dtp_FechaNacimiento_Padre.Value = Convert.ToDateTime("31 / 12 / 1995");
                                    Txt_Edad_Alum.Text = ""; Txt_Edad_Padre.Text = ""; Txt_Mensualidad.Text = "";
                                    MessageBox.Show("guardado con exito");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            //si los datos estan vacios provoca que sql no pueda realizar el registro y mostramos el mensaje
                            System.Windows.Forms.MessageBox.Show("los datos no pueden estar vacios "+ex.ToString());
                        }

                    }
                }
            }
        }
        //validacion con codigo ASCII donde nos indica que solo se debe ingresar numeros
        private void txt_NoIdentidad_Alum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >=0 && e.KeyChar <=47) || (e.KeyChar >=58 && e.KeyChar <=255))
            {
                MessageBox.Show("Ingrese solo Numeros");
                e.Handled = true;
            }
        }

        //validacion con codigo ASCII donde nos indica que solo se debe ingresar letras
        private void txt_PrimerNombre_Alum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 0 && e.KeyChar <= 7)  || (e.KeyChar >= 9 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar >= 255))
            {
                MessageBox.Show("Ingrese solo Letras");
                e.Handled = true;
            }
            
        }

        //validacion con codigo ASCII donde nos indica que solo se debe ingresar letras
        private void txt_SegundoNombre_Alum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 0 && e.KeyChar <= 7) || (e.KeyChar >= 9 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar >= 255))
            {
                MessageBox.Show("Ingrese solo Letras");
                e.Handled = true;
            }
        }

        //validacion con codigo ASCII donde nos indica que solo se debe ingresar letras
        private void txt_PrimerApelldo_Alum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 0 && e.KeyChar <= 7) || (e.KeyChar >= 9 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar >= 255))
            {
                MessageBox.Show("Ingrese solo Letras");
                e.Handled = true;
            }
        }

        private void txt_SegundoApellido_Alum_TextChanged(object sender, EventArgs e)
        {

        }

        //validacion con codigo ASCII donde nos indica que solo se debe ingresar letras
        private void txt_SegundoApellido_Alum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 0 && e.KeyChar <= 7) || (e.KeyChar >= 9 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar >= 255))
            {
                MessageBox.Show("Ingrese solo Letras");
                e.Handled = true;
            }
        }

        //validacion con codigo ASCII donde nos indica que solo se debe ingresar numeros
        private void txt_No_Identidad_padre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 0 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo Numeros");
                e.Handled = true;
            }
        }

        //validacion con codigo ASCII donde nos indica que solo se debe ingresar letras
        private void txt_PrimerNombre_Padre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 0 && e.KeyChar <= 7) || (e.KeyChar >= 9 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar >= 255))
            {
                MessageBox.Show("Ingrese solo Letras");
                e.Handled = true;
            }
        }

        //validacion con codigo ASCII donde nos indica que solo se debe ingresar letras
        private void txt_SegundoNombre_Padre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 0 && e.KeyChar <= 7) || (e.KeyChar >= 9 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar >= 255))
            {
                MessageBox.Show("Ingrese solo Letras");
                e.Handled = true;
            }
        }

        //validacion con codigo ASCII donde nos indica que solo se debe ingresar letras
        private void txt_PrimerApellido_Padre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 0 && e.KeyChar <= 7) || (e.KeyChar >= 9 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar >= 255))
            {
                MessageBox.Show("Ingrese solo Letras");
                e.Handled = true;
            }
        }

        private void txt_SegundoApellido_Padre_TextChanged(object sender, EventArgs e)
        {
           
        }

        //validacion con codigo ASCII donde nos indica que solo se debe ingresar letras
        private void txt_SegundoApellido_Padre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 0 && e.KeyChar <= 7) || (e.KeyChar >= 9 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar >= 255))
            {
                MessageBox.Show("Ingrese solo Letras");
                e.Handled = true;
            }
        }
        //validacion diferente a las anteriores donde se valida que el nombre minimo debe de llevar 3 letras
        private void txt_PrimerNombre_Alum_Validated(object sender, EventArgs e)
        {
            bool ok = true;
            if (Txt_PrimerNombre_Alum.Text.Trim().Equals(""))
            {
                error.SetError(Txt_PrimerNombre_Alum, "Introduzca primer nombre");
                Txt_PrimerNombre_Alum.Focus();
            }
            else
            {
                error.Clear();
            }

            if (Txt_PrimerNombre_Alum.Text.Length < 3)
            {

                ok = false;
                error.SetError(Txt_PrimerNombre_Alum, "Ingrese Nombre valido");
                Txt_PrimerNombre_Alum.Focus();
            }
            else
            {
                error.Clear();
            }
        }

        private void txt_SegundoNombre_Alum_TextChanged(object sender, EventArgs e)
        {

        }

        //validacion diferente a las anteriores donde se valida que el nombre minimo debe de llevar 3 letras
        private void txt_SegundoNombre_Alum_Validated(object sender, EventArgs e)
        {
            bool ok = true;
            if (Txt_SegundoNombre_Alum.Text.Trim().Equals(""))
            {
                error.Clear();
            }
            else
            {
                if (Txt_SegundoNombre_Alum.Text.Trim().Length < 3)
                {

                    ok = false;
                    error.SetError(Txt_SegundoNombre_Alum, "Ingrese Nombre valido");
                    Txt_SegundoNombre_Alum.Focus();
                }
                else
                {
                    error.Clear();
                }
            }
        }

        //validacion diferente a las anteriores donde se valida que el apellido minimo debe de llevar 2 letras
        private void txt_PrimerApelldo_Alum_Validated(object sender, EventArgs e)
        {
            bool ok = true;
            if (Txt_Primer_Apelldo_Alum.Text.Trim().Equals(""))//validacion ya estaba es la que dice si esta vacio el el textbox
            {
                error.SetError(Txt_Primer_Apelldo_Alum, "Introduzca primer apellido");//Si realente el campo no es requerido como el segundo nombre entonces ponemos "ERROR.CLEAR + la condicion de valor minimo"
                Txt_Primer_Apelldo_Alum.Focus();
            }
            else
            {
                error.Clear();
            }
            /*Esta condicion valida el valor minimo para poder ingresar en un textbox

            

             */
            if (Txt_Primer_Apelldo_Alum.Text.Length < 2)//compara si el tamaño de la cadena es menor a 2
            {

                ok = false;
                error.SetError(Txt_Primer_Apelldo_Alum, "Ingrese Apellido valido");//enfoca el error provider
                Txt_Primer_Apelldo_Alum.Focus();
            }
            else
            {
                error.Clear();//si no es menor que 2 entoces limpia el error provider
            }
        }

        //validacion diferente a las anteriores donde se valida que el apellido minimo debe de llevar 2 letras
        private void txt_SegundoApellido_Alum_Validated(object sender, EventArgs e)
        {
            bool ok = true;
            if (Txt_SegundoApellido_Alum.Text.Trim().Equals(""))
            {
                error.Clear();
            }
            else
            {



                if (Txt_SegundoApellido_Alum.Text.Trim().Length < 2)
                {

                    ok = false;
                    error.SetError(Txt_SegundoApellido_Alum, "Ingrese Apellido valido");
                    Txt_SegundoApellido_Alum.Focus();
                }
                else
                {
                    error.Clear();
                }
            }
        }

        private void txt_No_Identidad_padre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_PrimerNombre_Padre_TextChanged(object sender, EventArgs e)
        {

        }
        //validacion diferente a las anteriores donde se valida que el nombre minimo debe de llevar 3 letras
        private void txt_PrimerNombre_Padre_Validated(object sender, EventArgs e)
        {
            bool ok = true;
            if (Txt_Primer_Nombre_Padre.Text.Trim().Equals(""))
            {
                error.SetError(Txt_Primer_Nombre_Padre, "Introduzca primer nombre");
                Txt_Primer_Nombre_Padre.Focus();
            }
            else
            {
                error.Clear();
            }

            if (Txt_Primer_Nombre_Padre.Text.Length < 3)
            {

                ok = false;
                error.SetError(Txt_Primer_Nombre_Padre, "Ingrese Nombre valido");
                Txt_Primer_Nombre_Padre.Focus();
            }
            else
            {
                error.Clear();
            }
        }

        //validacion diferente a las anteriores donde se valida que el nombre minimo debe de llevar 3 letras
        private void txt_SegundoNombre_Padre_Validated(object sender, EventArgs e)
        {
            bool ok = true;
            if (Txt_Segundo_Nombre_Padre.Text.Trim().Equals(""))
            {
                error.Clear();
            }
            else
            {
                if (Txt_Segundo_Nombre_Padre.Text.Trim().Length < 3)
                {

                    ok = false;
                    error.SetError(Txt_Segundo_Nombre_Padre, "Ingrese Nombre valido");
                    Txt_Segundo_Nombre_Padre.Focus();
                }
                else
                {
                    error.Clear();
                }
            }
        }

        //validacion diferente a las anteriores donde se valida que el apellido minimo debe de llevar 2 letras
        private void txt_PrimerApellido_Padre_Validated(object sender, EventArgs e)
        {
            bool ok = true;
            if (Txt_Primer_Apellido_Padre.Text.Trim().Equals(""))//validacion ya estaba es la que dice si esta vacio el el textbox
            {
                error.SetError(Txt_Primer_Apellido_Padre, "Introduzca primer apellido");//Si realente el campo no es requerido como el segundo nombre entonces ponemos "ERROR.CLEAR + la condicion de valor minimo"
                Txt_Primer_Apellido_Padre.Focus();
            }
            else
            {
                error.Clear();
            }
            /*Esta condicion valida el valor minimo para poder ingresar en un textbox

            

             */
            if (Txt_Primer_Apellido_Padre.Text.Length < 2)//compara si el tamaño de la cadena es menor a 2
            {

                ok = false;
                error.SetError(Txt_Primer_Apellido_Padre, "Ingrese Apellido valido");//enfoca el error provider
                Txt_Primer_Apellido_Padre.Focus();
            }
            else
            {
                error.Clear();//si no es menor que 2 entoces limpia el error provider
            }
        }

        //validacion diferente a las anteriores donde se valida que el apellido minimo debe de llevar 2 letras
        private void txt_SegundoApellido_Padre_Validated(object sender, EventArgs e)
        {
            bool ok = true;
            if (Txt_Segundo_Apellido_Padre.Text.Trim().Equals(""))
            {
                error.Clear();
            }
            else
            {



                if (Txt_Segundo_Apellido_Padre.Text.Trim().Length < 2)
                {

                    ok = false;
                    error.SetError(Txt_Segundo_Apellido_Padre, "Ingrese Apellido valido");
                    Txt_Segundo_Apellido_Padre.Focus();
                }
                else
                {
                    error.Clear();
                }
            }
        }

        private void txt_SegundoNombre_Padre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_No_Identidad_padre_Validated(object sender, EventArgs e)
        {
            
        }
        //validacion con codigo ASCII que solo se pueden ingresar numeros
        private void txt_Edad_Alum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 0 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo Numeros");
                e.Handled = true;
            }
        }

        private void txt_Correo_Padre_Validated(object sender, EventArgs e)
        {

        }


        private void txt_Direccion_Padre_Validated(object sender, EventArgs e)
        {
            if (Txt_Direccion_Padre.Text.Trim().Equals(""))
            {
                error.SetError(Txt_Direccion_Padre, "Introduzca Identidad");
                Txt_Direccion_Padre.Focus();
            }
            else
            {
                error.Clear();
            }
        }

        

        private void cbx_Genero_Alum_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //boton actualizar
            try
            {
                Procedimientos_Almacenados proc = new Procedimientos_Almacenados();//instancia con la clse procedimientos almacenados
                proc.Actualizar_Pariente(Mask_No_Identidad_padre.Text, Txt_Primer_Nombre_Padre.Text, Txt_Segundo_Nombre_Padre.Text, Txt_Primer_Apellido_Padre.Text, Txt_Segundo_Apellido_Padre.Text, Dtp_FechaNacimiento_Padre.Value, Txt_Correo_Padre.Text, Mask_NumeroMovil_Padre.Text, Txt_Direccion_Padre.Text, Cmb_Genero_Padre.SelectedIndex );//primero actualiza la tabla parientes ya que de esta tabla depende la tabla del alumnos
                proc.Actualizar_Alumno(Mask_NoIdentidad_Alum.Text, Txt_PrimerNombre_Alum.Text, Txt_SegundoNombre_Alum.Text, Txt_Primer_Apelldo_Alum.Text, Txt_SegundoApellido_Alum.Text, Dtp_Fecha_Nacimiento_Alum.Value, Mask_No_Identidad_padre.Text, Txt_EstadoSalud_Alum.Text, Cmb_Genero_Alumno.SelectedIndex , Cmb_Estado_Alumno_.SelectedIndex);//actualiza la tabla alumnos
                if (Cmb_Estado_Alumno_.SelectedIndex==2)//si el combobox de estado alumno es 2 disminuye un hijo del padre ya que este alumno ya no estara activo en la institucion
                {
                    proc.disminuir_hijos_pariente(Mask_No_Identidad_padre.Text);
                }
                //limpiar todos los campos ingresados
                Mask_No_Identidad_padre.Clear(); Txt_Primer_Nombre_Padre.Clear(); Txt_Segundo_Nombre_Padre.Clear(); Txt_Primer_Apellido_Padre.Clear(); Txt_Segundo_Apellido_Padre.Clear(); Txt_Correo_Padre.Clear(); Mask_NumeroMovil_Padre.Clear(); Txt_Direccion_Padre.Clear(); Txt_Edad_Padre.Clear();
                Mask_NoIdentidad_Alum.Clear(); Txt_PrimerNombre_Alum.Clear(); Txt_SegundoNombre_Alum.Clear(); Txt_Primer_Apelldo_Alum.Clear(); Txt_SegundoApellido_Alum.Clear(); Mask_No_Identidad_padre.Clear(); Txt_EstadoSalud_Alum.Clear(); Txt_Edad_Alum.Clear();
                MessageBox.Show("guardado con exito");//mostrar mensaje guardado con exito

            }
            catch (Exception )
            {
                //en caso que presione actualizar y aun tenga campos vacios
                System.Windows.Forms.MessageBox.Show("los datos no pueden estar vacios ");
            }
        }

        //cambio de fecha de nacimiento para ingresar de manera automatica en el campo de edad la edad calculada
        private void dtp_Fecha_Nacimiento_Alum_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha = Dtp_Fecha_Nacimiento_Alum.Value;

            int edad = DateTime.Now.Year - fecha.Year;

            Txt_Edad_Alum.Text = edad.ToString();
        }

        //valida que la identidad ingresada sea correcta
        private void Mask_NoIdentidad_Alum_Validated(object sender, EventArgs e)
        {
            if (Mask_NoIdentidad_Alum.Text.Length < 15)
            {
                error.SetError(Mask_NoIdentidad_Alum, "Introduzca la Identidad correctamente");
                Mask_NoIdentidad_Alum.Focus();
                
            }
            else
            {
                error.Clear();
            }
        }

        private void Mask_NoIdentidad_Alum_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Mask_No_Identidad_padre_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
          
        }
        //valida que la identidad del padre sea correcta
        private void Mask_No_Identidad_padre_Validated(object sender, EventArgs e)
        {
            if (Mask_No_Identidad_padre.Text.Length < 15)
            {
                error.SetError(Mask_No_Identidad_padre, "Introduzca la Identidad correctamente");
                Mask_No_Identidad_padre.Focus();

            }
            else
            {
                error.Clear();
            }


        }

        //cambio de fecha de nacimiento para ingresar de manera automatica en el campo de edad la edad calculada
        private void dtp_FechaNacimiento_Padre_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha = Dtp_FechaNacimiento_Padre.Value;

            int edad = DateTime.Now.Year - fecha.Year;

            Txt_Edad_Padre.Text = edad.ToString();
        }

        private void Mask_NumeroFijo_Padre_Validated(object sender, EventArgs e)
        {
         
        }

        //valida que el numero movil ingresado sea correcto en caso que no tenga limpiar el campo
        private void Mask_NumeroMovil_Padre_Validated(object sender, EventArgs e)
        {
            if (Mask_NumeroMovil_Padre.Text.Length < 11)
            {
                error.SetError(Mask_NumeroMovil_Padre, "Introduzca el numero movil correctamente");
                Mask_NumeroMovil_Padre.Focus();

            }
            else
            {
                error.Clear();
            }
        }

        private void txt_Correo_Padre_TextChanged(object sender, EventArgs e)
        {
            //txt_Correo_Padre.Text = correo;
        }

        private void txt_Edad_Alum_TextChanged(object sender, EventArgs e)
        {

        }

        //validacion del orden en que se deben de ingresar los campos correctos en el correo es decir que solo acepte @ . y los campos necesarios para un correo
        private Boolean validar_email(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        //valida que el correo sea valido en caso contrario muestra un error
        private void txt_Correo_Padre_Leave(object sender, EventArgs e)
        {
            if (validar_email(Txt_Correo_Padre.Text))
            {
                
            }
            else
            {
                if (Txt_Correo_Padre.Text.Trim().Equals(""))
                {
                    error.Clear();
                }
                else
                {
                    error.SetError(Txt_Correo_Padre, "Introduzca el correo correctamente");
                    Txt_Correo_Padre.Focus();

                    MessageBox.Show("Direccion de correo electronico no valido, el correo debe tener el formato: ejemplo@dominio.com," +
                        "Por favor use un direccion de correo electronico valida", "Validacion de Correo Electronico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
        }

        private void Ingresar_Alumno_Load(object sender, EventArgs e)
        {
            //carga los labels con los datos que estan en la clase cache
            Lbl_Nombre_admin.Text = cache_usuario.Usuario;
            Lbl_Identidad_Admin.Text = cache_usuario.Id;
            Procedimientos_Almacenados cbx_genero = new Procedimientos_Almacenados();//intancia a la clase procedimeintos almacenados

            if (Seleccion==0)//si seleccion vale 0 es porque se quiere ingresar un nuevo alumno y se cargan con todos los valores predeterminados los combobox
            {
                //cbx genero
                Cmb_Genero_Alumno.DataSource = cbx_genero.listar_Genero();
                Cmb_Genero_Alumno.DisplayMember = "Nombre";
                Cmb_Genero_Alumno.ValueMember = "ID_Genero";

                //cbx estado
                Cmb_Estado_Alumno_.DataSource = cbx_genero.listar_estado();
                Cmb_Estado_Alumno_.DisplayMember = "Descripcion";
                Cmb_Estado_Alumno_.ValueMember = "ID_estado";

                //cbx nivel de acceso
                Cmb_Genero_Padre.DataSource = cbx_genero.listar_Genero();
                Cmb_Genero_Padre.DisplayMember = "Nombre";
                Cmb_Genero_Padre.ValueMember = "ID_Genero";

                //grado cursando
                Cmb_Grado.DataSource = cbx_genero.listar_grado_cursando();
                Cmb_Grado.DisplayMember = "descripcion_grado_cursando";
                Cmb_Grado.ValueMember = "id_grado_cursando";

            }
            else
            {
                //en caso que se quiera actualizar un alumno se cargan los combobox y luego se selecciona el dato con el que el alumno ya estaba registrado
                //cbx genero
                Cmb_Genero_Alumno.DataSource = cbx_genero.listar_Genero();
                Cmb_Genero_Alumno.DisplayMember = "Nombre";
                Cmb_Genero_Alumno.ValueMember = "ID_Genero";
                // MessageBox.Show(cmb_genero_alu);
                if (Cmb_Genero_Alu.Equals("Masculino"))
                {
                    Cmb_Genero_Alumno.SelectedIndex = 1;
                }
                else
                {
                    Cmb_Genero_Alumno.SelectedIndex = 2;
                }

                //cbx estado
                Cmb_Estado_Alumno_.DataSource = cbx_genero.listar_estado();
                Cmb_Estado_Alumno_.DisplayMember = "Descripcion";
                Cmb_Estado_Alumno_.ValueMember = "ID_estado";
                if (Cmb_Estado_Alumno.Equals("Activo"))
                {
                    Cmb_Estado_Alumno_.SelectedIndex = 1;
                }
                else
                {
                    Cmb_Estado_Alumno_.SelectedIndex = 2;
                }
               

                //cbx nivel de acceso
                Cmb_Genero_Padre.DataSource = cbx_genero.listar_Genero();
                Cmb_Genero_Padre.DisplayMember = "Nombre";
                Cmb_Genero_Padre.ValueMember = "ID_Genero";
                if (Cmb_Genero_Pariente.Equals("Masculino"))
                {
                    Cmb_Genero_Padre.SelectedIndex = 1;
                }
                else
                {
                    Cmb_Genero_Padre.SelectedIndex = 2;
                }

               

                //grado cursando
                Cmb_Grado.DataSource = cbx_genero.listar_grado_cursando();
                Cmb_Grado.DisplayMember = "descripcion_grado_cursando";
                Cmb_Grado.ValueMember = "id_grado_cursando";
                if (Cmb_Grado_Alu.Equals("Kinder"))
                {
                    Cmb_Grado.SelectedIndex = 1;
                }
                if (Cmb_Grado_Alu.Equals("Primer Grado"))
                {
                    Cmb_Grado.SelectedIndex = 2;
                }
                if (Cmb_Grado_Alu.Equals("Segundo Grado"))
                {
                    Cmb_Grado.SelectedIndex = 3;
                }

                if (Cmb_Grado_Alu.Equals("Tercer Grado"))
                {
                    Cmb_Grado.SelectedIndex = 4;
                }

                if (Cmb_Grado_Alu.Equals("Cuarto Grado"))
                {
                    Cmb_Grado.SelectedIndex = 5;
                }

                if (Cmb_Grado_Alu.Equals("Quinto Grado"))
                {
                    Cmb_Grado.SelectedIndex = 6;
                }

                if (Cmb_Grado_Alu.Equals("Sexto Grado"))
                {
                    Cmb_Grado.SelectedIndex = 7;
                }

                if (Cmb_Grado_Alu.Equals("Septimo Grado"))
                {
                    Cmb_Grado.SelectedIndex = 8;
                }

                if (Cmb_Grado_Alu.Equals("Octavo Grado"))
                {
                    Cmb_Grado.SelectedIndex = 9;
                }

                if (Cmb_Grado_Alu.Equals("Noveno Grado"))
                {
                    Cmb_Grado.SelectedIndex = 10;
                }


                if (Cmb_Grado_Alu.Equals("Decimo Grado"))
                {
                    Cmb_Grado.SelectedIndex = 11;
                }

                if (Cmb_Grado_Alu.Equals("Onceavo Grado"))
                {
                    Cmb_Grado.SelectedIndex = 12;
                }


            }


        }

        //validacion con codigos ASCII que solo se pueden ingresar letras
        private void txt_EstadoSalud_Alum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 0 && e.KeyChar <= 7) || (e.KeyChar >= 9 && e.KeyChar <= 31) || (e.KeyChar >= 35 && e.KeyChar <= 39) || (e.KeyChar >= 42 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <=47 ) || (e.KeyChar >= 60 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar >= 255))
            {
                MessageBox.Show("Ingrese solo Letras");
                e.Handled = true;
            }
        }

        private void cmb_grado_SelectedValueChanged(object sender, EventArgs e)
        {
           
           
        }
        //validacion para que cuando el usuario seleccione un grado atravez del procedimiento mande a traer el valor de dicha mensualidad
        private void cmb_grado_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nivel = 0;
            Procedimientos_Almacenados proc = new Procedimientos_Almacenados();
            if (Cmb_Grado.SelectedIndex == 1)
            {
                nivel = 1;
                Txt_Mensualidad.Text =proc.valor_mensualidad(nivel);
               
            }
            else
                if (Cmb_Grado.SelectedIndex > 1 && Cmb_Grado.SelectedIndex < 8)
                {
                    nivel = 2;
                    Txt_Mensualidad.Text =proc.valor_mensualidad(nivel);
                }
                else
                    if (Cmb_Grado.SelectedIndex > 7 && Cmb_Grado.SelectedIndex < 11)
                    {
                        nivel = 3;
                        Txt_Mensualidad.Text = proc.valor_mensualidad(nivel);
                    }
                    else
                        if (Cmb_Grado.SelectedIndex > 10)
                        {
                            nivel = 4;
                            Txt_Mensualidad.Text = proc.valor_mensualidad(nivel);
                        }
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {

        }

        //validacion con codigos ASCII que no se permitan ingresar caracteres especiales
        private void txt_Direccion_Padre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 0 && e.KeyChar <= 7) || (e.KeyChar >= 9 && e.KeyChar <= 31) || (e.KeyChar >= 33 && e.KeyChar <= 39) || (e.KeyChar >= 42 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47) || (e.KeyChar >= 60 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar >= 255))
            {
                MessageBox.Show("No se permiten caracteres especiales");
                e.Handled = true;
            }
        }

        //validacion con codigos ASCII que no se permitan ingresar caracteres especiales
        private void txt_Correo_Padre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 0 && e.KeyChar <= 7) || (e.KeyChar >= 9 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 45) || (e.KeyChar == 47) || (e.KeyChar >= 58 && e.KeyChar <= 63) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar >= 255))
            {
                MessageBox.Show("No se permiten Caracteres especiales");
                e.Handled = true;
            }
        }

        private void txt_PrimerNombre_Alum_TextChanged(object sender, EventArgs e)
        {

        }

        //validacion en caso que por accidente o que si no esta seguro si desea salir del sistema
        private void Ingresar_Alumno_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "Confirmacion",MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.No){
                e.Cancel = true;
            }
            else
            {
                Menu_Admin ma = new Menu_Admin();
                ma.Show();
            }
            
      
        }

        private void cbxGenero_Alumno_SelectedIndexChanged(object sender, EventArgs e)
        {
   
        }

        private void cbxEstado_Alumno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

