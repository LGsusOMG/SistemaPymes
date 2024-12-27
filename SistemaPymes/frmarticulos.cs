using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaPymes
{
    public partial class frmArticulos : Form
    {
        public frmArticulos()
        {
            InitializeComponent();
        }

        ClsArticulos c = new ClsArticulos();

        private void btnsalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ActualizaDG()
        {
            dgarticulos.DataSource = c.Reporte();
        }

        public void NuevoRegistro()
        {
            deshabilitar();
            btnguardar.Enabled = false;
            btneliminar.Enabled = false;
            btnmodificar.Enabled = false;
        }

        private void frmarticulos_Load(object sender, EventArgs e)
        {
            txtcodigo.Text = miclase.FolioSiguiente("codigo", "articulos").ToString();

            ActualizaDG();
            NuevoRegistro();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                c.codigo = int.Parse(txtcodigo.Text);
                c.descripcion = txtdescripcion.Text;
                c.pcompra = float.Parse(txtpcompra.Text);
                c.pventa = float.Parse(txtpventa.Text);
                c.existencia = float.Parse(txtexistencia.Text);
                c.sminimo = float.Parse(txtsminimo.Text);
                c.smaximo = float.Parse(txtsmaximo.Text);

                if (c.Guardar() == true)
                {
                    ActualizaDG();
                    limpiar();
                    deshabilitar();
                    MessageBox.Show("Artículo guardado con éxito");
                    txtcodigo.Enabled = true;
                    txtcodigo.Focus();
                    txtcodigo.Text = miclase.FolioSiguiente("codigo", "articulos").ToString();
                }
                else
                {
                    MessageBox.Show("Error al guardar el artículo");
                }
                btnguardar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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
        }

        public void deshabilitar()
        {
            txtdescripcion.Enabled = false;
            txtpcompra.Enabled = false;
            txtpventa.Enabled = false;
            txtexistencia.Enabled = false;
            txtsminimo.Enabled = false;
            txtsmaximo.Enabled = false;
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
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                c.codigo = int.Parse(txtcodigo.Text);
                c.descripcion = txtdescripcion.Text;
                c.pcompra = float.Parse(txtpcompra.Text);
                c.pventa = float.Parse(txtpventa.Text);
                c.existencia = float.Parse(txtexistencia.Text);
                c.sminimo = float.Parse(txtsminimo.Text);
                c.smaximo = float.Parse(txtsmaximo.Text);

                if (c.Modificar() == true)
                {
                    ActualizaDG();
                    limpiar();
                    deshabilitar();
                    MessageBox.Show("Artículo modificado con éxito");
                    txtcodigo.Enabled = true;
                    txtcodigo.Focus();
                    txtcodigo.Text = miclase.FolioSiguiente("codigo", "articulos").ToString();
                }
                else
                {
                    MessageBox.Show("Error al modificar el artículo");
                }
                btnmodificar.Enabled = false;
                btneliminar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
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
                        txtcodigo.Text = miclase.FolioSiguiente("codigo", "articulos").ToString();
                    }
                    else
                        MessageBox.Show("Error al Eliminar");
                    btnmodificar.Enabled = false;
                    btneliminar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            miclase.bloqueaLetras(sender, e);
            if (e.KeyChar == 27) this.Close();
            if (e.KeyChar == 13)
            {
                List<string> datos;
                try
                {
                    datos = c.Consulta(txtcodigo.Text);
                    if (datos != null)
                    {
                        txtdescripcion.Text = datos[0];
                        txtpcompra.Text = datos[1];
                        txtpventa.Text = datos[2];
                        txtexistencia.Text = datos[3];
                        txtsminimo.Text = datos[4];
                        txtsmaximo.Text = datos[5];
                        btnmodificar.Enabled = true;
                        btneliminar.Enabled = true;
                    }
                    else
                    {
                        btnguardar.Enabled = true;
                    }
                    habilitar();
                    txtcodigo.Enabled = false;
                    txtdescripcion.Focus();
                }
                catch
                {
                    MessageBox.Show("Error al consultar el artículo");
                }
            }
        }

        private void txtdescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) txtpcompra.Focus();
            if (e.KeyChar == 27)
            {
                limpiar(); 
                deshabilitar();
                txtcodigo.Enabled = true;
                txtcodigo.Clear(); 
                txtcodigo.Focus();
                btnmodificar.Enabled = false;
                btneliminar.Enabled = false;
                btnguardar.Enabled = false;
            }
        }

        private void txtpcompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            miclase.bloqueaLetrasPermitirPuntosyComas(sender, e);
            if (e.KeyChar == 13) txtpventa.Focus();
            if (e.KeyChar == 27)
            {
                txtpcompra.Clear();
                txtdescripcion.Focus();
            }
        }

        private void txtpventa_KeyPress(object sender, KeyPressEventArgs e)
        {
            miclase.bloqueaLetrasPermitirPuntosyComas(sender, e);
            if (e.KeyChar == 13) txtexistencia.Focus();
            if (e.KeyChar == 27)
            {
                txtpventa.Clear();
                txtpcompra.Focus();
                
            }
        }

        private void txtexistencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            miclase.bloqueaLetrasPermitirPuntosyComas(sender, e);
            if (e.KeyChar == 13) txtsminimo.Focus();
            if (e.KeyChar == 27)
            {
                txtexistencia.Clear();
                txtpventa.Focus();
            }
        }

        private void txtsminimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            miclase.bloqueaLetrasPermitirPuntosyComas(sender, e);
            if (e.KeyChar == 13) txtsmaximo.Focus();
            if (e.KeyChar == 27)
            {
                txtsminimo.Clear();
                txtexistencia.Focus();
            }
        }

        private void txtsmaximo_KeyPress(object sender, KeyPressEventArgs e)
        {
            miclase.bloqueaLetrasPermitirPuntosyComas(sender, e);
            if (e.KeyChar == 13)
            {
                btnmodificar.Focus();
            }
            if (e.KeyChar == 27)
            {
                txtsmaximo.Clear();
                txtsminimo.Focus();
            }
        }

        private void dgarticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
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
                btnmodificar.Enabled = true;
                btneliminar.Enabled = true;
                txtdescripcion.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtproveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (btnguardar.Enabled) btnguardar.Focus(); else btnmodificar.Focus();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}