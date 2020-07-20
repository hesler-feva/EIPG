using System;
using System.Collections.Generic;
using System.Text;

namespace Datos_usuarios.cache
{
    public static class reportes
    {
        private static int reporte_alumno;
        private static int reporte_empleado;
        private static int bandera;
        private static string usuario;
        private static string contrasena;

        public static int Reporte_alumno { get => reporte_alumno; set => reporte_alumno = value; }
        public static int Reporte_empleado { get => reporte_empleado; set => reporte_empleado = value; }
        public static int Bandera { get => bandera; set => bandera = value; }
        public static string Usuario { get => usuario; set => usuario = value; }
        public static string Contrasena { get => contrasena; set => contrasena = value; }
    }
}
