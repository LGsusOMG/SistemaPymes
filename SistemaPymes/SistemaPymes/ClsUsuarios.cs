using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Agregar las referencias a las librerías de mysql y System.Data
using System.Data;
using MySql.Data.MySqlClient;

namespace SistemaPymes
{
    class ClsUsuarios
    {
        private string us; //interactuará con la propiedad usuario
        private string cl; //interactuará con la propiedad clave
        private string rl; //interactuará con la propiedad rol

        //Implementar las propiedades

        public string usuario { get { return this.us; } set { this.us = value; } }
        public string clave { get { return this.cl; } set { this.cl = value; } }
        public string rol { get { return this.rl; } set { this.rl = value; } }

        //Implementar los metodos de la clase ClsUsuarios

        public bool Guardar()
        {
            MySqlConnection cn = new MySqlConnection(miclase.conexion);
            MySqlCommand cmd = new MySqlCommand("Insert into usuarios values(@us,@cl,@rl)", cn);
            cn.Open();
            cmd.Parameters.AddWithValue("@us", this.us);
            cmd.Parameters.AddWithValue("@cl", this.cl);
            cmd.Parameters.AddWithValue("@rl", this.rl);
            if (cmd.ExecuteNonQuery() > 0) return true; else return false;
        }

        public bool Eliminar(string x)
        {
            MySqlConnection cn = new MySqlConnection(miclase.conexion);
            MySqlCommand cmd = new MySqlCommand("Delete from usuarios Where usuario=@us", cn);
            cn.Open();
            cmd.Parameters.AddWithValue("@us", x);
            if (cmd.ExecuteNonQuery() > 0) return true; else return false;
        }

        public bool Modificar()
        {
            MySqlConnection cn = new MySqlConnection(miclase.conexion);
            MySqlCommand cmd = new MySqlCommand("Update usuarios set clave=@cl,rol=@rl Where usuario=@us", cn);
            cn.Open();
            cmd.Parameters.AddWithValue("@us", this.us);
            cmd.Parameters.AddWithValue("@cl", this.cl);
            cmd.Parameters.AddWithValue("@rl", this.rl);
            if (cmd.ExecuteNonQuery() > 0) return true; else return false;
        }

        public List<string> Consulta(string cod)
        {
            List<string> datos = null;
            MySqlConnection cn = new MySqlConnection(miclase.conexion);
            MySqlCommand cmd = new MySqlCommand("select * from Usuarios Where usuario=@us", cn);
            cn.Open();
            cmd.Parameters.AddWithValue("@us", cod);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                datos = new List<string>();
                datos.Add(reader["clave"].ToString());
                datos.Add(reader["rol"].ToString());
            }
            return datos;
        }

        public DataTable Reporte()//retorna una tabla de datos
        {
            try
            {
                DataTable dt = new DataTable();
                MySqlConnection cn = new MySqlConnection(miclase.conexion);
                using (cn)
                {
                    MySqlCommand cmd = new MySqlCommand("Select * from USUARIOS", cn);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                    adaptador.Fill(dt);//rellena el datatable (dt) a partir del adaptador                 
                    return dt;//retorna el DataTable 
                }
            }
            catch
            {
                return null;
            }
        }
    }
}