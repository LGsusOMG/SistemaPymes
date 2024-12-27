using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Agregar las referencias a las librerías de mysql y System.Data
using System.Data;
using MySql.Data.MySqlClient;

namespace SistemaPymes
{
    internal class ClsVentas
    {
        //Definir variables privadas para interactuar con propiedades
        // y métodos
        private int co;  // interactuará con la propiedad codigo
        private string rf; // interactuará con la propiedad rfc
        private string no; // interactuará con la propiedad nombre
        private string di; // interactuará con la propiedad direccion
        private string te; // interactuará con la propiedad telefono
        private string coart;//interactuará con la propiedad codigo
        private string ds;//interactuará con la propiedad descripcion
        private float pv;//interactuará con la propiedad precio venta

        //Implementar las propiedades

        public int codigo { get { return this.co; } set { this.co = value; } }
        public string rfc { get { return this.rf; } set { this.rf = value; } }
        public string nombre { get { return this.no; } set { this.no = value; } }
        public string direccion { get { return this.di; } set { this.di = value; } }
        public string telefono { get { return this.te; } set { this.te = value; } }
        public string codigoart { get { return this.coart; } set { this.coart = value; } }
        public string descripcion { get { return this.ds; } set { this.ds = value; } }
        public float pventa { get { return this.pv; } set { this.pv = value; } }

        //Implementar los metodos de la clase ClsArticulos

        public List<string> ConsultaClientes(int cod)
        {
            List<string> datos = null;
            MySqlConnection cn = new MySqlConnection(miclase.conexion);
            MySqlCommand cmd = new MySqlCommand("select * from Clientes where codigo=@co", cn);
            cn.Open();
            cmd.Parameters.AddWithValue("@co", cod);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                datos = new List<string>();
                datos.Add(reader["rfc"].ToString());
                datos.Add(reader["nombre"].ToString());
                datos.Add(reader["direccion"].ToString());
                datos.Add(reader["telefono"].ToString());
            }
            return datos;
        }

        public List<string> ConsultaArticulos(int cod)
        {
            List<string> datos = null;
            MySqlConnection cn = new MySqlConnection(miclase.conexion);
            MySqlCommand cmd = new MySqlCommand("select * from Articulos where codigo=@coart", cn);
            cn.Open();
            cmd.Parameters.AddWithValue("@coart", cod);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                datos = new List<string>();
                datos.Add(reader["descripcion"].ToString());
                datos.Add(reader["pventa"].ToString());
            }
            return datos;
        }
    }
}
