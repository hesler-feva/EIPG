using System;
using System.Collections.Generic;
using System.Text;

namespace Datos_usuarios.cache
{
    public static class cache_usuario
    {
        private static string usuario = "";
        private static string id = "";

        public static string Usuario { get => usuario; set => usuario = value; }
        public static string Id { get => id; set => id = value; }
    }
}
