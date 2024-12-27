using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
 

namespace SistemaPymes
{
    public partial class frmclientes : Form
    {
        public frmclientes()
        {
            InitializeComponent();
        }

        ClsCliente c = new ClsCliente();

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmclientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmmenu fm = new frmmenu();
            fm.Show();
        }

        public void ActualizaDG()
        {
            dgclientes.DataSource = c.Reporte();
        }

        private void frmclientes_Load(object sender, EventArgs e)
        {
            txtcodigo.Text = miclase.FolioSiguiente("codigo", "clientes").ToString();
            ActualizaDG();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            c.codigo = int.Parse(txtcodigo.Text);
            c.rfc = txtrfc.Text;
            c.nombre = txtnombre.Text;
            c.direccion = txtdireccion.Text;
            c.telefono = txttelefono.Text;
            c.email = txtemail.Text;
            c.puntos = int.Parse(txtpuntos.Text);
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
            txtrfc.Enabled = true;
            txtnombre.Enabled = true;
            txtdireccion.Enabled = true;
            txttelefono.Enabled = true;
            txtemail.Enabled = true;
            txtpuntos.Enabled = true;        
        }

        public void deshabilitar()
        {
            txtrfc.Enabled = true;
            txtnombre.Enabled = true;
            txtdireccion.Enabled = true;
            txttelefono.Enabled = true;
            txtemail.Enabled = true;
            txtpuntos.Enabled = true;
        }

        public void limpiar()
        {
            txtcodigo.Clear();
            txtrfc.Clear();            
            txtnombre.Clear();
            txtdireccion.Clear();
            txttelefono.Clear();
            txtemail.Clear();
            txtpuntos.Clear();
        }
        private void dgclientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Enabled = false;
            habilitar();
            txtcodigo.Text = dgclientes.CurrentRow.Cells[0].Value.ToString();
            txtrfc.Text=dgclientes.CurrentRow.Cells[1].Value.ToString();
            txtnombre.Text=dgclientes.CurrentRow.Cells[2].Value.ToString();
            txtdireccion.Text = dgclientes.CurrentRow.Cells[3].Value.ToString();
            txttelefono.Text = dgclientes.CurrentRow.Cells[4].Value.ToString();
            txtemail.Text = dgclientes.CurrentRow.Cells[5].Value.ToString();
            txtpuntos.Text = dgclientes.CurrentRow.Cells[6].Value.ToString();
            btnmodificar.Enabled = true;
            btneliminar.Enabled = true;
            txtrfc.Focus();
        }

        private void txtrfc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13) txtnombre.Focus();
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

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) txtdireccion.Focus();
        }

        private void txtdireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) txttelefono.Focus();
        }

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) txtemail.Focus();
        }

        private void txtemail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) txtpuntos.Focus();
        }

        private void txtpuntos_KeyPress(object sender, KeyPressEventArgs e)
        {
            miclase.bloqueaLetras(sender, e);
            if (e.KeyChar == 13)
            {
                if (btnguardar.Enabled == true)
                    btnguardar.Focus();
                else
                    btnmodificar.Focus();
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {    
            c.codigo = int.Parse(txtcodigo.Text);
            c.rfc = txtrfc.Text;
            c.nombre = txtnombre.Text;
            c.direccion = txtdireccion.Text;
            c.telefono = txttelefono.Text;
            c.email = txtemail.Text;
            c.puntos = int.Parse(txtpuntos.Text);
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
            if (e.KeyChar == 13)
            {
                List<string> info = c.Consulta(int.Parse(txtcodigo.Text));
                if (info != null) // si la variable info tiene datos
                {
                    txtrfc.Text = info[0];
                    txtnombre.Text = info[1];
                    txtdireccion.Text = info[2];
                    txttelefono.Text = info[3];
                    txtemail.Text = info[4];
                    txtpuntos.Text = info[5];
                    habilitar(); txtrfc.Focus(); txtcodigo.Enabled = false;
                    btnmodificar.Enabled = true; btneliminar.Enabled = true;
                }
                else
                {
                    habilitar(); txtcodigo.Enabled = false; txtrfc.Focus();
                    btnguardar.Enabled = true;
                }

            }
        }
    }
}
