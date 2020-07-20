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
    public partial class Ingresar_Empleado : Form
    {
        public Ingresar_Empleado()
        {
            InitializeComponent();
            
        }

        //variables globales para su uso en la validacion cuando se registran alumnos o se carga el formulario
        public String cmbGenero_Emple, cmbEstado_Empleado, cmb_estado_civil, cmb_nivel_acceso, usuario;
        public int seleccion1=0;
        private void pnlIngreso_Emple_Paint(object sender, PaintEventArgs e)
        {
            
        }

        //mensaje en caso de que exista un campo vacio
        public void campos_vacios()
        {
            MessageBox.Show("no puede dejar campos vacios");
        }


        //boton guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //validacion del correo en caso que no tenga lo deja en blanco
            if (validar_email(Txt_Correo_Emple.Text))
            {
            }
            else
            {
                Txt_Correo_Emple.Text = "";
            }
            //validacion que en caso que el empleado tenga usuario y contraseña no esten vacios
            if (Cmb_Nivel_Acceso_Emple.SelectedIndex != 4 && (Txt_Usuario_Emple.Text.Equals("") || Txt_Contraseña_Emple.Text.Equals("")))
            {
                MessageBox.Show("usuario o contraseña estan vacios");
            }

            //validar que los combobox esten seleccionados
            if (Cmb_Estado_Civil_.SelectedIndex == 0 || Cmb_Genero_Emple.SelectedIndex == 0 || Cmb_Nivel_Acceso_Emple.SelectedIndex==0 || Txb_Primer_Nombre_Emple.Text.Equals("") || Txt_Primer_Apellido_Emple.Text.Equals("") || Txt_Edad_Emple.Text.Equals("") || Txt_Direccion_Emple.Text.Equals("") || Txt_Titulo_Emple.Text.Equals("") || Txt_Salario_Emple.Text.Equals(""))
            {
                campos_vacios();
            }
            else
            {
                //en caso que si esten seleccionados se procede a ingresar el empleado a la base de datos
                try
                {
                    Procedimientos_Almacenados proc = new Procedimientos_Almacenados();//instancia con la clase procedimientos almacenados
                    proc.Ingresar_Empleados(Mask_No_Identidad_Emple.Text, Txb_Primer_Nombre_Emple.Text, Txt_Segundo_Nombre_Emple.Text, Txt_Primer_Apellido_Emple.Text, Txt_Segundo_Apellido_Emple.Text, Dtp_FechaNacimiento_Emple.Value, Txt_Correo_Emple.Text, Mask_NumeroFijo_Emp.Text, Txt_Direccion_Emple.Text, decimal.Parse(Txt_Salario_Emple.Text), Txt_Titulo_Emple.Text, Txt_Post_Grado_Emple.Text, Txt_Experiencia_Emple.Text, Cmb_Genero_Emple.SelectedIndex, 1, Cmb_Estado_Civil_.SelectedIndex, Cmb_Nivel_Acceso_Emple.SelectedIndex);//primero ingresamos el empleado
                    proc.insertar_usuario(Txt_Usuario_Emple.Text, Txt_Contraseña_Emple.Text, Mask_No_Identidad_Emple.Text);//una vez ingresado el empleado se procede a registrar su usuario
                    //una vez ingresado los datos se limpian todos los campos ingresados
                    Mask_No_Identidad_Emple.Clear(); Txb_Primer_Nombre_Emple.Clear(); Txt_Segundo_Nombre_Emple.Clear(); Txt_Primer_Apellido_Emple.Clear(); Txt_Segundo_Apellido_Emple.Clear(); Txt_Correo_Emple.Clear(); Mask_NumeroFijo_Emp.Clear(); ; Txt_Direccion_Emple.Clear(); Txt_Salario_Emple.Clear(); Txt_Titulo_Emple.Clear(); Txt_Post_Grado_Emple.Clear(); Txt_Experiencia_Emple.Clear(); Txt_Usuario_Emple.Clear(); Txt_Contraseña_Emple.Clear();
                    MessageBox.Show("guardado con exito");//mostrar mensje guardado con exito
                }
                catch (Exception ex)
                {
                    //en caso que este algun dato vacio sql no lo podra registrar entonces muestra el mensaje de que alguna dato esta vacio
                    System.Windows.Forms.MessageBox.Show("los datos no pueden estar vacios" + ex.ToString());
                }


            }

            
        }

        private void tbxNo_Identidad_Emple_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tbxNo_Identidad_Emple_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxNo_Identidad_Emple_Validated(object sender, EventArgs e)
        {
        
        }

        private void lblNo_Movil_Emple_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //el boton cancelar cierra este formulario y muestra el menu administrativo
            Menu_Admin ma = new Menu_Admin();
            ma.Show();
            this.Close();
        }

        private void rbtnSI_CheckedChanged(object sender, EventArgs e)
        {
            //si el radio buttom cambia a el valor de SI se habilita el texbox
            if (Rbtn_SI.Checked)
            {
                Txt_Post_Grado_Emple.Enabled = true;
            }
            
        }

        private void rbtnNO_CheckedChanged(object sender, EventArgs e)
        {
            //si el radio buttom cambia a el valor de NO se deshabilita el texbox
            if (Rbtn_NO.Checked)
            {
                Txt_Post_Grado_Emple.Enabled = false;
                Txt_Post_Grado_Emple.Text = " ";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        //validacion de la identidad del empleado
        private void Mask_No_Identidad_Emple_Validated(object sender, EventArgs e)
        {
            if (Mask_No_Identidad_Emple.Text.Length < 15)
            {
                error.SetError(Mask_No_Identidad_Emple, "Introduzca la Identidad correctamente");
                Mask_No_Identidad_Emple.Focus();

            }
            else
            {
                error.Clear();
            }
        }

        private void lblEIPG_Click(object sender, EventArgs e)
        {

        }

        //validacion del nombre del empleado el cual minimo debe tener 3 caracteres
        private void txbPrimerNombre_Emple_Validated(object sender, EventArgs e)
        {
            bool ok = true;
            if (Txb_Primer_Nombre_Emple.Text.Trim().Equals(""))
            {
                error.SetError(Txb_Primer_Nombre_Emple, "Introduzca primer nombre");
                Txb_Primer_Nombre_Emple.Focus();
            }
            else
            {
                error.Clear();
            }

            if (Txb_Primer_Nombre_Emple.Text.Length < 3)
            {

                ok = false;
                error.SetError(Txb_Primer_Nombre_Emple, "Ingrese Nombre valido");
                Txb_Primer_Nombre_Emple.Focus();
            }
            else
            {
                error.Clear();
            }

        }

        //validacion del apellido del empleado el cual minimo debe tener 3 caracteres
        private void txbPrimerApellido_Emple_Validated(object sender, EventArgs e)
        {
            bool ok = true;
            if (Txt_Primer_Apellido_Emple.Text.Trim().Equals(""))//validacion ya estaba es la que dice si esta vacio el el textbox
            {
                error.SetError(Txt_Primer_Apellido_Emple, "Introduzca primer apellido");//Si realente el campo no es requerido como el segundo nombre entonces ponemos "ERROR.CLEAR + la condicion de valor minimo"
                Txt_Primer_Apellido_Emple.Focus();
            }
            else
            {
                error.Clear();
            }
            /*Esta condicion valida el valor minimo para poder ingresar en un textbox

            

             */
            if (Txt_Primer_Apellido_Emple.Text.Length < 2)//compara si el tamaño de la cadena es menor a 2
            {

                ok = false;
                error.SetError(Txt_Primer_Apellido_Emple, "Ingrese Apellido valido");//enfoca el error provider
                Txt_Primer_Apellido_Emple.Focus();
            }
            else
            {
                error.Clear();//si no es menor que 2 entoces limpia el error provider
            }
        }

        //validacion con codigo ASCII que solo permite ingresar letras
        private void tbxSegundoNombre_Emple_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 0 && e.KeyChar <= 7) || (e.KeyChar >= 9 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar >= 255))
            {
                MessageBox.Show("Ingrese solo Letras");
                e.Handled = true;
            }
        }

        //validacion con codigo ASCII que solo permite ingresar letras
        private void TbxSegundoApellido_Emple_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 0 && e.KeyChar <= 7) || (e.KeyChar >= 9 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar >= 255))
            {
                MessageBox.Show("Ingrese solo Letras");
                e.Handled = true;
            }
        }

        //validacion con codigo ASCII que solo permite ingresar letras
        private void txbPrimerNombre_Emple_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 0 && e.KeyChar <= 7) || (e.KeyChar >= 9 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar >= 255))
            {
                MessageBox.Show("Ingrese solo Letras");
                e.Handled = true;
            }
        }

        //validacion con codigo ASCII que solo permite ingresar letras
        private void txbPrimerApellido_Emple_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 0 && e.KeyChar <= 7) || (e.KeyChar >= 9 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar >= 255))
            {
                MessageBox.Show("Ingrese solo Letras");
                e.Handled = true;
            }
        }

        private void tbxEdad_Emple_TextChanged(object sender, EventArgs e)
        {

        }

        //validacion que nos sirve para que cada vez que se cambie la fechaen el campo edad se establezca la edad calculada
        private void dtpFechaNacimiento_Emple_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha = Dtp_FechaNacimiento_Emple.Value;

            int edad = DateTime.Now.Year - fecha.Year;

            Txt_Edad_Emple.Text = edad.ToString();
        }

        private void Mask_NumeroFijo_Padre_Validated(object sender, EventArgs e)
        {}

        private void Mask_NumeroFijo_Emp_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        { }

        //validacion que el titulo ingresado sea correcto con un minimo de 10 caracteres
        private void tbxTitulo_Emple_Validated(object sender, EventArgs e)
        {
            bool ok = true;
            if (Txt_Titulo_Emple.Text.Trim().Equals(""))
            {
                error.SetError(Txt_Titulo_Emple, "Introduzca el Titulo");
                Txt_Titulo_Emple.Focus();
            }
            else
            {
                error.Clear();
            }
            if (Txt_Titulo_Emple.Text.Trim().Length < 10)
            {

                ok = false;
                error.SetError(Txt_Titulo_Emple, "Ingrese Titulo valido");
                Txt_Titulo_Emple.Focus();
            }
            else
            {
                error.Clear();
            }
        }

        //validacion del postgrado del empleado donde minimo debe tener 10 caracteres
        private void tbxPost_Grado_Emple_Validated(object sender, EventArgs e)
        {
            bool ok = true;
            if (Txt_Post_Grado_Emple.Text.Trim().Equals(""))
            {
                error.Clear();
            }
            else
            {



                if (Txt_Post_Grado_Emple.Text.Trim().Length < 10)
                {

                    ok = false;
                    error.SetError(Txt_Post_Grado_Emple, "Ingrese Apellido valido");
                    Txt_Post_Grado_Emple.Focus();
                }
                else
                {
                    error.Clear();
                }
            }
        }

        //validacion de la experiencia del empleado donde minimos debe ingresar 10 caracteres
        private void tbxExperiencia_Emple_Validated(object sender, EventArgs e)
        {
            bool ok = true;
            if (Txt_Experiencia_Emple.Text.Trim().Equals(""))
            {
                error.SetError(Txt_Experiencia_Emple, "Introduzca su Experiencia");
                Txt_Experiencia_Emple.Focus();
            }
            else
            {
                error.Clear();
            }

            if (Txt_Experiencia_Emple.Text.Trim().Length < 10)
            {

                ok = false;
                error.SetError(Txt_Experiencia_Emple, "Ingrese Experiencia valida");
                Txt_Experiencia_Emple.Focus();
            }
            else
            {
                error.Clear();
            }
        }

        //validacion del salario donde minimo deben de ingresarse 3 numeros
        private void tbx_Salario_Emple_Validated(object sender, EventArgs e)
        {
            bool ok = true;
            if (Txt_Salario_Emple.Text.Trim().Equals(""))
            {
                error.SetError(Txt_Salario_Emple, "Introduzca su Salario");
                Txt_Salario_Emple.Focus();
            }
            else
            {
                error.Clear();
            }

            if (Txt_Salario_Emple.Text.Trim().Length < 3)
            {

                ok = false;
                error.SetError(Txt_Salario_Emple, "Ingrese Salario valida");
                Txt_Salario_Emple.Focus();
            }
            else
            {
                error.Clear();
            }
        }

        //validacion del usuario del empleado donde minimo debe ser de 8 caracteres 
        private void tbxUsuario_Emple_Validated(object sender, EventArgs e)
        {
            bool ok = true;
            if (Txt_Usuario_Emple.Text.Trim().Equals(""))
            {
                error.SetError(Txt_Usuario_Emple, "Introduzca Usuario");
                Txt_Usuario_Emple.Focus();
            }
            else
            {
                error.Clear();
            }

            if (Txt_Usuario_Emple.Text.Trim().Length < 8)
            {

                ok = false;
                error.SetError(Txt_Usuario_Emple, "Ingrese Usuario valida");
                Txt_Usuario_Emple.Focus();
            }
            else
            {
                error.Clear();
            }

        }

        //validacion de contraseña donde minimo deben ser 8 caracteres
        private void tbxContraseña_Emple_Validated(object sender, EventArgs e)
        {
            bool ok = true;
            if (Txt_Contraseña_Emple.Text.Trim().Equals(""))
            {
                error.SetError(Txt_Contraseña_Emple, "Introduzca Contraseña");
                Txt_Contraseña_Emple.Focus();
            }
            else
            {
                error.Clear();
            }


            if (Txt_Contraseña_Emple.Text.Trim().Length < 8)
            {

                ok = false;
                error.SetError(Txt_Contraseña_Emple, "Ingrese Contraseña valida");
                Txt_Contraseña_Emple.Focus();
            }
            else
            {
                error.Clear();
            }
        }

        //validacion con codigos ASCII donde solo deben ingresarse letras
        private void tbxTitulo_Emple_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 0 && e.KeyChar <= 7) || (e.KeyChar >= 9 && e.KeyChar <= 31) || (e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar >= 255))
            {
                MessageBox.Show("Ingrese solo Letras");
                e.Handled = true;
            }
        }

        //validacion con codigos ASCII donde solo deben ingresarse letras
        private void tbxPost_Grado_Emple_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 0 && e.KeyChar <= 7) || (e.KeyChar >= 9 && e.KeyChar <= 31) || (e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar >= 255))
            {
                MessageBox.Show("Ingrese solo Letras");
                e.Handled = true;
            }
        }

        //validacion con codigos ASCII donde solo deben ingresarse letras
        private void tbxExperiencia_Emple_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 0 && e.KeyChar <= 7) || (e.KeyChar >= 9 && e.KeyChar <= 31) || (e.KeyChar >= 35 && e.KeyChar <= 39) || (e.KeyChar >= 42 && e.KeyChar <= 43) || (e.KeyChar ==45) || (e.KeyChar == 47) || (e.KeyChar >= 60 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar >= 255))
            {
                MessageBox.Show("Ingrese solo Letras");
                e.Handled = true;
            }
        }

        //validacion con codigos ASCII donde solo deben ingresarse numeros
        private void tbx_Salario_Emple_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 0 && e.KeyChar <= 7) || (e.KeyChar >= 9 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo Numeros");
                e.Handled = true;
            }
        }

        private void tbxCorreo_Emple_Validated(object sender, EventArgs e)
        {
          
        }

        //validacion de la direccion del empleado donde minimo deben ser 12 caracteres
        private void tbxDireccion_Emple_Validated(object sender, EventArgs e)
        {
            bool ok = true;
            if (Txt_Direccion_Emple.Text.Trim().Equals(""))
            {
                error.SetError(Txt_Direccion_Emple, "Introduzca Direccion");
                Txt_Direccion_Emple.Focus();
            }
            else
            {
                error.Clear();
            }


            if (Txt_Direccion_Emple.Text.Trim().Length < 12)
            {

                ok = false;
                error.SetError(Txt_Direccion_Emple, "Brinde mas Informacion");
                Txt_Direccion_Emple.Focus();
            }
            else
            {
                error.Clear();
            }
        }

        //validacion de numero fijo correcto donde minimo deben ser 11 caracteres ya que es una mask texbox
        private void Mask_NumeroFijo_Emp_Validated(object sender, EventArgs e)
        {
            if (Mask_NumeroFijo_Emp.Text.Length < 11)
            {
                error.SetError(Mask_NumeroFijo_Emp, "Introduzca el numero correctamente");
                Mask_NumeroFijo_Emp.Focus();

            }
            else
            {
                error.Clear();
            }

        }

        private void tbxCorreo_Emple_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        //validacion de los caracteres que se podran ingresar en un correo
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

        //validacion del correo electronico
        private void tbxCorreo_Emple_Leave(object sender, EventArgs e)
        {
            if (validar_email(Txt_Correo_Emple.Text))
            {
            }
            else
            {
                if (Txt_Correo_Emple.Text.Trim().Equals(""))
                {
                    error.Clear();
                }
                else
                {
                    error.SetError(Txt_Correo_Emple, "Introduzca correo correctamente");
                    Txt_Correo_Emple.Focus();

                    MessageBox.Show("Direccion de correo electronico no valido, el correo debe tener el formato: ejemplo@dominio.com," +
                    "Por favor use un direccion de correo electronico valida", "Validacion de Correo Electronico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
        }

        private void cb_estado_civil_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        //evento load del formulario cargar empleado
        private void Ingresar_Empleado_Load(object sender, EventArgs e)
        {
            //se cargan los labels con los datos que se tienen en la clase de cache
            Lbl_Nombre_admin.Text = cache_usuario.Usuario;
            Lbl_Identidad_Admin.Text = cache_usuario.Id;
            Txt_Contraseña_Emple.Text = reportes.Contrasena;
            Txt_Usuario_Emple.Text = reportes.Usuario;
            //seleccio1 si es == 0 es porque se va a ingresar un nuevo empleado
            if (seleccion1 == 0)
            {
                Procedimientos_Almacenados cbx_genero = new Procedimientos_Almacenados();//se hace una instancia con la clase de procedimientos almacenados
               //se cargan todos los combobox con los valores que nos devolvera su respectivo procedimiento
                //cbx genero
                Cmb_Genero_Emple.DataSource = cbx_genero.listar_Genero(); //manda a llamar el procedimeinto que contiene los datos
                Cmb_Genero_Emple.DisplayMember = "Nombre"; //los items seran iguales a nombre
                Cmb_Genero_Emple.ValueMember = "ID_Genero";//los indice de los combobox seran igal a los id
                //cbx estado civil
                Cmb_Estado_Civil_.DataSource = cbx_genero.listar_estado_civil();//manda a llamar el procedimeinto que contiene los datos
                Cmb_Estado_Civil_.DisplayMember = "Description";//los items seran iguales a description
                Cmb_Estado_Civil_.ValueMember = "ID_estado_civil";//los indice de los combobox seran igal a los id de estado civil 

                //cbx estado
                Cmb_Estado_Empleado_.DataSource = cbx_genero.listar_estado();//manda a llamar el procedimeinto que contiene los datos
                Cmb_Estado_Empleado_.DisplayMember = "Descripcion";//los items seran iguales a description
                Cmb_Estado_Empleado_.ValueMember = "ID_estado";//los indice de los combobox seran igal a los id estado

                //cbx nivel de acceso
                Cmb_Nivel_Acceso_Emple.DataSource = cbx_genero.listar_acceso();//manda a llamar el procedimeinto que contiene los datos
                Cmb_Nivel_Acceso_Emple.DisplayMember = "Descripcion";//los items seran iguales a nombre descripcion
                Cmb_Nivel_Acceso_Emple.ValueMember = "Id_rol";//los indice de los combobox seran igal a los id rol
            }
            else
            {
                //en caso que no se desea ingresar uno nuevo sino modificarlo 
                Procedimientos_Almacenados cbx_genero = new Procedimientos_Almacenados(); //se hace la instancia con la clase procedimientos almacenados
                Cmb_Genero_Emple.DataSource = cbx_genero.listar_Genero();//manda a llamar el procedimeinto que contiene los datos
                Cmb_Genero_Emple.DisplayMember = "Nombre";//los items seran iguales a nombre
                Cmb_Genero_Emple.ValueMember = "ID_Genero";//los indice de los combobox seran igal a los id genero
                //dependiendo del dato ingresado el combobox tomara ese valor
                if (cmbGenero_Emple.Equals("Masculino"))
                {
                    Cmb_Genero_Emple.SelectedIndex = 1;
                }
                else
                {
                    Cmb_Genero_Emple.SelectedIndex = 2;
                }

                //cbx estado civil
                Cmb_Estado_Civil_.DataSource = cbx_genero.listar_estado_civil();//instancia con la clase procedimeintos almacenados
                Cmb_Estado_Civil_.DisplayMember = "Description";//los nombres de los items sera los de la columna descriotion
                Cmb_Estado_Civil_.ValueMember = "ID_estado_civil";//los valores de los indices de los combobox seran los de la columna id estado civil
                //dependiendo del dato almacenado el combobox tomara ese valor
                if (cmb_estado_civil.Equals("Casado"))
                {
                    Cmb_Estado_Civil_.SelectedIndex = 1;
                }
                if (cmb_estado_civil.Equals("Divorciado"))
                {
                    Cmb_Estado_Civil_.SelectedIndex = 2;
                }
                if (cmb_estado_civil.Equals("Viudo"))
                {
                    Cmb_Estado_Civil_.SelectedIndex = 3;
                }
                else
                {
                    Cmb_Estado_Civil_.SelectedIndex = 4;
                }

                //cbx estado
                Cmb_Estado_Empleado_.DataSource = cbx_genero.listar_estado();//instancia con la clase de procedimientos almacenados
                Cmb_Estado_Empleado_.DisplayMember = "Descripcion"; //los items tomaran el valor de la columna description
                Cmb_Estado_Empleado_.ValueMember = "ID_estado"; //los indice de los combobox tomaran el valor de acuerdo a la columna id estado

                if (cmbEstado_Empleado.Equals("Activo"))
                {
                    Cmb_Estado_Empleado_.SelectedIndex = 1;
                }
                else
                {
                    Cmb_Estado_Empleado_.SelectedIndex = 2;
                }

                //cbx nivel de acceso
                Cmb_Nivel_Acceso_Emple.DataSource = cbx_genero.listar_acceso();//instancia con la clase de procedimiento almacenado
                Cmb_Nivel_Acceso_Emple.DisplayMember = "Descripcion"; //los items tomaran el valor de la columna description
                Cmb_Nivel_Acceso_Emple.ValueMember = "Id_rol";//los item se acoplaran de acuerdo al id rol en cada indice

                if (cmb_nivel_acceso.Equals("Director"))
                {
                    Cmb_Nivel_Acceso_Emple.SelectedIndex = 1;
                }

                if (cmb_nivel_acceso.Equals("Administrativo"))
                {
                    Cmb_Nivel_Acceso_Emple.SelectedIndex = 2;
                }

                if (cmb_nivel_acceso.Equals("Contable"))
                {
                    Cmb_Nivel_Acceso_Emple.SelectedIndex = 3;
                }

                if (cmb_nivel_acceso.Equals("Maestro"))
                {
                    Cmb_Nivel_Acceso_Emple.SelectedIndex = 4;
                }
            }
          

            Rbtn_SI.Checked = true ;
        }

        //validacion en caso que por erro presione el boton de cerrar formulario
        private void Ingresar_Empleado_FormClosing(object sender, FormClosingEventArgs e)
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

        private void cbxEstado_Empleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
              //instancia con la clase de procedimientos almacenados 
                Procedimientos_Almacenados proc = new Procedimientos_Almacenados();
                proc.Actualizar_Empleado(Mask_No_Identidad_Emple.Text, Txb_Primer_Nombre_Emple.Text, Txt_Segundo_Nombre_Emple.Text, Txt_Primer_Apellido_Emple.Text, Txt_Segundo_Apellido_Emple.Text, Dtp_FechaNacimiento_Emple.Value, Txt_Correo_Emple.Text, Mask_NumeroFijo_Emp.Text, Txt_Direccion_Emple.Text, decimal.Parse(Txt_Salario_Emple.Text), Txt_Titulo_Emple.Text, Txt_Post_Grado_Emple.Text, Txt_Experiencia_Emple.Text, Cmb_Genero_Emple.SelectedIndex, Cmb_Estado_Empleado_.SelectedIndex , Cmb_Estado_Civil_.SelectedIndex, Cmb_Nivel_Acceso_Emple.SelectedIndex);//se manda a actualizar el empleado
                proc.insertar_usuario(Txt_Usuario_Emple.Text, Txt_Contraseña_Emple.Text, Mask_No_Identidad_Emple.Text);//se ingresa el usuario
                //una vez ingresado el usuario se limpian los campos ingresados
                Mask_No_Identidad_Emple.Clear(); Txb_Primer_Nombre_Emple.Clear(); Txt_Segundo_Nombre_Emple.Clear(); Txt_Primer_Apellido_Emple.Clear(); Txt_Segundo_Apellido_Emple.Clear(); Txt_Correo_Emple.Clear(); Mask_NumeroFijo_Emp.Clear(); ; Txt_Direccion_Emple.Clear(); Txt_Salario_Emple.Clear(); Txt_Titulo_Emple.Clear(); Txt_Post_Grado_Emple.Clear(); Txt_Experiencia_Emple.Clear();
                MessageBox.Show("guardado con exito");//se muestra el mensaje que el registro se ingreso
            }
            catch (Exception )
            {
                //en caso que algun dato este vacio entonces se mmuestra el mensaje ya que sql no lo puede guardar
                System.Windows.Forms.MessageBox.Show("los datos no pueden estar vacios");
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
       
        }

        //validacion de acuerdo al nivel de acceso si es un empleado que requiere usuario y contraseña se habilitan si no se deshabilitan
        private void cbxNivel_Acceso_Emple_Click(object sender, EventArgs e)
        {
            if (Cmb_Nivel_Acceso_Emple.SelectedIndex == 1 || Cmb_Nivel_Acceso_Emple.SelectedIndex == 2 || Cmb_Nivel_Acceso_Emple.SelectedIndex == 3)
            {
                Txt_Contraseña_Emple.Enabled = true;
                Txt_Contraseña_Emple.Text = "";
                Txt_Usuario_Emple.Enabled = true;
                Txt_Usuario_Emple.Text = "";
            }
            else
            {
                Txt_Contraseña_Emple.Enabled = false;
                Txt_Contraseña_Emple.Text = "";
                Txt_Usuario_Emple.Enabled = false;
                Txt_Usuario_Emple.Text = "";
            }
        }

        private void cbxNivel_Acceso_Emple_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //validacion para que no permita espacios en blanco
        private void tbxUsuario_Emple_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar);
        }

        //validacion para que no permita espacios en blanco
        private void tbxContraseña_Emple_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar);
        }
        //validacion que no permite ingresar un nombre en blanco o con menos de 3 caracteres
        private void tbxSegundoNombre_Emple_TextChanged(object sender, EventArgs e)
        {
            bool ok = true;
            if (Txt_Segundo_Nombre_Emple.Text.Trim().Equals(""))
            {
                error.Clear();
            }
            else
            {
                if (Txt_Segundo_Nombre_Emple.Text.Trim().Length < 3)
                {

                    ok = false;
                    error.SetError(Txt_Segundo_Nombre_Emple, "Ingrese Nombre valido");
                    Txt_Segundo_Nombre_Emple.Focus();
                }
                else
                {
                    error.Clear();
                }
            }

        }

        private void txbPrimerApellido_Emple_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbxSegundoApellido_Emple_TextChanged(object sender, EventArgs e)
        {
       

        }

        private void tbxDireccion_Emple_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxUsuario_Emple_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxContraseña_Emple_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_Salario_Emple_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbPrimerNombre_Emple_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxExperiencia_Emple_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxPost_Grado_Emple_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxTitulo_Emple_TextChanged(object sender, EventArgs e)
        {

        }

        private void Mask_No_Identidad_Emple_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Mask_NumeroFijo_Emp_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        //validacion que no permite ingresar un nombre en blanco o con menos de 3 caracteres
        private void TbxSegundoNombre_Emple_Validated(object sender, EventArgs e)
        {
            bool ok = true;
            if (Txt_Segundo_Nombre_Emple.Text.Trim().Equals(""))
            {
                error.Clear();
            }
            else
            {
                if (Txt_Segundo_Nombre_Emple.Text.Trim().Length < 3)
                {

                    ok = false;
                    error.SetError(Txt_Segundo_Nombre_Emple, "Ingrese Nombre valido");
                    Txt_Segundo_Nombre_Emple.Focus();
                }
                else
                {
                    error.Clear();
                }
            }
        }

        //validacion que no permite ingresar un apellido en blanco o con menos de 2 caracteres
        private void TbxSegundoApellido_Emple_Validated(object sender, EventArgs e)
        {
            bool ok = true;
            if (Txt_Segundo_Apellido_Emple.Text.Trim().Equals(""))
            {
                error.Clear();
            }
            else
            {



                if (Txt_Segundo_Apellido_Emple.Text.Trim().Length < 2)
                {

                    ok = false;
                    error.SetError(Txt_Segundo_Apellido_Emple, "Ingrese Apellido valido");
                    Txt_Segundo_Apellido_Emple.Focus();
                }
                else
                {
                    error.Clear();
                }
            }
        }
        //validacion de tecla espacio para la identidad 
        private void Mask_No_Identidad_Emple_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void TbxCorreo_Emple_TextAlignChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_Nombre_admin_Click(object sender, EventArgs e)
        {

        }

        private void gboxPost_Grado_Enter(object sender, EventArgs e)
        {

        }

        //con el boton regresar lo que hace es que cierra este formulario 
        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //validacion de codigos ASCII que no permite ingresar caracteres especiales
        private void tbxDireccion_Emple_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 0 && e.KeyChar <= 7) || (e.KeyChar >= 9 && e.KeyChar <= 31) || (e.KeyChar >= 33 && e.KeyChar <= 39) || (e.KeyChar >= 42 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47) || (e.KeyChar >= 60 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar >= 255))
            {
                MessageBox.Show("No se permiten caracteres especiales");
                e.Handled = true;
            }
        }

        private void tbxCorreo_Emple_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
