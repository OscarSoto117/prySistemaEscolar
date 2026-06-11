using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySqlConnector;
using System.Runtime.InteropServices.Marshalling;

namespace prySistemaEscolar
{
    internal class clsConexion
    {
        private string host = "189.240.192.140";
        private string db = "bdescuela3b";
        private string usuario = "terceroB";
        private string password = "tercero@B";
        private string puerto = "3306";

        private string cadenaConexion => $"server={host};database={db};user={usuario};password={password};port={puerto}";
        public MySqlConnection AbrirConexion()
        {
            var conexion = new MySqlConnection(cadenaConexion);
            try
            {
                conexion.Open();
                return conexion;
            } catch (Exception ex)
            {
                throw new Exception("Error al intentar Cconectarse a la Base de datos" + ex.Message, ex);
            }
        }
        public void CerrarConexion(MySqlConnection conexion)
        {
            try
            {
                if (conexion != null && conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                    conexion.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cerrar la conexión con la base de datos: " + ex.Message, ex);
            }
        }
    }
}
