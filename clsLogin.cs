using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace prySistemaEscolar
{
    internal class clsLogin
    {
        private string usuario, password;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }
        //Atributos estaticos
        private static string perfil;
        private static bool esAdministrador;
        private static bool esDocente;

        public void AsignarPermisos()
        {
            switch(perfil)
            {
                case "Administrador":
                    esAdministrador = true;
                    esDocente = false;
                    break;
                case "Docente":
                    esAdministrador = false;
                    esDocente = true;
                    break;
                default:
                    esAdministrador = false;
                    esDocente = false;
                    break;
            }
        }

        //Propiedades estaticas
        public static bool EsAdministrador { get => esAdministrador;}
        public static bool EsDocente { get => esDocente; }

        public bool ValidarAcceso()
        {
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT vchperfil FROM tblUsuarios " + "WHERE vchnombreUsuario = @usuario AND vchpassword = MD5(@password);";
                    using (var consulta = new MySqlCommand(sql, conexion))
                    {
                        consulta.Parameters.AddWithValue("@usuario", usuario);
                        consulta.Parameters.AddWithValue("@password", password);

                        using (var resultado = consulta.ExecuteReader())
                        {
                            if (resultado.Read())
                            {
                                perfil = resultado.GetString("vchperfil");
                                AsignarPermisos();
                                if (!esAdministrador && !esDocente)
                                {
                                    throw new Exception($"El perfil {perfil} no tiene permisos para acceder");
                                }

                                MessageBox.Show("Tu perfil es: " + perfil, "sistema");
                                return true;
                            }
                            else
                            {
                                throw new Exception("Usuario o contraseña icorrectos");
                            }
                        }//Liberar MySqlDataReader
                    }//Liberar MySqlCommand
                }//Liberar MySqulConnection a través de la clase
            }
            catch (Exception ex)
            {
                //Si ocurre un error, lo relanzamos para que se capture en el formulario
                throw new Exception(ex.Message, ex);
            }
        }//fin del metodo
    }
}
