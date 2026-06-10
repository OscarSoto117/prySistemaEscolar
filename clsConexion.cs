using System;
using System.Collections.Generic;
using System.Text;

namespace prySistemaEscolar
{
    internal class clsConexion
    {
        private string host = "189.240.192.140";
        private string db = "bdescuela3b";
        private string usuario = "terceroB";
        private string password = "tercero@B";
        private string puerto = "3306";

        private string cadenaConexion => $"server={host};database={db};user{usuario};password{password};port{puerto}";
    }
}
