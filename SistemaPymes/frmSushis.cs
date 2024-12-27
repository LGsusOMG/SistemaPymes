using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPymes
{
    public partial class frmSushis : Form
    {
        public frmSushis()
        {
            InitializeComponent();
        }

        ClsSushis c = new ClsSushis();

        public void ActualizaDG()
        {
            dgSushis.DataSource = c.Reporte();
        }

        public void NuevoRegistro()
        {
            deshabilitar();
            btnguardar.Enabled = false;
            btneliminar.Enabled = false;
            btnmodificar.Enabled = false;
        }

        public void habilitar()
        {
            txtNombreSushi.Enabled = true;
            txtdescripcion.Enabled = true;
            txtPrecio.Enabled = true;
        }

        public void deshabilitar()
        {
            txtNombreSushi.Enabled= false;
            txtdescripcion.Enabled = false;
            txtPrecio.Enabled = false;
        }

        public void limpiar()
        {
            txtcodigo.Clear();
            txtNombreSushi.Clear();
            txtdescripcion.Clear();
            txtPrecio.Clear();
        }

        private void frmSushis_Load(object sender, EventArgs e)
        {
            txtcodigo.Text = miclase.FolioSiguiente("codigo", "sushis").ToString();
            ActualizaDG();
            NuevoRegistro();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                c.codigo = int.Parse(txtcodigo.Text);
                c.nombre = txtNombreSushi.Text;
                c.descripcion = txtdescripcion.Text;
                c.precio = float.Parse(txtPrecio.Text);
                if (c.Guardar() == true)
                {
                    ActualizaDG();
                    limpiar();
                    deshabilitar();
                    MessageBox.Show("Guardado");
                    txtcodigo.Enabled = true;
                    txtcodigo.Focus();
                    txtcodigo.Text = miclase.FolioSiguiente("codigo", "sushis").ToString();
                    ActualizaDG();
                }
                else
                    MessageBox.Show("Error al Guardar");
                btnguardar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtcodigo.Text, out int codigo) &&
                    float.TryParse(txtPrecio.Text, out float precio))
                {
                    c.codigo = codigo;
                    c.nombre = txtNombreSushi.Text;
                    c.descripcion = txtdescripcion.Text;
                    c.precio = precio;

                    if (c.Modificar())
                    {
                        ActualizaDG();
                        limpiar();
                        deshabilitar();
                        MessageBox.Show("Modificado");
                        txtcodigo.Enabled = true;
                        txtcodigo.Focus();
                        txtcodigo.Text = miclase.FolioSiguiente("codigo", "sushis").ToString();
                        ActualizaDG();
                    }
                    else
                    {
                        MessageBox.Show("Error al Modificar");
                    }
                    btnmodificar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese valores válidos.");
                }
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
                if (int.TryParse(txtcodigo.Text, out int codigo))
                {
                    DialogResult opcion = MessageBox.Show("Realmente desea Eliminarlo?", "Eliminar Registro",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (opcion == DialogResult.Yes)
                    {
                        if (c.Eliminar(codigo))
                        {
                            ActualizaDG();
                            limpiar();
                            deshabilitar();
                            MessageBox.Show("Eliminado");
                            txtcodigo.Enabled = true;
                            txtcodigo.Focus();
                            txtcodigo.Text = miclase.FolioSiguiente("codigo", "sushis").ToString();
                            ActualizaDG();
                        }
                        else
                        {
                            MessageBox.Show("Error al Eliminar");
                        }
                        btnmodificar.Enabled = false;
                        btneliminar.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un código válido.");
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
                try
                {
                    List<string> datos = c.Consulta(txtcodigo.Text);
                    if (datos != null)
                    {
                        txtNombreSushi.Text = datos[0];
                        txtdescripcion.Text = datos[1];
                        txtPrecio.Text = datos[2];
                        btnmodificar.Enabled = true;
                        btneliminar.Enabled = true;
                    }
                    else
                    {
                        btnguardar.Enabled = true;
                    }
                    habilitar();
                    txtcodigo.Enabled = false;
                    txtNombreSushi.Focus();
                }
                catch
                {
                    MessageBox.Show("Error al consultar el Sushi");
                }
            }
        }

        private void txtNombreSushi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) txtdescripcion.Focus();
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

        private void txtdescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) txtPrecio.Focus();
            if (e.KeyChar == 27)
            {
                limpiar();
                deshabilitar();
                txtNombreSushi.Enabled = true;
                txtNombreSushi.Clear();
                txtNombreSushi.Focus();
                btnmodificar.Enabled = false;
                btneliminar.Enabled = false;
                btnguardar.Enabled = false;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            miclase.bloqueaLetrasPermitirPuntosyComas(sender, e);
            if (e.KeyChar == 13)
            {
                if (btnguardar.Enabled) btnguardar.Focus(); else btnmodificar.Focus();
            }
            if (e.KeyChar == 27)
            {
                txtPrecio.Clear();
                txtdescripcion.Focus();
            }
        }

        private void dgSushis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtcodigo.Enabled = false;
                habilitar();
                txtcodigo.Text = dgSushis.CurrentRow.Cells[0].Value.ToString();
                txtNombreSushi.Text = dgSushis.CurrentRow.Cells[1].Value.ToString();
                txtdescripcion.Text = dgSushis.CurrentRow.Cells[2].Value.ToString();
                txtPrecio.Text = dgSushis.CurrentRow.Cells[3].Value.ToString();
                btnmodificar.Enabled = true;
                btneliminar.Enabled = true;
                txtdescripcion.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnsalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
