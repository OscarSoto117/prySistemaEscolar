using System;
using System.Data;
using MySqlConnector;

namespace prySistemaEscolar
{
    internal class clsTutores
    {
        private int idTutor;
        private string nombreTutor;
        private string parentesco;
        private string direccion;
        private string telefono;
        private string correo;

        private MySqlDataAdapter consulta;
        private MySqlCommand comando;
        private DataTable tabla;

        // Propiedades Get/Set
        public int IdTutor { get => idTutor; set => idTutor = value; }
        public string NombreTutor { get => nombreTutor; set => nombreTutor = value; }
        public string Parentesco { get => parentesco; set => parentesco = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }

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
                    }
                }
            }
            catch (Exception ex) { throw new Exception("Error al cargar datos: " + ex.Message); }
            return tabla;
        }

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
                    }
                }
            }
            catch (Exception ex) { throw new Exception("Error en búsqueda: " + ex.Message); }
            return tabla;
        }

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
                        case 0: 
                            string sqlN = "INSERT INTO tbltutores(nombreTutor, parentesco, direccion, telefono, correo) VALUES(@nombreTutor, @parentesco, @direccion, @telefono, @correo);";
                            using (comando = new MySqlCommand(sqlN, conexion))
                            {
                                comando.Parameters.AddWithValue("@nombreTutor", nombreTutor);
                                comando.Parameters.AddWithValue("@parentesco", parentesco);
                                comando.Parameters.AddWithValue("@direccion", direccion);
                                comando.Parameters.AddWithValue("@telefono", telefono);
                                comando.Parameters.AddWithValue("@correo", correo);
                                msg = comando.ExecuteNonQuery() > 0 ? "Registro guardado correctamente" : "Error, Datos no guardados";
                            }
                            break;
                        case 1: 
                            string sqlA = "UPDATE tbltutores SET nombreTutor = @nombreTutor, parentesco = @parentesco, direccion = @direccion, telefono = @telefono, correo = @correo WHERE idTutor = @idTutor;";
                            using (comando = new MySqlCommand(sqlA, conexion))
                            {
                                comando.Parameters.AddWithValue("@idTutor", idTutor);
                                comando.Parameters.AddWithValue("@nombreTutor", nombreTutor);
                                comando.Parameters.AddWithValue("@parentesco", parentesco);
                                comando.Parameters.AddWithValue("@direccion", direccion);
                                comando.Parameters.AddWithValue("@telefono", telefono);
                                comando.Parameters.AddWithValue("@correo", correo);
                                msg = comando.ExecuteNonQuery() > 0 ? "Registro actualizado correctamente" : "Error, Datos no actualizados";
                            }
                            break;
                    }
                }
            }
            catch (Exception ex) { throw new Exception("Error: " + ex.Message); }
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
                    string sql = "DELETE FROM tbltutores WHERE idTutor = @idTutor;";
                    using (comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@idTutor", idTutor);
                        msg = comando.ExecuteNonQuery() > 0 ? "Datos eliminados correctamente" : "Los datos no se pudieron eliminar";
                    }
                }
            }
            catch (Exception ex) { throw new Exception("Error: " + ex.Message); }
            return msg;
        }
    }
}