using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Proyecto_EIPG
{
    class ConexionBD
    {

        //instancia al servidor de la base de datos
        static private string conexionstring = "server = (local); database = final; integrated security = true";
        //data source = 10.1.3.223; initial catalog = final; user id = EIPG2019; password = EIPG2019;
        private SqlConnection cn = new SqlConnection(conexionstring);

        //en caso que la conexion con la base de datos este cerrada esta funcion nos sirve para abrirla
        public SqlConnection Abrirconexion() {

            if (cn.State == ConnectionState.Closed)
                cn.Open();
            return cn;
        }
        //si la conexion esta abierta esta funcion nos sirve para cerrarla
        public SqlConnection Cerrarconexion()
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();
            return cn;
        }
        
    }
}
