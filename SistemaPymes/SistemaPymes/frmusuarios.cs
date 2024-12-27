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
    public partial class frmusuarios : Form
    {
        public frmusuarios()
        {
            InitializeComponent();
        }

        ClsUsuarios c = new ClsUsuarios();

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void frmusuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmmenu fm = new frmmenu();
            fm.Show();
        }

        public void ActualizaDG()
        {
            dgusuarios.DataSource = c.Reporte();
        }

        private void frmusuarios_Load(object sender, EventArgs e)
        {
            txtusuario.Text = miclase.FolioSiguiente("usuario", "usuarios").ToString();
            ActualizaDG();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            c.usuario = txtusuario.Text;
            c.clave = txtclave.Text;
            c.rol = txtrol.Text;
            if (c.Guardar() == true)
            {
                ActualizaDG();
                limpiar();
                deshabilitar();
                MessageBox.Show("Guardado");
                txtusuario.Enabled = true;
                txtusuario.Focus();
            }
            else
                MessageBox.Show("Error al Guardar");
            btnguardar.Enabled = false;
        }

        public void habilitar()
        {
            txtusuario.Enabled = true;
            txtclave.Enabled = true;
            txtrol.Enabled = true;
        }

        public void deshabilitar()
        {
            txtusuario.Enabled = true;
            txtclave.Enabled = true;
            txtrol.Enabled = true;
        }

        public void limpiar()
        {
            txtusuario.Clear();
            txtclave.Clear();
            txtrol.Clear();
        }
     
        private void dgusuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtusuario.Enabled = false;
            habilitar();
            txtusuario.Text = dgusuarios.CurrentRow.Cells[0].Value.ToString();
            txtclave.Text = dgusuarios.CurrentRow.Cells[1].Value.ToString();
            txtrol.Text = dgusuarios.CurrentRow.Cells[2].Value.ToString();
            btnmodificar.Enabled = true;
            btneliminar.Enabled = true;
            txtclave.Focus();
        }

        private void txtclave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) txtrol.Focus();
            if (e.KeyChar == 27)
            {
                limpiar(); deshabilitar();
                txtusuario.Enabled = true;
                txtusuario.Clear(); txtusuario.Focus();
                btnmodificar.Enabled = false;
                btneliminar.Enabled = false;
                btnguardar.Enabled = false;
            }
        }

        private void txtrol_KeyPress(object sender, KeyPressEventArgs e)
        {
            miclase.bloqueaNumeros(sender, e);
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
            c.usuario = txtusuario.Text;
            c.clave = txtclave.Text;
            c.rol = txtrol.Text;
            if (c.Modificar() == true)
            {
                ActualizaDG();
                limpiar();
                deshabilitar();
                MessageBox.Show("Modificado");
                txtusuario.Enabled = true;
                txtusuario.Focus();
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
                if (c.Eliminar(txtusuario.Text) == true)
                {
                    ActualizaDG();
                    limpiar();
                    deshabilitar();
                    MessageBox.Show("Eliminado");
                    txtusuario.Enabled = true;
                    txtusuario.Focus();
                }
                else
                    MessageBox.Show("Error al Eliminar");
                btnmodificar.Enabled = false;
                btneliminar.Enabled = false;
            }
        }

        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            miclase.bloqueaNumeros(sender, e);
            if (e.KeyChar == 13) 
            {
                List<string> info = c.Consulta(txtusuario.Text);
                if (info != null)
                {
                    txtclave.Text = info[0];
                    txtrol.Text = info[1];                
                    habilitar(); txtclave.Focus(); txtusuario.Enabled = false;
                    btnmodificar.Enabled = true; btneliminar.Enabled = true;
                }
                else
                {
                    habilitar(); txtusuario.Enabled = false; txtclave.Focus();
                    btnguardar.Enabled = true;
                }
            }
        }
    }
}
