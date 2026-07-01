using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
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

        // Adaptador y tabla virtuales de la clase
        private MySqlDataAdapter consulta;
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

    }
}