using System;
using System.Data;
using MySqlConnector;

namespace prySistemaEscolar
{
    internal class clsTutores
    {
        private string nombreTutor;
        private string parentesco;
        private string direccion;
        private string telefono;
        private string correo;
        //Atributo de referencia para actualizar y eliminar registros
        private int idTutor;

        //usamos un adaptador
        private MySqlDataAdapter consulta;
        //Command para insertar o actualizar
        private MySqlCommand comando;
        //Usamos una tabla temporal
        private DataTable tabla;
        //Propiedad para el atributo buscarTutores
        public string NombreTutor { get => nombreTutor; set => nombreTutor = value; }
        public string Parentesco { get => parentesco; set => parentesco = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public int IdTutor { get => idTutor; set => idTutor = value; }

        //Metodo para cargar datos en el DataGrid
        public DataTable CargarDataGrid()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT idTutor AS Clave, nombreTutor AS Nombre, parentesco AS Parentesco, direccion AS Dirección, telefono AS Teléfono, correo AS Correo FROM tbltutores;";
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
                    string sql = "SELECT idTutor AS Clave, nombreTutor AS Nombre, parentesco AS Parentesco, direccion AS Dirección, telefono AS Teléfono, correo AS Correo FROM tbltutores WHERE nombreTutor LIKE @nombreTutor;";
                    using (var consultar = new MySqlCommand(sql, conexion))
                    {
                        consultar.Parameters.AddWithValue("@nombreTutor", "%" + nombreTutor + "%");
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
                        //Registro nuevo
                        case 0:
                            string sqlN = "INSERT INTO tbltutores(nombreTutor, parentesco, direccion, telefono, correo) VALUES(@nombreTutor, @parentesco, @direccion, @telefono, @correo);";
                            using (comando = new MySqlCommand(sqlN, conexion))
                            {
                                comando.Parameters.AddWithValue("nombreTutor", nombreTutor);
                                comando.Parameters.AddWithValue("parentesco", parentesco);
                                comando.Parameters.AddWithValue("direccion", direccion);
                                comando.Parameters.AddWithValue("telefono", telefono);
                                comando.Parameters.AddWithValue("correo", correo);
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
                        //Registro viejo
                        case 1:
                            string sqlA = "UPDATE tbltutores T SET T.nombreTutor = @nombreTutor, T.parentesco = @parentesco, T.direccion = @direccion, T.telefono = @telefono, T.correo = @correo WHERE T.idTutor = @idTutor;";
                            using (comando = new MySqlCommand(sqlA, conexion))
                            {
                                comando.Parameters.AddWithValue("idTutor", idTutor);
                                comando.Parameters.AddWithValue("nombreTutor", nombreTutor);
                                comando.Parameters.AddWithValue("parentesco", parentesco);
                                comando.Parameters.AddWithValue("direccion", direccion);
                                comando.Parameters.AddWithValue("telefono", telefono);
                                comando.Parameters.AddWithValue("correo", correo);
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

        public string Eliminar()
        {
            string msg = "";
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "DELETE FROM tbltutores T WHERE T.idTutor = @idTutor;";
                    using (comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@idTutor", idTutor);
                        int filaafectadas = comando.ExecuteNonQuery();
                        if (filaafectadas > 0)
                        {
                            msg = "Datos eliminados correctamente";
                        }
                        else
                        {
                            msg = "Los datos no se pudieron eliminar";
                        }
                    }///Libera la eliminacion
                }///Liberar las conexiones
            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);
            }
            return msg;
        }
    }
}
