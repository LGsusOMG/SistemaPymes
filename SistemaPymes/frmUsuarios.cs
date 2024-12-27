using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static SistemaPymes.miclase;

namespace SistemaPymes
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }


        ClsUsuarios c = new ClsUsuarios();

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ActualizaDG()
        {
            dgusuarios.DataSource = c.Reporte();
        }

        private void frmusuarios_Load(object sender, EventArgs e)
        {
            ActualizaDG();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

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
                limpiar(); 
                deshabilitar();
                txtusuario.Enabled = true;
                txtusuario.Focus();
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
            if (e.KeyChar == 27)
            {
                txtrol.Clear();
                txtclave.Focus();
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

        }

        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27) this.Close();
            if (e.KeyChar == 13) 
            {
                List<string> info = c.Consulta(txtusuario.Text);
                if (info != null)
                {
                    txtclave.Text = info[0];
                    txtrol.Text = info[1];                
                    habilitar(); 
                    txtclave.Focus(); 
                    txtusuario.Enabled = false;
                    btnmodificar.Enabled = true; 
                    btneliminar.Enabled = true;
                }
                else
                {
                    habilitar(); 
                    txtusuario.Enabled = false; 
                    txtclave.Focus();
                    btnguardar.Enabled = true;
                }
            }
        }
    }
}
