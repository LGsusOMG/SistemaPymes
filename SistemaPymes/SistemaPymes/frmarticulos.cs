using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace SistemaPymes
{
    public partial class frmarticulos : Form
    {
        public frmarticulos()
        {
            InitializeComponent();
        }

        ClsArticulos c = new ClsArticulos();

        private void btnsalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmarticulos_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmmenu fm = new frmmenu();
            fm.Show();
        }

        public void ActualizaDG()
        {
            dgarticulos.DataSource = c.Reporte();
        }

        private void frmarticulos_Load(object sender, EventArgs e)
        {
            txtcodigo.Text = miclase.FolioSiguiente("codigo", "articulos").ToString();
            ActualizaDG();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            c.codigo = txtcodigo.Text;
            c.descripcion = txtdescripcion.Text;
            c.pcompra = float.Parse(txtpcompra.Text);
            c.pventa = float.Parse(txtpventa.Text);
            c.existencia = float.Parse(txtexistencia.Text);
            c.sminimo = float.Parse(txtsminimo.Text);
            c.smaximo = float.Parse(txtsmaximo.Text);
            c.proveedor = traerCodigoProveedor(txtproveedor.Text);
            if (c.Guardar() == true)
            {
                ActualizaDG();
                limpiar();
                deshabilitar();
                MessageBox.Show("Guardado");
                txtcodigo.Enabled = true;
                txtcodigo.Focus();
            }
            else
                MessageBox.Show("Error al Guardar");
            btnguardar.Enabled = false;
        }

        public void habilitar()
        {
            txtcodigo.Enabled = true;
            txtdescripcion.Enabled = true;
            txtpcompra.Enabled = true;
            txtpventa.Enabled = true;
            txtexistencia.Enabled = true;
            txtsminimo.Enabled = true;
            txtsmaximo.Enabled = true;
            txtproveedor.Enabled = true;
        }

        public void deshabilitar()
        {
            txtcodigo.Enabled = true;
            txtdescripcion.Enabled = true;
            txtpcompra.Enabled = true;
            txtpventa.Enabled = true;
            txtexistencia.Enabled = true;
            txtsminimo.Enabled = true;
            txtsmaximo.Enabled = true;
            txtproveedor.Enabled = true;
        }

        public void limpiar()
        {
            txtcodigo.Clear();
            txtdescripcion.Clear();
            txtpcompra.Clear();
            txtpventa.Clear();
            txtexistencia.Clear();
            txtsminimo.Clear();
            txtsmaximo.Clear();
            txtproveedor.Clear();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            c.codigo = txtcodigo.Text;
            c.descripcion = txtdescripcion.Text;
            c.pcompra = float.Parse(txtpcompra.Text);
            c.pventa = float.Parse(txtpventa.Text);
            c.existencia = float.Parse(txtexistencia.Text);
            c.sminimo = float.Parse(txtsminimo.Text);
            c.smaximo = float.Parse(txtsmaximo.Text);
            c.proveedor = traerCodigoProveedor(txtproveedor.Text);
            if (c.Modificar() == true)
            {
                ActualizaDG();
                limpiar();
                deshabilitar();
                MessageBox.Show("Modificado");
                txtcodigo.Enabled = true;
                txtcodigo.Focus();
            }
            else
                MessageBox.Show("Error al Modificar");
            btnmodificar.Enabled = false;
            btneliminar.Enabled = false;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Realmente desea Eliminarlo?", "Eliminar Registro",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opcion == DialogResult.Yes)
            {
                if (c.Eliminar(int.Parse(txtcodigo.Text)) == true)
                {
                    ActualizaDG();
                    limpiar();
                    deshabilitar();
                    MessageBox.Show("Eliminado");
                    txtcodigo.Enabled = true;
                    txtcodigo.Focus();
                }
                else
                    MessageBox.Show("Error al Eliminar");
                btnmodificar.Enabled = false;
                btneliminar.Enabled = false;
            }
        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            miclase.bloqueaLetras(sender, e);
            if (e.KeyChar == 13) txtdescripcion.Focus();
            {
                List<string> info = c.Consulta(int.Parse(txtcodigo.Text));
                if (info != null)
                {
                    txtdescripcion.Text = info[0];
                    txtpcompra.Text = info[1];
                    txtcodigo.Text = info[2];
                    txtexistencia.Text = info[3];
                    txtsminimo.Text = info[4];
                    txtsmaximo.Text = info[5];
                    txtproveedor.Text = info[6];
                    habilitar(); txtdescripcion.Focus(); txtcodigo.Enabled = false;
                    btnmodificar.Enabled = true; btneliminar.Enabled = true;
                }
                else
                {
                    habilitar(); txtcodigo.Enabled = false; txtdescripcion.Focus();
                    btnguardar.Enabled = true;
                }

            }
        }

        private void txtdescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) txtpcompra.Focus();
            if (e.KeyChar == 27)
            {
                limpiar(); deshabilitar();
                txtcodigo.Enabled = true;
                txtcodigo.Clear(); txtcodigo.Focus();
                btnmodificar.Enabled = false;
                btneliminar.Enabled = false;
                btnguardar.Enabled = false;
            }
        }

        private void txtpcompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            miclase.bloqueaLetras(sender, e);
            if (e.KeyChar == 13) txtpventa.Focus();
        }

        private void txtpventa_KeyPress(object sender, KeyPressEventArgs e)
        {
            miclase.bloqueaLetras(sender, e);
            if (e.KeyChar == 13) txtexistencia.Focus();
        }

        private void txtexistencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            miclase.bloqueaLetras(sender, e);
            if (e.KeyChar == 13) txtsminimo.Focus();
        }

        private void txtsminimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            miclase.bloqueaLetras(sender, e);
            if (e.KeyChar == 13) txtsmaximo.Focus();
        }

        private void txtsmaximo_KeyPress(object sender, KeyPressEventArgs e)
        {
            miclase.bloqueaLetras(sender, e);
            if (e.KeyChar == 13)
            {
                if (btnguardar.Enabled == true)
                    txtproveedor.Focus();
                else
                    btnmodificar.Focus();
            }
            
        }

        private void txtproveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            miclase.bloqueaLetras(sender, e);
            if (e.KeyChar == 13) txtpventa.Focus();
        }

        private void dgarticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Enabled = false;
            habilitar();
            txtcodigo.Text = dgarticulos.CurrentRow.Cells[0].Value.ToString();
            txtdescripcion.Text = dgarticulos.CurrentRow.Cells[1].Value.ToString();
            txtpcompra.Text = dgarticulos.CurrentRow.Cells[2].Value.ToString();
            txtpventa.Text = dgarticulos.CurrentRow.Cells[3].Value.ToString();
            txtexistencia.Text = dgarticulos.CurrentRow.Cells[4].Value.ToString();
            txtsminimo.Text = dgarticulos.CurrentRow.Cells[5].Value.ToString();
            txtsmaximo.Text = dgarticulos.CurrentRow.Cells[6].Value.ToString();
            txtproveedor.Text = traeProveedor(int.Parse(dgarticulos.CurrentRow.Cells[7].Value.ToString()));
            btnmodificar.Enabled = true;
            btneliminar.Enabled = true;
            txtdescripcion.Focus();
        }

        ////////////////////////////////////////////////////////////////////////////////////
        string dato, no;
        int pos, nc;

        private void txtproveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue ==40 ) //Tecla abajo
            {
                lvProv.Focus();
                lvProv.SetSelected(0, true);
            }
        }

        public void obtener_nombre_proveedor()
        {
            try
            {
                dato = lvProv.SelectedItem.ToString();// Quedaria = [1] sabritas
                pos = dato.IndexOf("]") + 2;
                nc = dato.Length - dato.IndexOf(']') - 2;
                no = dato.Substring(pos, nc); // Asignar a la propiedad nombre
                txtproveedor.Text = no; // Actualizar el cuadro de texto

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        private void lvProv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                obtener_nombre_proveedor();
                lvProv.Visible = false;
                if (btnguardar.Enabled) btnguardar.Focus(); else btnmodificar.Focus();
            }
        }

        private void lvProv_Click(object sender, EventArgs e)
        {
            obtener_nombre_proveedor();
            lvProv.Visible = false;
            if (btnguardar.Enabled) btnguardar.Focus(); else btnmodificar.Focus();
        }

        private void txtproveedor_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                lvProv.Visible = false;
                txtproveedor.Focus();
            }
            else
            {
                using (MySqlConnection cnn = new MySqlConnection(miclase.conexion))
                {
                    try
                    {
                        cnn.Open();
                        string sen = "SELECT * FROM proveedores WHERE nombre LIKE @nombre";
                        MySqlCommand com = new MySqlCommand(sen, cnn);
                        com.Parameters.AddWithValue("@nombre", "%" + txtproveedor.Text + "%");

                        using (MySqlDataReader reader = com.ExecuteReader())
                        {
                            lvProv.Visible = reader.HasRows;
                            lvProv.Items.Clear();

                            while (reader.Read())
                            {
                                lvProv.Items.Add($"[{reader.GetValue(0)}] {reader.GetValue(2)}");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        public int traerCodigoProveedor(string np)
        {
            int cp = 0;
            MySqlConnection cnn = new MySqlConnection(miclase.conexion);
            cnn.Open();
            MySqlCommand comando = new MySqlCommand("SELECT codigo FROM proveedores WHERE nombre = '" + np + "'", cnn);
            MySqlDataReader myreader = comando.ExecuteReader();
            comando.Dispose();
            if (myreader.HasRows)
            {
                while (myreader.Read())
                {
                    cp = Int32.Parse(myreader["codigo"].ToString());
                }
            }
            myreader.Close();
            cnn.Close();
            cnn.Dispose();
            return cp;
        }


        public string traeProveedor(int cp)
        {
            string nom = "";
            MySqlConnection cnn = new MySqlConnection(miclase.conexion);
            cnn.Open();
            MySqlCommand comando = new MySqlCommand("Select nombre from proveedores where codigo=" + cp , cnn);
            MySqlDataReader myreader = comando.ExecuteReader();
            comando.Dispose();
            if (myreader.HasRows)
                while (myreader.Read())
                    nom = myreader["nombre"].ToString();
            myreader.Close(); cnn.Close(); cnn.Dispose();
            return nom;
        }
    }
}