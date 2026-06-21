using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySqlConnector;

namespace prySistemaEscolar
{
    internal class clsCarreras
    {
        private string nombreCarrera;

        //usamos un adaptador
        private MySqlDataAdapter consulta;
        //Usamos una tabla temporal
        private DataTable tabla;

        //Propiedad para el atributo buscarCarrera
        public string NombreCarrera { get => nombreCarrera; set => nombreCarrera = value; }

        //Metodo para cargar datos en el DataGrid
        public DataTable CargarDataGrid()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "select idCarrera AS Clave, nombreCarrera AS Carrera,descripcion AS Descripcion from tblCarreras;";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    { 
                        consulta.Fill(tabla);
                    }//liberar la consulta de forma automatica
                }//Liberar conexión de forma automatica
            }
            catch (Exception ex)
            {
               throw new Exception("Error en la conexión"+ex.Message);
            }
            return tabla;
        }

        //Metodo para consultar por coincidencias
        public DataTable ConsultarCoincidencias()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT idCarrera AS Clave, nombreCarrera AS Carrera, descripcion AS Descripcion FROM tblcarreras WHERE nombreCarrera LIKE @carrera;";
                    using (var consultar = new MySqlCommand(sql, conexion))
                    {
                        consultar.Parameters.AddWithValue("@carrera", "%" + nombreCarrera + "%");
                        using (var consulta =new MySqlDataAdapter(consultar))
                        {
                            consulta.Fill(tabla);
                        }
                    }//liberar la consulta
                }//liberar la conexion
            }catch(Exception ex)
            {
                throw new Exception("Error en la conexión de la base de datos" + ex.Message);
            }
            return tabla;
        }
    }
}