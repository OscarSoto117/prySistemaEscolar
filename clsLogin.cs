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
        public static string perfil;

        public bool ValidarAcceso()
        {
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT perfil FROM tblUsuarios " + "WHERE nombreUsuario = @usuario AND password = @password;";
                    using (var consulta = new MySqlCommand(sql, conexion))
                    {
                        consulta.Parameters.AddWithValue("@usuario", usuario);
                        consulta.Parameters.AddWithValue("@password", password);

                        using (var resultado = consulta.ExecuteReader())
                        {
                            if (resultado.Read())
                            {
                                perfil = resultado.GetString("perfil");
                                MessageBox.Show("Tu perfil es: " + perfil, "Sistema");
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
