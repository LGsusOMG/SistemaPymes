using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SistemaPymes
{
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
            
        }

        ClsVentas v = new ClsVentas();
        float supago, cambio, netoapagar;
        const float IVA = 0.16f;
        
        public void limpiarClientes()
        {
            txtCodigoCliente.Clear();
            txtrfc.Clear();
            txtnombre.Clear();
            txtdireccion.Clear();
            txttelefono.Clear();
        }

        public void limpiarArticulos()
        {
            txtCodigoArticulo.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
            
        }

        public void deshabilitar()
        {
            txtrfc.Enabled = true;
            txtnombre.Enabled = true;
            txtdireccion.Enabled = true;
            txttelefono.Enabled = true;
        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            miclase.bloqueaLetras(sender, e);
            if (e.KeyChar == 27) this.Close();
            if (e.KeyChar == 13 && txtCodigoCliente.Text.Length>0)
            {
                List<string> info = v.ConsultaClientes(int.Parse(txtCodigoCliente.Text));
                if (info != null)
                {
                    txtrfc.Text = info[0];
                    txtnombre.Text = info[1];
                    txtdireccion.Text = info[2];
                    txttelefono.Text = info[3];
                }
                gbArticulos.Enabled = true;
                gbSuCompra.Enabled = true;
                gbCliente.Enabled = false;
                txtCodigoArticulo.Focus();
            }
        }

        private void frmVentas_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmmenu fm = new frmmenu();
            fm.Show();
        }

        private void txtCodigoArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            miclase.bloqueaLetras(sender, e);

            if (e.KeyChar == 27) // Tecla Esc
            {
                float total = 0;

                if (lblCodigo.Items.Count > 0)
                {
                    for (int i = 0; i < lblParcial.Items.Count; i++) 
                    {
                        total += float.Parse(lblParcial.Items[i].ToString()); // Simplificado la suma
                    }

                    lblTotal.Text = total.ToString();
                    lblIVA.Text = (total * IVA).ToString(); // Calculado directamente usando 'total'
                    lblNetoaPagar.Text = (total + float.Parse(lblIVA.Text)).ToString();
                    txtSuPago.Focus();
                }
                else
                {
                    gbCliente.Enabled = true;
                    limpiarClientes();
                    txtCodigoCliente.Focus();
                    deshabilitar();
                }
            }

            if (e.KeyChar == 13 && txtCodigoArticulo.Text.Length > 0) // Tecla Enter
            {
                List<string> info = v.ConsultaArticulos(int.Parse(txtCodigoArticulo.Text));

                if (info != null && info.Count >= 2) // Añadido control para asegurarse de que hay suficiente información
                {
                    txtCantidad.Enabled = true;
                    txtDescripcion.Text = info[0];
                    txtPrecio.Text = info[1];
                    txtCantidad.Focus();
                }
            }
        }


        private void txtCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            miclase.bloqueaLetras(sender, e);
            if (e.KeyChar == 13 && txtCantidad.Text.Length > 0)
            {
                lblCodigo.Items.Add(txtCodigoArticulo.Text);
                lblCantidad.Items.Add(txtCantidad.Text);
                lblDescipcion.Items.Add(txtDescripcion.Text);
                lblPrecio.Items.Add(txtPrecio.Text);
                float cant = float.Parse(txtCantidad.Text);
                float pu = float.Parse(txtPrecio.Text);
                lblParcial.Items.Add(cant * pu);
                limpiarArticulos();
                txtCodigoArticulo.Focus();
                txtCantidad.Enabled = false;
            }
        }
        public void imprimirTicketContado()
        {

        }


        private void txtSuPago_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                supago = float.Parse(txtSuPago.Text);
                netoapagar = float.Parse(lblNetoaPagar.Text);
                cambio = supago - netoapagar;
                if (cambio >= 0)
                {
                    lblCambio.Visible = true;
                    txtCambio.Visible = true;
                    txtCambio.Text = cambio.ToString();
                    imprimirTicketContado();
                    // nueva venta

                    pbTienda.Visible = true;
                    txtCodigoArticulo.Clear();
                    txtCodigoArticulo.Focus();

                }
                else
                {
                    if(int.Parse(txtCodigoCliente.Text) != 0)
                    {
                        btnCredito.Visible = true;
                        btnCancelar.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("No se puede vender a credito a publico en general","ERROR");
                        txtSuPago.Clear();
                        txtSuPago.Focus();
                    }
                }

            }
        }

        public void imprimirTicketCredito()
        {

        }

        private void btnCredito_Click(object sender, EventArgs e)
        {
            imprimirTicketCredito();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCredito.Visible = false;
            btnCancelar.Visible = false;
            txtSuPago.Focus();
            txtSuPago.Clear();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFolio.Text = miclase.FolioFactura().ToString();
        }
    }
}
