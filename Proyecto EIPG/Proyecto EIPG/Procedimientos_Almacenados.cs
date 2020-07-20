using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Proyecto_EIPG
{
    class Procedimientos_Almacenados
    {
        //se declaran las variables de sql que se utilizaran
        private ConexionBD conexion = new ConexionBD();
        private SqlCommand comando = new SqlCommand();
        private SqlDataReader leerFilas;
        public int Acceso;

        //funcion de ingresar un nuevo empleado primero recive los valores a ingresar
        public void Ingresar_Empleados(String id_empleado, String primer_nombre, String segundo_nombre, String primer_apellido, String segundo_apellido, DateTime fecha_Nacimiento, String correo, String telefono, String direccion, decimal salario_empleado, String titulo, String post_grado, String experiencia_laboral,int ID_genero,int ID_estado,int ID_estadoC, int ID_rol)
        {
            comando.Connection = conexion.Abrirconexion();//abre la conexion
            comando.CommandText = "SP_Insertar_Empleados";//ingresa el nombre del procedimiento a llamar
            comando.CommandType = CommandType.StoredProcedure;//le dice que es de tipo procedimeinto
            //ingresa todos los datos a registrar
            comando.Parameters.AddWithValue("@id_empleado", id_empleado);
            comando.Parameters.AddWithValue("@primer_nombre", primer_nombre);
            comando.Parameters.AddWithValue("@segundo_nombre", segundo_nombre);
            comando.Parameters.AddWithValue("@primer_apellido", primer_apellido);
            comando.Parameters.AddWithValue("@segundo_apellido", segundo_apellido);
            comando.Parameters.AddWithValue("@fecha_Nacimiento", fecha_Nacimiento);
            comando.Parameters.AddWithValue("@correo", correo);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@salario_empleado", salario_empleado);
            comando.Parameters.AddWithValue("@titulo",titulo);
            comando.Parameters.AddWithValue("@post_grado", post_grado);
            comando.Parameters.AddWithValue("@experiencia_laboral", experiencia_laboral);
            comando.Parameters.AddWithValue("@ID_genero", ID_genero);
            comando.Parameters.AddWithValue("@ID_estado", ID_estado);
            comando.Parameters.AddWithValue("@ID_estado_civil", ID_estadoC);
            comando.Parameters.AddWithValue("@ID_rol", ID_rol);
            comando.ExecuteNonQuery();//ejecuta el query
            comando.Parameters.Clear();//limpia los parametro que se quedan en la cache
        }

        //funcion ingresar pariente primero recive todos los datos que va a ingresar
        public void Ingresar_Pariente(String id_pariente, String primer_nombre, String segundo_nombre, String primer_apellido, String segundo_apellido, DateTime fecha_nacimiento, String correo, String telefono, String direccion, int ID_genero, int Cantidad_hijos)
        {
            comando.Connection = conexion.Abrirconexion();//abre la conexion
            comando.CommandText = "SP_Ingresar_Pariente";//ingresa el nombre del procedimeinto a llamar
            comando.CommandType = CommandType.StoredProcedure;//le dice que es de tipo procedimeinto
            //ingresa todos los datos que va a registrar
            comando.Parameters.AddWithValue("@id_pariente", id_pariente);
            comando.Parameters.AddWithValue("@primer_nombre", primer_nombre);
            comando.Parameters.AddWithValue("@segundo_nombre", segundo_nombre);
            comando.Parameters.AddWithValue("@primer_apellido", primer_apellido);
            comando.Parameters.AddWithValue("@segundo_apellido", segundo_apellido);
            comando.Parameters.AddWithValue("@fecha_nacimiento", fecha_nacimiento);
            comando.Parameters.AddWithValue("@correo", correo);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@ID_genero", ID_genero);
            comando.Parameters.AddWithValue("@Cantidad_hijos", Cantidad_hijos);
            comando.ExecuteNonQuery();//ejecuta el query
            comando.Parameters.Clear();//limpia los parametros que se quedan en la cache
        }

        //funcion ingresar un nuevo alumno primero recive los datos a ingresar
        public void Ingresar_Alumno(String id_alumno, String primer_nombre, String segundo_nombre, String primer_apellido, String segundo_apellido, DateTime fecha_Nacimiento, String id_pariente, String Estado_Salud,int ID_genero,int ID_estado,int id_nivel_academico,int id_grado_cursando, decimal mensualidad)
        {
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "SP_Insertar_Alumnos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_alumno", id_alumno);
            comando.Parameters.AddWithValue("@primer_nombre", primer_nombre);
            comando.Parameters.AddWithValue("@segundo_nombre", segundo_nombre);
            comando.Parameters.AddWithValue("@primer_apellido", primer_apellido);
            comando.Parameters.AddWithValue("@segundo_apellido", segundo_apellido);
            comando.Parameters.AddWithValue("@fecha_Nacimiento", fecha_Nacimiento);
            comando.Parameters.AddWithValue("@id_pariente", id_pariente);
            comando.Parameters.AddWithValue("@Estado_Salud", Estado_Salud);
            comando.Parameters.AddWithValue("@ID_genero", ID_genero);
            comando.Parameters.AddWithValue("@ID_estado", ID_estado);
            comando.Parameters.AddWithValue("@id_nivel_academico", id_nivel_academico);
            comando.Parameters.AddWithValue("@id_grado_cursando", id_grado_cursando);
            comando.Parameters.AddWithValue("@mensualidad", mensualidad);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        //funcion para buscar un alumno
        public DataTable Buscar_Alumno(String id_alumno)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "SP_Buscar_Alumno";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filtro", id_alumno);
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            conexion.Cerrarconexion();
            return tabla;
        }

        //funcion para listar los alumnos de la institucion
        public DataTable listar_Alumno()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "SP_listar_alumno";
            comando.CommandType = CommandType.StoredProcedure;
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            conexion.Cerrarconexion();
            return tabla;
        }

        //funcion para listar alumnos morosos con la institucion
        public DataTable listar_Alumno_Morosos()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "SP_listar_alumno_morosos";
            comando.CommandType = CommandType.StoredProcedure;
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            conexion.Cerrarconexion();
            return tabla;
        }

        //funcion para buscar un empleado en especifico
        public DataTable Buscar_Empleado(String filtro)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "SP_Buscar_Empleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filtro", filtro);
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            conexion.Cerrarconexion();
            return tabla;
        }

        //funcion para listar todos los empleados de la institucion
        public DataTable listar_Empleado()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "SP_listar_Empleado";
            comando.CommandType = CommandType.StoredProcedure;
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            conexion.Cerrarconexion();
            return tabla;
        }

        //funcion para listar los generos que se cargaran en listar genero
        public DataTable listar_Genero()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "SP_listar_genero";
            comando.CommandType = CommandType.StoredProcedure;
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            conexion.Cerrarconexion();
            return tabla;
        }


        //funcion para listar estado civil en los combobox
        public DataTable listar_estado_civil()
        {
            
            DataTable tabla1 = new DataTable();
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "SP_listar_estado_civil";
            comando.CommandType = CommandType.StoredProcedure;
            leerFilas = comando.ExecuteReader();
            tabla1.Load(leerFilas);
            leerFilas.Close();
            conexion.Cerrarconexion();
            return tabla1;
        }

        //funcion para listar el esdo de los alumnos en el combobox
        public DataTable listar_estado()
        {
            DataTable tabla3 = new DataTable();
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "SP_listar_estado";
            comando.CommandType = CommandType.StoredProcedure;
            leerFilas = comando.ExecuteReader();
            tabla3.Load(leerFilas);
            leerFilas.Close();
            conexion.Cerrarconexion();
            return tabla3;
        }

     
        //funcion para listar los grados con los que cuenta la institucion
       public void listar_grado_academico(ComboBox combo)
        {
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT descripcion_nivel_academico FROM nivel_academico",conexion.Abrirconexion());
            DataSet data = new DataSet();
            sqlData.Fill(data, "nivel_academico");
            combo.DataSource = data.Tables[0].DefaultView;
            combo.ValueMember = "descripcion_nivel_academico";
        }

        //funcion para listar el grado cursando
        public DataTable listar_grado_cursando()
        {
            DataTable tabla3 = new DataTable();
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "SP_listar_grado_cursando";
            comando.CommandType = CommandType.StoredProcedure;
            leerFilas = comando.ExecuteReader();
            tabla3.Load(leerFilas);
            leerFilas.Close();
            conexion.Cerrarconexion();
            return tabla3;
        }

        //funcion para listar el nivel de acceso en el combobox
        public DataTable listar_acceso()
        {
            DataTable tabla4 = new DataTable();
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "SP_listar_acceso";
            comando.CommandType = CommandType.StoredProcedure;
            leerFilas = comando.ExecuteReader();
            tabla4.Load(leerFilas);
            leerFilas.Close();
            conexion.Cerrarconexion();
            return tabla4;
        }

        //funcion para aumentar la mensualidad recive el porcentaje y el nivel academico
        public void Aumento_Mensualidad(decimal aumento , string nivel_academico)
        {
          
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "SP_Modificar_Mensualidad";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@porcentaje",aumento);
            comando.Parameters.AddWithValue("@nivel_academico", nivel_academico);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }

        //funcion para actualizar el pariente del alumno
        public void Actualizar_Pariente(String id_pariente, String primer_nombre, String segundo_nombre, String primer_apellido, String segundo_apellido, DateTime fecha_nacimiento, String correo, String telefono, String direccion, int ID_genero)
        {
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "SP_Modificar_Pariente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filtro", id_pariente);
            comando.Parameters.AddWithValue("@primer_nombre", primer_nombre);
            comando.Parameters.AddWithValue("@segundo_nombre", segundo_nombre);
            comando.Parameters.AddWithValue("@primer_apellido", primer_apellido);
            comando.Parameters.AddWithValue("@segundo_apellido", segundo_apellido);
            comando.Parameters.AddWithValue("@fecha_nacimiento", fecha_nacimiento);
            comando.Parameters.AddWithValue("@correo", correo);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@ID_genero", ID_genero);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        //funcion para actualizar los datos del alumno
        public void Actualizar_Alumno(String id_alumno, String primer_nombre, String segundo_nombre, String primer_apellido, String segundo_apellido, DateTime fecha_Nacimiento, String id_pariente, String Estado_Salud, int ID_genero, int ID_estado)
        {
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "SP_Modificar_Alumno";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filtro", id_alumno);
            comando.Parameters.AddWithValue("@primer_nombre", primer_nombre);
            comando.Parameters.AddWithValue("@segundo_nombre", segundo_nombre);
            comando.Parameters.AddWithValue("@primer_apellido", primer_apellido);
            comando.Parameters.AddWithValue("@segundo_apellido", segundo_apellido);
            comando.Parameters.AddWithValue("@fecha_Nacimiento", fecha_Nacimiento);
            comando.Parameters.AddWithValue("@id_pariente", id_pariente);
            comando.Parameters.AddWithValue("@Estado_Salud", Estado_Salud);
            comando.Parameters.AddWithValue("@ID_genero", ID_genero);
            comando.Parameters.AddWithValue("@ID_estado", ID_estado);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        //funcion para elimnar un alumno
          public void eliminar_Alumno(String id_alumno)
        {
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "SP_Eliminar_Alumno";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filtro", id_alumno);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        //funcion para eliminar un empleado
        public void eliminar_Empleado(String id_alumno)
        {
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "SP_Eliminar_Empleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filtro", id_alumno);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        //funcion para actualizar los datos de un empleado
        public void Actualizar_Empleado(String id_empleado, String primer_nombre, String segundo_nombre, String primer_apellido, String segundo_apellido, DateTime fecha_Nacimiento, String correo, String telefono, String direccion, decimal salario_empleado, String titulo, String post_grado, String experiencia_laboral, int ID_genero, int ID_estado, int ID_estadoC, int ID_rol)
        {
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "SP_Modificar_Empleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filtro", id_empleado);
            comando.Parameters.AddWithValue("@primer_nombre", primer_nombre);
            comando.Parameters.AddWithValue("@segundo_nombre", segundo_nombre);
            comando.Parameters.AddWithValue("@primer_apellido", primer_apellido);
            comando.Parameters.AddWithValue("@segundo_apellido", segundo_apellido);
            comando.Parameters.AddWithValue("@fecha_nacimiento", fecha_Nacimiento);
            comando.Parameters.AddWithValue("@correo", correo);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@salario", salario_empleado);
            comando.Parameters.AddWithValue("@titulo", titulo);
            comando.Parameters.AddWithValue("@post_grado", post_grado);
            comando.Parameters.AddWithValue("@experiencia", experiencia_laboral);
            comando.Parameters.AddWithValue("@id_genero", ID_genero);
            comando.Parameters.AddWithValue("@id_estado", ID_estado);
            comando.Parameters.AddWithValue("@id_estado_civil", ID_estadoC);
            comando.Parameters.AddWithValue("@id_rol", ID_rol);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }


        //funcion para registrar otros ingresos de la institucion
        public void Ingresar_otros_ingresos(String descripcion_ingreso,String Id_cliente ,DateTime fecha_transaccion, double monto_ingreso,int motivo, int cuenta)
        {
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "SP_otros_ingresos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@descripcion_ingresos", descripcion_ingreso);
            comando.Parameters.AddWithValue("@id_Otros", Id_cliente);
            comando.Parameters.AddWithValue("@fecha_ingreso", fecha_transaccion);
            comando.Parameters.AddWithValue("@cant_plata_recibida", monto_ingreso);
            comando.Parameters.AddWithValue("@id_motivo_ingreso", motivo);
            comando.Parameters.AddWithValue("@id_cuenta_contable", cuenta);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }


        //funcion para cargar un datagrid de los reportes de ingresos
        public DataTable reporte_ingresos()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "SP_reporte_ingresos";
            comando.CommandType = CommandType.StoredProcedure;
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            conexion.Cerrarconexion();
            return tabla;
        }

        //funcion para cargar el valor totoal del reporte de ingresos
        public String reporte_total_ingresos()
        {
            String total=" ";
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "SP_reporte_total_ingresos";
            comando.CommandType = CommandType.StoredProcedure;
            leerFilas = comando.ExecuteReader();
            if (leerFilas.Read())
            {
                total = leerFilas["Total"].ToString();
            }
            conexion.Cerrarconexion();
            comando.Parameters.Clear();
            return total;
        }

        //funcion para llenar un datagrid con los datos de reporte de egreso
        public DataTable reporte_egresos()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "SP_reporte_egresos";
            comando.CommandType = CommandType.StoredProcedure;
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            conexion.Cerrarconexion();
            return tabla;
        }

        //funcion para calcular el reporte total de egresos
        public String reporte_total_egresos()
        {
            String total = " ";
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "SP_reporte_total_egresos";
            comando.CommandType = CommandType.StoredProcedure;
            leerFilas = comando.ExecuteReader();
            if (leerFilas.Read())
            {
                total = leerFilas["Total"].ToString();
            }
            conexion.Cerrarconexion();
            comando.Parameters.Clear();
            return total;
        }

        //funcion para veridicar la extencia de un alumno
        public int Verificar_Existencia(String filtro)
        {
            int Resultado = 0;
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "SP_Verificar_Existencia_ID_Alumno";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filtro", filtro);
            leerFilas = comando.ExecuteReader();
            if (leerFilas.Read())
            {
                Resultado = 1;
            }
            else
            {
                Resultado = 0;
            }
            leerFilas.Close();
            conexion.Cerrarconexion();
            comando.Parameters.Clear();
            
            return Resultado;

        }

        //funcion para verificar la existencia del padre
        public int Verificar_Existencia_padre(String filtro)
        {
            int Resultado = 0;
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "SP_Verificar_Existencia_Padre";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filtro", filtro);
            leerFilas = comando.ExecuteReader();
            if (leerFilas.Read())
            {
                Resultado = 1;
            }
            else
            {
                Resultado = 0;
            }
            leerFilas.Close();
            conexion.Cerrarconexion();
            comando.Parameters.Clear();

            return Resultado;

        }

        //funcion para verificar el acceso en el login
        public int login(String codigo, String password)
        {
           
            try
            {
                comando.Connection = conexion.Abrirconexion();
                comando.CommandText = "SP_Entrar_sistema";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombre", codigo);
                comando.Parameters.AddWithValue("@contrasena", password);
                //acceso tomara el valor de nivel de autoridad que tendra el usuario sobre 
                //el sistema , el resultado de la consulta almacenado en una variable 
                Acceso = (int)comando.ExecuteScalar();
                comando.Parameters.Clear();
            }
            catch (Exception)
            {

            }
                
            return Acceso;

        }
      
        //funcion que nos devuelve el valor de la mensualidad
        public String valor_mensualidad(int filtro)
        {
            String valor = " ";
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "SP_Valor_Mensualidad";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filtro", filtro);
            leerFilas = comando.ExecuteReader();
            if (leerFilas.Read())
            {
                valor = leerFilas["mensualidad_nivel_academico"].ToString();
            }
            comando.Parameters.Clear();
            return valor;
        }

        //funcion para aumentar la cantidad de hijos del pariente
        public void aumentar_hijos_pariente(String ID_Pariente)
        {
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "SP_Aumento_Hijos_Pariente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filtro", ID_Pariente);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        //funcion para disminuir la cantidad de hijos de un pariente
        public void disminuir_hijos_pariente(String ID_Pariente)
        {
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "SP_Disminuir_hijo_pariente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filtro", ID_Pariente);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        //funcion para restar el saldo del alumno
        public void Restar_Saldo(String filtro, decimal monto)
        {
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "SP_Disminuir_Saldo_Alumno";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filtro", filtro);
            comando.Parameters.AddWithValue("@monto", monto);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        //funcion para registrar un egreso en caso de ser un pago de salario
        public void Egresos(String Nombre_Cliente ,String descripcion, DateTime fecha,decimal valor, int id_motivo_egreso, int id_cuenta_contable, String id_empleado)
        {
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "SP_Egresos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre_Cliente", Nombre_Cliente);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@valor", valor);
            comando.Parameters.AddWithValue("@id_motivo_egreso", id_motivo_egreso);
            comando.Parameters.AddWithValue("@id_cuenta_contable", id_cuenta_contable);
            comando.Parameters.AddWithValue("@id_empleado", id_empleado);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
        //funcion para registrar un egreso en caso de no ser pago de un salario
        public void Egresos2(String Nombre_Cliente, String descripcion, DateTime fecha, decimal valor, int id_motivo_egreso, int id_cuenta_contable, String id_Otro_Cliente)
        {
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "SP_Egresos_2";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre_Cliente", Nombre_Cliente);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@valor", valor);
            comando.Parameters.AddWithValue("@id_motivo_egreso", id_motivo_egreso);
            comando.Parameters.AddWithValue("@id_cuenta_contable", id_cuenta_contable);
            comando.Parameters.AddWithValue("@id_cliente", id_Otro_Cliente);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        //funcion para registrar el motivo de un egreso
        public DataTable motivo_egreso()
        {
            DataTable tabla4 = new DataTable();
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "SP_Listar_Motivo_Egreso";
            comando.CommandType = CommandType.StoredProcedure;
            leerFilas = comando.ExecuteReader();
            tabla4.Load(leerFilas);
            leerFilas.Close();
            conexion.Cerrarconexion();
            return tabla4;
        }

        //funcion para llenar un datagrid con los datos de reporte de ingreso en este caso por fecha
        public DataTable reporte_ingresos_por_fecha(DateTime fecha_inicio, DateTime fecha_final)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "SP_reporte_ingresos_por_fecha";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@F_inicio", fecha_inicio);
            comando.Parameters.AddWithValue("@F_final", fecha_final);

            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();


            conexion.Cerrarconexion();
            comando.Parameters.Clear();
            return tabla;
        }

        //funcion para llenar un datagrid con los datos de reporte de ingresos en este caso no por fecha
        public DataTable reporte_ingresos_administrativo()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "SP_reporte_general_ingresos_administrativos";
            comando.CommandType = CommandType.StoredProcedure;
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            conexion.Cerrarconexion();
            return tabla;
        }

        //funcion para llenar el datagrid de reporte egresos administrativos no por fecha
        public DataTable reporte_egresos_administrativo()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "SP_reporte_general_egresos_administrativos";
            comando.CommandType = CommandType.StoredProcedure;
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            comando.Parameters.Clear();
            conexion.Cerrarconexion();
            return tabla;
        }

        //funcion para llenar el datagrid de reporte de egresos en este caso por fecha
        public DataTable reporte_egresos_por_fecha(DateTime fecha_inicio, DateTime fecha_final)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "SP_reporte_egresos_por_fecha";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@F_inicio", fecha_inicio);
            comando.Parameters.AddWithValue("@F_final", fecha_final);
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();


            conexion.Cerrarconexion();
            comando.Parameters.Clear();
            return tabla;
        }

        //funcion para calcular el total de egresos por fecha
        public String total_egresos_por_fecha(DateTime fecha_inicio, DateTime fecha_final)
        {
            String total = " ";
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "SP_total_egreso_por_fecha";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@F_inicio", fecha_inicio);
            comando.Parameters.AddWithValue("@F_final", fecha_final);
            leerFilas = comando.ExecuteReader();
            if (leerFilas.Read())
            {
                total = leerFilas["Monto"].ToString();
            }

            conexion.Cerrarconexion();
            comando.Parameters.Clear();
            return total;
        }

        //funcion para calcular el total de ingresos por fecha
        public String total_ingresos_por_fecha(DateTime fecha_inicio, DateTime fecha_final)
        {
            String total = " ";
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "SP_total_ingreso_por_fecha";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@F_inicio", fecha_inicio);
            comando.Parameters.AddWithValue("@F_final", fecha_final);
            leerFilas = comando.ExecuteReader();
            if (leerFilas.Read())
            {
                total = leerFilas["Monto"].ToString();
            }

            conexion.Cerrarconexion();
            comando.Parameters.Clear();
            return total;
        }

        //funcion para verificar la existencia del cobro de matricula en una determinada fecha
        public int consultar_fecha(DateTime fecha)
        {
            int existencia = 0;
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "SP_Verificar_Existencia_matricula";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filtro", fecha);
            // Resultado = comando.ExecuteNonQuery().ToString();
            leerFilas = comando.ExecuteReader();
            if (leerFilas.Read())
            {
                existencia = 1;
            }
            else
            {
                existencia = 0;
            }
            leerFilas.Close();
            conexion.Cerrarconexion();
            comando.Parameters.Clear();

            return existencia;
        }

        //funcion para verificar la cantidad de cuotas en el año
        public String verificar_cantidad_cuotas()
        {
            String cuota = " ";
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "SP_verificar_cantidad_cuotas";
            comando.CommandType = CommandType.StoredProcedure;
            leerFilas = comando.ExecuteReader();
            if (leerFilas.Read())
            {
                cuota = leerFilas["cuota"].ToString();
            }
            if (cuota == " ")
            {
                cuota = "0";
            }
            conexion.Cerrarconexion();
            comando.Parameters.Clear();
            return cuota;
        }
        //funcion para cargar el pago de matricula a los alumnos
        public void cargar_matricula_pago(int cantidad_cuota, DateTime fecha_matricula)
        {
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "SP_ingresar_matricula";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Cantidad_cuota", cantidad_cuota);
            comando.Parameters.AddWithValue("@fecha_pago", fecha_matricula);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        //funcion para incrementar el saldo de mensualidad a los alumnos
        public void insertar_saldo()
        {
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "SP_Incrementar_Mensualidad";
            comando.CommandType = CommandType.StoredProcedure;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        //funcion para dar descuento a los alumnos en caso que el pariente tenga varios hijos
        public void Descuento_Alumno()
        {
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "SP_Descuento_Alumno";
            comando.CommandType = CommandType.StoredProcedure;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        //funcion para insertar el aumento de la matricula
        public void insertar_costo_registro_matricula(String filtro)
        {
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "SP_Aumento_Registro_Matricula";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filtro", filtro);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        //funcion para ejecutar el cierre de años de la institucion
        public void cierre_de_anio()
        {
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "SP_cierre_anio";
            comando.CommandType = CommandType.StoredProcedure;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        //funcion para pasar los datos a la tabla de historial de cierre de año
        public void Historial_cierre_anio()
        {
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "SP_historial_cierre_anio";
            comando.CommandType = CommandType.StoredProcedure;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        //funcion para la limpieza de la tabla de alumnos en el cierre de año
        public void limpieza_alumnos()
        {
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "SP_limpieza_alumnos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        //funcion para  buscar el nombre de usuario con el que se accedio en login
        public String busqueda_nombre_usuario(String usuario, String Contrasenia)
        {
            String Nombre = " ";
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "SP_Buscar_Nombre";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@contrasenia", Contrasenia);
            leerFilas = comando.ExecuteReader();
            if (leerFilas.Read())
            {
                Nombre = leerFilas["Nombre"].ToString();
            }
            comando.Parameters.Clear();
            conexion.Cerrarconexion();
            return Nombre;
        }

        //funcion busqueda de identidad del usuario con el que se ingreso en el login
        public String busqueda_identidad_usuario(String usuario, String Contrasenia)
        {
            String Identidad = " ";
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "SP_Buscar_identidad";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@contrasenia", Contrasenia);
            leerFilas = comando.ExecuteReader();
            if (leerFilas.Read())
            {
                Identidad = leerFilas["Identidad"].ToString();
            }
            comando.Parameters.Clear();
            conexion.Cerrarconexion();
            return Identidad;
        }

        //funcion de insetar un usuario en caso que el nivel del empleado lo rquiera
        public void insertar_usuario(String usuario, String Contrasena, String id)
        {
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "SP_Insertar_Usuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@contrasena", Contrasena);
            comando.Parameters.AddWithValue("@id_empleado", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        //funcion de reporte de alumnos dependiendo del estado de estos activos o inactivos
        public DataTable Reporte_alumno_por_estado(string Filtro)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "reporte_alumno_por_estado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@estado", Filtro);
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            conexion.Cerrarconexion();
            return tabla;
        }

        //funcion de reporte de empleado por estado ya sea activo o inactivo
        public DataTable Reporte_empleado_por_estado(string Filtro)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "reporte_empleado_por_estado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@estado", Filtro);
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            conexion.Cerrarconexion();
            return tabla;
        }

        //funcion de reporte de alumno por el grado
        public DataTable Reporte_alumno_por_grado(string Filtro)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "AlumnosPorGrado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@grado", Filtro);
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            conexion.Cerrarconexion();
            return tabla;
        }

        //funcion para listar el precio de cada grado
        public DataTable listar_Precio_Grados()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "SP_Datos_Nivel_Academico";
            comando.CommandType = CommandType.StoredProcedure;
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            conexion.Cerrarconexion();
            return tabla;

        }

    }

}
