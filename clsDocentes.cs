using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace prySistemaEscolar
{
    internal class clsDocentes
    {
        // Atributos de la tabla tbldocentes
        private int claveDocente; // PK Auto-incrementable
        private string nombreDocente;
        private string puesto;
        private string telefono;
        private string correo;
        private int idUsuario; // FK

        // Atributos para registrar el usuario (tblusuarios)
        private string nombreUsuario;
        private string password;
        private string perfil;

        // Adaptador y tabla virtuales de la clase
        private MySqlDataAdapter consulta;
        private MySqlCommand comando;
        private DataTable tabla;

        // Propiedades
        public int ClaveDocente { get => claveDocente; set => claveDocente = value; }
        public string NombreDocente { get => nombreDocente; set => nombreDocente = value; }
        public string Puesto { get => puesto; set => puesto = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Password { get => password; set => password = value; }
        public string Perfil { get => perfil; set => perfil = value; }

        // Método para cargar datos generales en el Grid
        public DataTable CargarDataGrid()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT D.claveDocente AS Clave, " +
                                 "D.nombreDocente AS Nombre, " +
                                 "D.puesto AS Puesto, " +
                                 "D.telefono AS Teléfono, " +
                                 "D.correo AS Correo, " +
                                 "U.vchnombreUsuario AS Usuario, " +
                                 "U.vchpassword, " +
                                 "U.vchperfil, " +
                                 "D.idUsuario " +
                                 "FROM tbldocentes D " +
                                 "INNER JOIN tblusuarios U ON D.idUsuario = U.intidUsuario;";

                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexión: " + ex.Message);
            }
            return tabla;
        }

        // Método para limpiar los TextBoxes y ComboBoxes
        public void LimpiarPanel(Panel panelDestino)
        {
            foreach (Control control in panelDestino.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = 0;
                }
            }
        }

        // Método para buscar a un docente específico
        public DataTable Consultar()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT D.claveDocente AS Clave, " +
                                 "D.nombreDocente AS Nombre, " +
                                 "D.puesto AS Puesto, " +
                                 "D.telefono AS Teléfono, " +
                                 "D.correo AS Correo, " +
                                 "U.vchnombreUsuario AS Usuario, " +
                                 "U.vchpassword, " +
                                 "U.vchperfil, " +
                                 "D.idUsuario " +
                                 "FROM tbldocentes D " +
                                 "INNER JOIN tblusuarios U ON D.idUsuario = U.intidUsuario " +
                                 "WHERE D.claveDocente LIKE @clave;";

                    using (var consultar = new MySqlCommand(sql, conexion))
                    {
                        consultar.Parameters.AddWithValue("@clave", "%" + claveDocente + "%");
                        using (consulta = new MySqlDataAdapter(consultar))
                        {
                            consulta.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexion de la base de datos: " + ex.Message);
            }
            return tabla;
        }

        // Método para insertar (0) o actualizar (1)
        public string GuardarActualizar(int tipoOperacion)
        {
            string msg = "";
            clsConexion conexionBD = new clsConexion();

            try
            {
                using (var conexion = conexionBD.AbrirConexion())
                {
                    using (var transaccion = conexion.BeginTransaction())
                    {
                        try
                        {
                            switch (tipoOperacion)
                            {
                                case 0: // NUEVO E INSERTAR
                                    // Paso A: Insertar en la tabla tblusuarios
                                    string sqlInsUser = "INSERT INTO tblusuarios(vchnombreUsuario, vchpassword, vchperfil, vchestado) " +
                                                        "VALUES(@nomUser, MD5(@pass), @perfil, 'Activo'); SELECT LAST_INSERT_ID();";

                                    int nuevoIdUsuario = 0;
                                    using (comando = new MySqlCommand(sqlInsUser, conexion, transaccion))
                                    {
                                        comando.Parameters.AddWithValue("@nomUser", nombreUsuario);
                                        comando.Parameters.AddWithValue("@pass", string.IsNullOrEmpty(password) ? "" : password);
                                        comando.Parameters.AddWithValue("@perfil", perfil);
                                        nuevoIdUsuario = Convert.ToInt32(comando.ExecuteScalar());
                                    }

                                    // Paso B: Insertar el docente en tbldocentes vinculando el ID de usuario (sin pasar claveDocente porque es Auto Incrementable)
                                    string sqlInsDocente = "INSERT INTO tbldocentes(idUsuario, nombreDocente, puesto, telefono, correo) " +
                                                           "VALUES(@idUsuario, @nombre, @puesto, @tel, @correo);";

                                    using (comando = new MySqlCommand(sqlInsDocente, conexion, transaccion))
                                    {
                                        comando.Parameters.AddWithValue("@idUsuario", nuevoIdUsuario);
                                        comando.Parameters.AddWithValue("@nombre", nombreDocente);
                                        comando.Parameters.AddWithValue("@puesto", puesto);
                                        comando.Parameters.AddWithValue("@tel", telefono);
                                        comando.Parameters.AddWithValue("@correo", correo);

                                        comando.ExecuteNonQuery();
                                    }
                                    msg = "El Docente y sus credenciales se guardaron correctamente.";
                                    break;

                                case 1: // ACTUALIZAR
                                    // Paso A: Actualizar la tabla de usuarios utilizando el idUsuario
                                    string sqlUpdUser = "UPDATE tblusuarios SET vchnombreUsuario = @nomUser, vchperfil = @perfil " +
                                                        "WHERE intidUsuario = @idUsuario;";

                                    using (comando = new MySqlCommand(sqlUpdUser, conexion, transaccion))
                                    {
                                        comando.Parameters.AddWithValue("@idUsuario", idUsuario);
                                        comando.Parameters.AddWithValue("@nomUser", nombreUsuario);
                                        comando.Parameters.AddWithValue("@perfil", perfil);
                                        comando.ExecuteNonQuery();
                                    }

                                    // Paso B: Actualizar los datos del docente mediante su claveDocente
                                    string sqlUpdDocente = "UPDATE tbldocentes SET nombreDocente = @nombre, puesto = @puesto, " +
                                                           "telefono = @tel, correo = @correo WHERE claveDocente = @clave;";

                                    using (comando = new MySqlCommand(sqlUpdDocente, conexion, transaccion))
                                    {
                                        comando.Parameters.AddWithValue("@clave", claveDocente);
                                        comando.Parameters.AddWithValue("@nombre", nombreDocente);
                                        comando.Parameters.AddWithValue("@puesto", puesto);
                                        comando.Parameters.AddWithValue("@tel", telefono);
                                        comando.Parameters.AddWithValue("@correo", correo);

                                        comando.ExecuteNonQuery();
                                    }
                                    msg = "Los datos del docente se actualizaron correctamente.";
                                    break;
                            }
                            transaccion.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaccion.Rollback();
                            throw new Exception("Error en la operación. Se cancelaron los cambios: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error de conexión: " + ex.Message);
            }

            return msg;
        }

        // Método para borrar al docente y su usuario
        public string Eliminar()
        {
            string msg = "";
            clsConexion conexionBD = new clsConexion();
            try
            {
                using (var conexion = conexionBD.AbrirConexion())
                {
                    using (var transaccion = conexion.BeginTransaction())
                    {
                        try
                        {
                            // Se elimina primero al docente por restricción de llave foránea
                            string sqlDelDocente = "DELETE FROM tbldocentes WHERE claveDocente = @clave;";
                            using (comando = new MySqlCommand(sqlDelDocente, conexion, transaccion))
                            {
                                comando.Parameters.AddWithValue("@clave", claveDocente);
                                comando.ExecuteNonQuery();
                            }

                            // Se elimina el usuario asociado
                            string sqlDelUsuario = "DELETE FROM tblusuarios WHERE intidUsuario = @idusuario;";
                            using (var comandoUsuario = new MySqlCommand(sqlDelUsuario, conexion, transaccion))
                            {
                                comandoUsuario.Parameters.AddWithValue("@idusuario", idUsuario);
                                comandoUsuario.ExecuteNonQuery();
                            }

                            transaccion.Commit();
                            msg = "El docente y sus credenciales de usuario han sido eliminados del sistema";
                        }
                        catch (Exception ex)
                        {
                            transaccion.Rollback();
                            throw new Exception("No se pudo llevar a cabo la eliminación. Cambios revertidos: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            return msg;
        }
    }
}