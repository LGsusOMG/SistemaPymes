using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SistemaPymes
{
    internal class ClsSushis
    {
        //Definir variables privadas para interactuar con propiedades
        // y métodos
        private int co;//interactuará con la propiedad codigo
        private string nom;//interactuará con la propiedad Nombre
        private string ds;//interactuará con la propiedad descripcion
        private float pr;//interactua con la propiedad precio

        //Implementar las propiedades

        public int codigo { get { return this.co; } set { this.co = value; } }
        public string nombre { get { return this.nom; } set { this.nom = value; } }
        public string descripcion { get { return this.ds; } set { this.ds = value; } }
        public float precio { get { return this.pr; } set { this.pr = value; } }


        //Implementar los metodos de la clase ClsSushi

        public bool Guardar()
        {
            try
            {
                using (MySqlConnection cn = new MySqlConnection(miclase.conexion))
                {
                    MySqlCommand cmd = new MySqlCommand("Insert into sushis values (@co,@nom,@ds,@pr)", cn);
                    cmd.Parameters.AddWithValue("@co", this.co);
                    cmd.Parameters.AddWithValue("@nom", this.nom);
                    cmd.Parameters.AddWithValue("@ds", this.ds);
                    cmd.Parameters.AddWithValue("@pr", this.pr);
                    cn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        public bool Eliminar(int x)
        {
            try
            {
                using (MySqlConnection cn = new MySqlConnection(miclase.conexion))
                {
                    MySqlCommand cmd = new MySqlCommand("Delete from sushis Where codigo=@co", cn);
                    cmd.Parameters.AddWithValue("@co", x);
                    cn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        public bool Modificar()
        {
            try
            {
                using (MySqlConnection cn = new MySqlConnection(miclase.conexion))
                {
                    MySqlCommand cmd = new MySqlCommand("Update sushis set nombre=@nom, descripcion=@ds, precio=@pr where codigo=@co", cn);
                    cmd.Parameters.AddWithValue("@co", this.co);
                    cmd.Parameters.AddWithValue("@nom", this.nom);
                    cmd.Parameters.AddWithValue("@ds", this.ds);
                    cmd.Parameters.AddWithValue("@pr", this.pr);
                    cn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        public DataTable Reporte()
        {
            try
            {
                DataTable dt = new DataTable();
                MySqlConnection cn = new MySqlConnection(miclase.conexion);
                using (cn)
                {
                    MySqlCommand cmd = new MySqlCommand("Select * from sushis", cn);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                    adaptador.Fill(dt); //rellena el datatable (dt) a partir del adaptador                 
                    return dt;// retorna el DataTable 
                }
            }
            catch
            {
                return null;
            }
        }

        public List<string> Consulta(string cod)
        {
            List<string> datos = null;
            MySqlConnection cn = new MySqlConnection(miclase.conexion);
            MySqlCommand cmd = new MySqlCommand("select * from sushis where codigo=@co", cn);
            cn.Open();
            cmd.Parameters.AddWithValue("@co", cod);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                datos = new List<string>();
                datos.Add(reader["nombre"].ToString());
                datos.Add(reader["descripcion"].ToString());
                datos.Add(reader["precio"].ToString());
            }
            return datos;
        }
    }
}
