using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Agregar las referencias a las librerías de mysql y System.Data
using System.Data;
using MySql.Data.MySqlClient;

namespace SistemaPymes
{
    class ClsArticulos
    {
        //Definir variables privadas para interactuar con propiedades
        // y métodos
        private string co;//interactuará con la propiedad codigo
        private string ds;//interactuará con la propiedad descripcion
        private float pc;//interactuará con la propiedad precio compra
        private float pv;//interactuará con la propiedad precio venta
        private float ex;//interactuará con la propiedad existencia
        private float sm;//interactuará con la propiedad sminimo
        private float sma;//interactuara con la propiedad smaximo
        private int pr;//interactuara con la propiedad proveedor

        //Implementar las propiedades

        public string codigo { get { return this.co; } set { this.co = value; } }
        public string descripcion { get { return this.ds; } set { this.ds = value; } }
        public float pcompra { get { return this.pc; } set { this.pc = value; } }
        public float pventa { get { return this.pv; } set { this.pv = value; } }
        public float existencia { get { return this.ex; } set { this.ex = value; } }
        public float sminimo { get { return this.sm; } set { this.sm = value; } }
        public float smaximo { get { return this.sma; } set { this.sma = value; } }
        public int proveedor { get { return this.pr; } set { this.pr = value; } }

        //Implementar los metodos de la clase ClsArticulos

        public bool Guardar()
        {
            MySqlConnection cn = new MySqlConnection(miclase.conexion);
            MySqlCommand cmd = new MySqlCommand("Insert into articulos values (@co,@ds,@pc,@pv,@ex,@sm,@sma,@pr)", cn);
            cn.Open();
            cmd.Parameters.AddWithValue("@co", this.co);
            cmd.Parameters.AddWithValue("@ds", this.ds);
            cmd.Parameters.AddWithValue("@pc", this.pc);
            cmd.Parameters.AddWithValue("@pv", this.pv);
            cmd.Parameters.AddWithValue("@ex", this.ex);
            cmd.Parameters.AddWithValue("@sm", this.sm);
            cmd.Parameters.AddWithValue("@sma", this.sma);
            cmd.Parameters.AddWithValue("@pr", this.pr);
            if (cmd.ExecuteNonQuery() > 0) return true; else return false;
        }

        public bool Eliminar(int x)
        {
            MySqlConnection cn = new MySqlConnection(miclase.conexion);
            MySqlCommand cmd = new MySqlCommand("Delete from articulos Where codigo=@co", cn);
            cn.Open();
            cmd.Parameters.AddWithValue("@co", x);
            if (cmd.ExecuteNonQuery() > 0) return true; else return false;
        }

        public bool Modificar()
        {
            MySqlConnection cn = new MySqlConnection(miclase.conexion);
            MySqlCommand cmd = new MySqlCommand("Update articulos set descripcion=@ds,pcompra=@pc,pventa=@pv,existencia=@ex,sminimo=@sm,smaximo=@sma,proveedor=@pr where codigo=@co", cn);
            cn.Open();
            cmd.Parameters.AddWithValue("@co", this.co);
            cmd.Parameters.AddWithValue("@ds", this.ds);
            cmd.Parameters.AddWithValue("@pc", this.pc);
            cmd.Parameters.AddWithValue("@pv", this.pv);
            cmd.Parameters.AddWithValue("@ex", this.ex);
            cmd.Parameters.AddWithValue("@sm", this.sm);
            cmd.Parameters.AddWithValue("@sma", this.sma);
            cmd.Parameters.AddWithValue("@pr", this.pr);
            if (cmd.ExecuteNonQuery() > 0) return true; else return false;
        }

        public DataTable Reporte()
        {
            try
            {
                DataTable dt = new DataTable();
                MySqlConnection cn = new MySqlConnection(miclase.conexion);
                using (cn)
                {
                    MySqlCommand cmd = new MySqlCommand("Select * from ARTICULOS", cn);
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

        public List<string> Consulta(int cod)
        {
           List<string> datos = null;
           MySqlConnection cn = new MySqlConnection(miclase.conexion);
           MySqlCommand cmd = new MySqlCommand("select * from Articulos where codigo=@co", cn);
           cn.Open();
           cmd.Parameters.AddWithValue("@co", cod);
           MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                datos = new List<string>();
                datos.Add(reader["descripcion"].ToString());
                datos.Add(reader["pcompra"].ToString());
                datos.Add(reader["pventa"].ToString());
                datos.Add(reader["existencia"].ToString());
                datos.Add(reader["sminimo"].ToString());
                datos.Add(reader["smaximo"].ToString());
                datos.Add(reader["proveedor"].ToString() );
            }
           return datos;
        }

        public string ObtenerNombreProveedor(string codprov)
        {
            MySqlConnection cn = new MySqlConnection(miclase.conexion);
            MySqlCommand cmd = new MySqlCommand("select nombre from proveedores where codigo=@co", cn);
            cn.Open();
            cmd.Parameters.AddWithValue("@co", codprov);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return reader["nombre"].ToString();
            }
            else
                return "Pura verga encontre algo";
        }
    }
}
