using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace prySistemaEscolar
{
    internal class clsAlumnos
    {
        private int matricula;
        private string nombreAlumno;
        private string apellidoP;
        private string apellidoM;
        private string direccion;
        private string telefono;
        private string correo;
        private decimal promedioBachillerato;
        private int idTutor;//fk
        private int idCarrera;//fk
        private int idUsuario;

        //atributos para registrar el usuario
        private string nombreUsuario;
        private string password;
        private string perfil;

        // Adaptador y tabla virtuales de la clase
        private MySqlDataAdapter consulta;
        private MySqlCommand comando;
        private DataTable tabla;

        //propiedades
        public int Matricula { get => matricula; set => matricula = value; }
        public string NombreAlumno { get => nombreAlumno; set => nombreAlumno = value; }
        public string ApellidoP { get => apellidoP; set => apellidoP = value; }
        public string ApellidoM { get => apellidoM; set => apellidoM = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public decimal PromedioBachillerato { get => promedioBachillerato; set => promedioBachillerato = value; }
        public int IdTutor { get => idTutor; set => idTutor = value; }
        public int IdCarrera { get => idCarrera; set => idCarrera = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Password { get => password; set => password = value; }
        public string Perfil { get => perfil; set => perfil = value; }

        public DataTable CargarDataGrid()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT A.matricula AS Matrícula, " +
                                "A.nombreAlumno AS Nombre, " +
                                "A.apellidoP AS 'A. Paterno', " +
                                "A.apellidoM AS 'A. Materno', " +
                                "C.nombreCarrera AS Carrera, " +
                                "T.nombreTutor AS Tutor, " +
                                "U.vchnombreUsuario AS Usuario, " +
                                "U.vchpassword, " +
                                "U.vchperfil, " +
                                "A.direccion, A.telefono, A.correo, A.promedioBachillerato, A.idTutor, A.idCarrera, A.idUsuario " +
                                "FROM tblalumnos A " +
                                "INNER JOIN tblcarreras C ON A.idCarrera = C.idCarrera " +
                                "INNER JOIN tbltutores T ON A.idTutor = T.idTutor " +
                                "INNER JOIN tblusuarios U ON A.idUsuario = U.intidUsuario;";
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

        //para el combo de carreras
        public DataTable ObtenerCarreras()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT idCarrera, nombreCarrera FROM tblcarreras;";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el catálogo de carreras: " + ex.Message);
            }
            return tabla;
        }

        // Método para el combo de tutores
        public DataTable ObtenerTutores()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT idTutor, nombreTutor FROM tbltutores;";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el catálogo de tutores: " + ex.Message);
            }
            return tabla;
        }

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

        public DataTable Consultar()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT A.matricula AS Matrícula, " +
                                     "A.nombreAlumno AS Nombre, " +
                                     "A.apellidoP AS 'A. Paterno', " +
                                     "A.apellidoM AS 'A. Materno', " +
                                     "C.nombreCarrera AS Carrera, " +
                                     "T.nombreTutor AS Tutor, " +
                                     "U.vchnombreUsuario AS Usuario, " +
                                     "U.vchpassword, " + // <-- AQUÍ SE AGREGA EL PASSWORD
                                     "U.vchperfil, " +  // <-- AQUÍ SE AGREGA EL PERFIL
                                     "A.direccion, A.telefono, A.correo, A.promedioBachillerato, A.idTutor, A.idCarrera, A.idUsuario " +
                                     "FROM tblalumnos A " +
                                     "INNER JOIN tblcarreras C ON A.idCarrera = C.idCarrera " +
                                     "INNER JOIN tbltutores T ON A.idTutor = T.idTutor " +
                                     "INNER JOIN tblusuarios U ON A.idUsuario = U.intidUsuario WHERE A.matricula LIKE @matricula";

                    using (var consultar = new MySqlCommand(sql, conexion))
                    {
                        consultar.Parameters.AddWithValue("@matricula", "%" + matricula + "%");
                        using (consulta = new MySqlDataAdapter(consultar))
                        {
                            consulta.Fill(tabla);
                        }//liberar el adaptador
                    }//liberar la consulta
                }//libera la conexion
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexion de la base de datos" + ex.Message);
            }
            return tabla;
        }

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
                                case 0: //NUEVO E INSERTAR
                                    //insertarmos en la tabla tbusuarios
                                    string sqlInsUser = "INSERT INTO tblusuarios(vchnombreUsuario, vchpassword, vchperfil, vchestado) " +
                                                        "VALUES(@nomUser, MD5(@pass), @perfil, 'Activo'); SELECT LAST_INSERT_ID();";

                                    int nuevoIdUsuario = 0;
                                    using (comando = new MySqlCommand(sqlInsUser, conexion, transaccion))
                                    {
                                        comando.Parameters.AddWithValue("@nomUser", nombreUsuario);
                                        comando.Parameters.AddWithValue("@pass", string.IsNullOrEmpty (password) ? "" : password);
                                        comando.Parameters.AddWithValue("@perfil", perfil);
                                        nuevoIdUsuario = Convert.ToInt32(comando.ExecuteScalar());
                                    }

                                    // Paso B: Insertar el alumno en tblalumnos vinculando el ID de usuario obtenido
                                    string sqlInsAlumno = "INSERT INTO tblalumnos(matricula, idUsuario, nombreAlumno, apellidoP, apellidoM, direccion, telefono, correo, promedioBachillerato, idTutor, idCarrera) " +
                                                          "VALUES(@matricula, @idUsuario, @nombre, @apP, @apM, @dir, @tel, @correo, @prom, @idTutor, @idCarrera);";

                                    using (comando = new MySqlCommand(sqlInsAlumno, conexion, transaccion))
                                    {
                                        comando.Parameters.AddWithValue("@matricula", matricula);
                                        comando.Parameters.AddWithValue("@idUsuario", nuevoIdUsuario);
                                        comando.Parameters.AddWithValue("@nombre", nombreAlumno);
                                        comando.Parameters.AddWithValue("@apP", apellidoP);
                                        comando.Parameters.AddWithValue("@apM", apellidoM);
                                        comando.Parameters.AddWithValue("@dir", direccion);
                                        comando.Parameters.AddWithValue("@tel", telefono);
                                        comando.Parameters.AddWithValue("@correo", correo);
                                        comando.Parameters.AddWithValue("@prom", promedioBachillerato);
                                        comando.Parameters.AddWithValue("@idTutor", idTutor);
                                        comando.Parameters.AddWithValue("@idCarrera", idCarrera);

                                        comando.ExecuteNonQuery();
                                    }
                                    msg = "El Alumno y sus credenciales se guardaron correctamente.";
                                    break;

                                case 1: // ACTUALIZAR
                                    // Paso A: Actualizar la tabla de usuarios utilizando el ID que recuperamos en el clic del Grid
                                    string sqlUpdUser = "UPDATE tblusuarios SET vchnombreUsuario = @nomUser, vchperfil = @perfil " +
                                                        "WHERE intidUsuario = @idUsuario;";

                                    using (comando = new MySqlCommand(sqlUpdUser, conexion, transaccion))
                                    {
                                        comando.Parameters.AddWithValue("@idUsuario", idUsuario);
                                        comando.Parameters.AddWithValue("@nomUser", nombreUsuario);
                                        comando.Parameters.AddWithValue("@perfil", perfil);

                                        comando.ExecuteNonQuery();
                                    }

                                    // Paso B: Actualizar los datos del expediente en tblalumnos mediante su matrícula
                                    string sqlUpdAlumno = "UPDATE tblalumnos SET nombreAlumno = @nombre, apellidoP = @apP, apellidoM = @apM, " +
                                                          "direccion = @dir, telefono = @tel, correo = @correo, promedioBachillerato = @prom, " +
                                                          "idTutor = @idTutor, idCarrera = @idCarrera WHERE matricula = @matricula;";

                                    using (comando = new MySqlCommand(sqlUpdAlumno, conexion, transaccion))
                                    {
                                        comando.Parameters.AddWithValue("@matricula", matricula);
                                        comando.Parameters.AddWithValue("@nombre", nombreAlumno);
                                        comando.Parameters.AddWithValue("@apP", apellidoP);
                                        comando.Parameters.AddWithValue("@apM", apellidoM);
                                        comando.Parameters.AddWithValue("@dir", direccion);
                                        comando.Parameters.AddWithValue("@tel", telefono);
                                        comando.Parameters.AddWithValue("@correo", correo);
                                        comando.Parameters.AddWithValue("@prom", promedioBachillerato);
                                        comando.Parameters.AddWithValue("@idTutor", idTutor);
                                        comando.Parameters.AddWithValue("@idCarrera", idCarrera);

                                        comando.ExecuteNonQuery();
                                    }
                                    msg = "Los datos del alumno se actualizaron correctamente.";
                                    break;
                            }
                            transaccion.Commit();
                        }
                        catch (Exception ex)
                        {
                            // Si algo falló (en el usuario o en el alumno), deshacemos todo para evitar inconsistencias
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
        //Metodo para borrar
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
                            //Se elimina el alumno
                            string sqlDelAlumno = "DELETE FROM tblalumnos WHERE matricula = @matricula;";
                            using (comando = new MySqlCommand(sqlDelAlumno, conexion, transaccion))
                            {
                                comando.Parameters.AddWithValue("@matricula", matricula);
                                comando.ExecuteNonQuery();
                            }
                            //Se elimina el usuario
                            string sqlDelUsuario = "DELETE FROM tblusuarios WHERE intidUsuario = @idusuario;";
                            using (var comandoUsuario = new MySqlCommand(sqlDelUsuario, conexion, transaccion))
                            {
                                comandoUsuario.Parameters.AddWithValue("@idusuario", idUsuario);
                                comandoUsuario.ExecuteNonQuery();
                            }
                            //Se elimin+a correctamente
                            transaccion.Commit();
                            msg = "El alumno y sus credenciales de usuario han sido eliminados del sistema";
                        }
                        catch (Exception ex)
                        {
                            //Si algo llega ha fallar, se deshacen las operaciones para no dejar datos huerfanos
                            transaccion.Rollback();
                            throw new Exception("No se pudo llevar a cabo la eliminación. Cambios reventidos" + ex.Message);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);
            }
            return msg;
        }
    }
}