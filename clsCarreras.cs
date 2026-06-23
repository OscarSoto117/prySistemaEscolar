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
        private string descripcionCarrera;
        //Atributo de referencia para actualizar y eliminar registros
        private int idCarrera;

        //usamos un adaptador
        private MySqlDataAdapter consulta;
        //Command para insertar o actualizar
        private MySqlCommand comando;
        //Usamos una tabla temporal
        private DataTable tabla;

        //Propiedad para el atributo buscarCarrera
        public string NombreCarrera { get => nombreCarrera; set => nombreCarrera = value; }
        public string DescripcionCarrera { get => descripcionCarrera; set => descripcionCarrera = value; }
        public int IdCarrera { get => idCarrera; set => idCarrera = value; }

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
                throw new Exception("Error en la conexión" + ex.Message);
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
                        using (var consulta = new MySqlDataAdapter(consultar))
                        {
                            consulta.Fill(tabla);
                        }
                    }//liberar la consulta
                }//liberar la conexion
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexión de la base de datos" + ex.Message);
            }
            return tabla;
        }

        //Metodo para actualizar registros
        public string GuardarActualizarRegistros(int tipoOperacion)
        {
            string msg = "";
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    switch (tipoOperacion)
                    {
                        //Registro nuevo/new
                        case 0:
                            string sqlN = "INSERT INTO tblcarreras(nombreCarrera,descripcion)VALUES(@nombreCarrera,@descripcionCarrera);";
                            using (comando = new MySqlCommand(sqlN, conexion))
                            {
                                comando.Parameters.AddWithValue("nombreCarrera", nombreCarrera);
                                comando.Parameters.AddWithValue("descripcionCarrera", descripcionCarrera);
                                int filasAfectadas = comando.ExecuteNonQuery();
                                if (filasAfectadas > 0)
                                {
                                    msg = "Registro guardado correctamente";
                                }
                                else
                                {
                                    msg = "Error, Datos no guardados";
                                }

                            }//Libera la operacion de incersion
                            break;
                        //Registro viejo/old
                        case 1:
                            string sqlA = "UPDATE tblcarreras C SET C.nombreCarrera = @nombreCarrera, C.descripcion = @descripcionCarrera WHERE C.idCarrera = idCarrera;";
                            using (comando = new MySqlCommand(sqlA, conexion))
                            {
                                comando.Parameters.AddWithValue("idCarrera", idCarrera);
                                comando.Parameters.AddWithValue("nombreCarrera", nombreCarrera);
                                comando.Parameters.AddWithValue("descripcionCarrera", descripcionCarrera);
                                int filasAfectadas = comando.ExecuteNonQuery();
                                if (filasAfectadas > 0)
                                {
                                    msg = "Registro actualizado correctamente";
                                }
                                else
                                {
                                    msg = "Error, Datos no actualizados";
                                }
                            }//Libera la operacion de actualizacion
                            break;
                    }
                }//Se libera la conexion
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            return msg;
        }
    }
}