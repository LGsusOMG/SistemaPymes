using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SistemaPymes
{
    public class ClsAcceso
    {
        private string us; //interactuará con la propiedad usuario
        private string cl; //interactuará con la propiedad clave
        private string rl; //interactuará con la propiedad rol

        public string usuario { get { return this.us; } set { this.us = value; } }
        public string clave { get { return this.cl; } set { this.cl = value; } }
        public string rol { get { return this.rl; } set { this.rl = value; } }

        public bool Login(string username, string password)
        {
            using (MySqlConnection cn = new MySqlConnection(miclase.conexion))
            {
                try
                {
                    cn.Open();
                    string query = "SELECT COUNT(*) FROM usuarios WHERE usuario = @us AND clave = @cl";
                    MySqlCommand command = new MySqlCommand(query, cn);
                    command.Parameters.AddWithValue("@us", username);
                    command.Parameters.AddWithValue("@cl", password);
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        return true; // Autenticación exitosa
                    }
                    else
                    {
                        return false; // Autenticación fallida
                    }
                }
                catch
                {
                    // Manejar excepciones aquí (por ejemplo, registro o notificación de errores)
                    return false; // Autenticación fallida en caso de excepción
                }
            }
        }

        public string rolusuario;

        public string ObtenerRol(string username)
        {
            using (MySqlConnection cn = new MySqlConnection(miclase.conexion))
            {
                try
                {
                    cn.Open();
                    string query = "SELECT rol FROM usuarios WHERE usuario = @us";
                    MySqlCommand command = new MySqlCommand(query, cn);
                    command.Parameters.AddWithValue("@us", username);
                    string rolusuario = command.ExecuteScalar() as string;

                    return rolusuario;
                }
                catch
                {
                    // Manejar excepciones aquí (por ejemplo, registro o notificación de errores)
                    return null; // En caso de error, devuelve null
                }
            }
        }
    }
}
