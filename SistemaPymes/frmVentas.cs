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

            listBoxes.Add(lblCodigo);
            listBoxes.Add(lblCantidad);
            listBoxes.Add(lblDescipcion);
            listBoxes.Add(lblPrecio);
            listBoxes.Add(lblParcial);

            lblFolio.Text = miclase.FolioSiguiente("factura", "encabezado").ToString();
        }

        private List<ListBox> listBoxes = new List<ListBox>();

        private void Eliminar(object sender, EventArgs e)
        {
            ListBox listBox = (ListBox)sender;

            // Verificar si hay un elemento seleccionado
            if (listBox.SelectedItem != null)
            {
                int selectedIndex = listBox.SelectedIndex;

                // Eliminar el elemento seleccionado del ListBox actual
                listBox.Items.RemoveAt(selectedIndex);

                // Eliminar el mismo índice de los otros ListBox en la lista
                foreach (var otherListBox in listBoxes)
                {
                    if (otherListBox != listBox)
                    {
                        otherListBox.Items.RemoveAt(selectedIndex);
                    }
                }
            }
        }

        public void limpiaventa()
        {
            lblCodigo.Items.Clear();
            lblCantidad.Items.Clear();
            lblDescipcion.Items.Clear();
            lblPrecio.Items.Clear();
            lblParcial.Items.Clear();
            txtSuPago.Clear();
            txtSuPago.Visible = false;
            lblsupag.Visible = false;
            txtCodigoArticulo.Enabled = false;
            txtCodigoArticulo.Enabled = true;
            txtCodigoArticulo.Focus();

        }

        public void iniciarVenta()
        {
            limpiarClientes();
            limpiaventa();
            txtCodigoArticulo.Enabled = true;
            txtCodigoArticulo.Focus();
            lblFolio.Text = miclase.FolioSiguiente("factura", "encabezado").ToString();
        }

        public void limpiarClientes()
        {
            txtCodigoArticulo.Clear();
            txtnombre.Clear();
        }

        public void limpiarArticulos()
        {
            txtCodigoArticulo.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();

        }

        ClsVentas v = new ClsVentas();

        string cliente;
        float supago, cambio, netoapagar, cantidad, exist, total, utilida, arqueoventa, precio;
        const float IVA = 0.16f;
        string fecha = DateTime.Now.ToString("dd/MM/yyyy");
        string rfc, telefono, direccion;

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            miclase.bloqueaLetras(sender, e);
            if (e.KeyChar == 27) this.Close();

            if (e.KeyChar == 13)
            {
                List<string> info = v.ConsultaClientes(int.Parse(txtCodigoCliente.Text));
                cliente = txtCodigoCliente.Text;
                if (info != null)
                {
                    rfc = info[0];
                    txtnombre.Text = info[1];
                    direccion = info[2];
                    telefono = info[3];
                    txtCodigoArticulo.Enabled = true;
                    txtDescripcion.Enabled = true;
                    txtCodigoArticulo.Focus();
                    txtCodigoCliente.Enabled = false;
                    txtnombre.Enabled = false;
                }
                else
                {
                    MessageBox.Show("El código de cliente no existe. Por favor, inténtelo de nuevo.");
                    txtCodigoArticulo.Clear();
                    txtCodigoArticulo.Focus();
                }
            }
        }

        private void txtnombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCodigoArticulo.Enabled = true;
                txtDescripcion.Enabled = true;
                txtCodigoArticulo.Enabled = false;
                txtnombre.Enabled = false;
                txtCodigoArticulo.Focus();
            }
        }

        private void txtnombre__TextChanged(object sender, EventArgs e)
        {
            AutocompletarClientes();
        }

        private void AutocompletarClientes()
        {
            // Autocompletar clientes con el metodo de autocompletado de nombre
            string nombre = txtnombre.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                txtCodigoCliente.Clear();
            }

            List<string> datos = v.ConsultaPorNombre(nombre);

            if (datos != null && datos.Count == 3)
            {
                txtCodigoCliente.Text = datos[0];
                rfc = datos[1];
                direccion = datos[2];
                telefono = datos[3];
            }
            else
            {
                txtCodigoArticulo.Clear();
                txtPrecio.Clear();
            }
        }

        private void txtCodigoArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            miclase.bloqueaLetras(sender, e);
            // string codigo = txtCodigoArticulo.Text;
            if(e.KeyChar == 13 && txtCodigoArticulo.Text != "" && txtCodigoArticulo.Text != "0")
            {
                List<string> info = v.ConsultaArticulos(int.Parse(txtCodigoArticulo.Text));

                if (info != null)
                {
                    txtCodigoArticulo.Enabled = false;
                    txtCantidad.Enabled = true;
                    txtDescripcion.Enabled = false;
                    txtDescripcion.Text = info[0];
                    txtPrecio.Text = info[1];
                    exist = float.Parse(info[2]);
                    txtCantidad.Focus();
                }
            } 

            if(e.KeyChar == 27)
            {
                if (lblCodigo.Items.Count > 0)
                {
                    //Finaliza venta
                    iniciarVenta();
                    txtCodigoArticulo.Enabled = false;
                    txtDescripcion.Enabled = false;
                    float sub = 0;
                    for(int i = 0; i < lblParcial.Items.Count; i++)
                    {
                        sub += float.Parse(lblParcial.Items[i].ToString());
                    }
                    float iva = sub * IVA;
                    lblTotal.Text = (sub + iva).ToString();
                    txtSuPago.Focus();
                }
                else
                {
                    //Regresamos a campturar nuevo cliente
                    txtDescripcion.Enabled = false;
                    txtCodigoArticulo.Enabled = false;
                    txtCodigoArticulo.Clear();
                    txtnombre.Clear();
                    txtCodigoArticulo.Enabled = true;
                    txtCodigoArticulo.Focus();
                }
            }
        }

        private void txtCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            miclase.bloqueaLetrasPermitirPuntosyComas(sender, e);

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true; // Marcar el evento como manejado para evitar caracteres no válidos
            }

            if (e.KeyChar == 13 && !string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                if (float.TryParse(txtCantidad.Text, out cantidad) && cantidad > 0)
                {
                    float existencia = exist;

                    if (cantidad > existencia)
                    {
                        MessageBox.Show("La cantidad no puede ser mayor que la existencia.");
                        txtCantidad.Clear();
                        txtCantidad.Focus();
                        return;
                    }

                    lblCodigo.Items.Add(txtCodigoArticulo.Text);
                    lblCantidad.Items.Add(cantidad);
                    lblDescipcion.Items.Add(txtDescripcion.Text);
                    lblPrecio.Items.Add(txtPrecio.Text);
                    precio = float.Parse(txtPrecio.ToString());
                    lblParcial.Items.Add(cantidad * precio);

                    limpiarArticulos();
                    txtCodigoArticulo.Enabled = true;
                    txtCodigoArticulo.Focus();
                    txtCantidad.Enabled = false;
                    txtDescripcion.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un número válido y mayor que cero en el campo de cantidad.");
                    txtCantidad.Clear();
                    txtCantidad.Focus();
                }
            }

            if (e.KeyChar == 27)
            {
                txtCantidad.Clear();
                txtDescripcion.Clear();
                txtPrecio.Clear();
                txtCodigoArticulo.Clear();
                txtCodigoArticulo.Enabled = true;
                txtCodigoArticulo.Focus();
                txtDescripcion.Enabled = true;
            }
            else
            {
                txtCantidad.Focus();
            }
        }       

        private void txtSuPago_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (float.TryParse(txtSuPago.Text, out  supago) && float.TryParse(lblTotal.Text, out  netoapagar))
                {
                    cambio = supago - netoapagar;
                    if (cambio >= 0)
                    {
                        btnRealizarPago.Focus();
                    }
                    else
                    {
                        MessageBox.Show("No se puede vender a crédito", "ERROR");
                        txtSuPago.Clear();
                        txtSuPago.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese montos válidos", "ERROR");
                    txtSuPago.Clear();
                    txtSuPago.Focus();
                }
            }

            if(e.KeyChar == 27)
            {
                btnCancelar.Visible = true;
                btnCancelar.Focus();
            }
        }

        public void detalles()
        {
            for (int i = 0; i < lblCodigo.Items.Count; i++)
            {
                v.codigo = int.Parse(lblCodigo.Items[i].ToString());
                v.cantidad = float.Parse(lblCantidad.Items[i].ToString());
                v.descripcion = lblDescipcion.Items[i].ToString();
                v.pventa = float.Parse(lblParcial.Items[i].ToString());
            }
            v.factura = int.Parse(lblFolio.Text);
            // Guardar Detalle
            v.GuardaDetalles();
        }

        public void arqueo()
        {
            float arqueo = ClsArqueo.arqueoInicial;
            float total = float.Parse(lblTotal.Text);
            arqueoventa = arqueo + total; 
            ClsArqueo.arqueoventas = arqueoventa;
        }

        private void btnRealizarPago_Click(object sender, EventArgs e)
        {
            lblCambio.Text = cambio.ToString("C"); // Formatear como moneda

            MessageBox.Show($"Cambio: {cambio.ToString("C")}");

            // Guardar Encabezado
            encabezado();

            // Guardar Detalle
            detalles();

            // Guardar Caja
            arqueo();
            Utilidad();
            caja();

            // Descuenta Existencia
            descuentaexistencia();

            // Imprimir Ticket
            imprimirTicket();

            // Nueva Venta
            limpiarClientes();
            limpiaventa();
            txtCodigoArticulo.Enabled = true;
            txtCodigoArticulo.Focus();
            lblFolio.Text = miclase.FolioSiguiente("factura", "encabezado").ToString();
        }

        public void Utilidad()
        {
            utilida = 0; // Inicializar la variable utilida antes del bucle

            for (int i = 0; i < lblCodigo.Items.Count; i++)
            {
                int codigo = int.Parse(lblCodigo.Items[i].ToString());
                float venta = float.Parse(lblPrecio.Items[i].ToString()); 
                List<float> compra = v.ConsultaCompraVenta(codigo);

                // Accediendo al primer elemento de la lista 'compra'
                float compraFloat = compra.Count > 0 ? compra[0] : 0;

                float resta = venta - compraFloat; // Resta de venta y compra
                utilida += resta; // Agregando la resta a la utilidad
            }
        }

        public void caja()
        {
            v.factura = int.Parse(lblFolio.Text);
            v.fecha = DateTime.Parse(fecha);
            v.total = float.Parse(lblTotal.Text);
            ClsArqueo.venta = float.Parse(lblTotal.Text);

            int numerocajasuc;
            if (int.TryParse(ClsArqueo.NumCaja, out numerocajasuc))
                v.numerocajasuc = numerocajasuc; else { v.numerocajasuc = 0;}

            v.usuario = ClsMenu.rol;

            // Guardar en Caja
            v.GuardaEnCaja();
        }

        public void descuentaexistencia()
        {
            for (int i = 0; i < lblCodigo.Items.Count; i++)
            {
                v.codigo = int.Parse(lblCodigo.Items[i].ToString());
                v.cantidad = float.Parse(lblCantidad.Items[i].ToString());

                v.existencia = exist;
                // Descontar Existencia 
                v.DescuentaExistencia();
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea reiniciar la compra?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Nueva Venta
                iniciarVenta();
            }
        }

        public void encabezado()
        {
            v.factura = int.Parse(lblFolio.Text);
            v.nombre = txtnombre.Text;
            v.NumCli = txtCodigoArticulo.Text;
            v.total = float.Parse(lblTotal.Text);
            v.rfc = rfc;
            v.fecha = DateTime.Parse(fecha);
            // Guardar Encabezado
            v.GuardaEncabezado();
        }

        public void imprimirTicket()
        {
            ClsTicket tik = new ClsTicket();
            bool DesglozarIVA = true;
            tik.HeaderImage = Image.FromFile(ClsEmpresa.logoticket);
            tik.AddHeaderLine("");
            tik.AddSubHeaderLine(ClsEmpresa.empresa);
            tik.AddSubHeaderLine(ClsEmpresa.direccion);
            tik.AddSubHeaderLine(ClsEmpresa.telefono);
            tik.AddHeaderLine("");
            tik.AddSubHeaderLine($"Folio: {lblFolio.Text}");
            tik.AddSubHeaderLine($"Fecha: {DateTime.Now.ToString("dd/MM/yyyy")} Hora: {DateTime.Now.ToString("hh:mm:ss")}");
            tik.AddHeaderLine("");
            tik.AddSubHeaderLine($"Caja: {ClsArqueo.NumCaja}");
            tik.AddSubHeaderLine($"Cliente: {cliente}");
            tik.AddHeaderLine("");

            total = float.Parse(lblTotal.Text);

            for (int i = 0; i < lblCodigo.Items.Count; i++)
            {
                tik.AddItem(lblDescipcion.Items[i].ToString(), lblCantidad.Items[i].ToString(), lblParcial.Items[i].ToString());
            }

            if (DesglozarIVA)
            {
                float montoIVA = total * IVA; // Calcular el IVA del total

                // Agregar línea para el IVA
                tik.AddFooterLine($"IVA ({IVA * 100}%): ${montoIVA:C}");

                // Actualizar el total para incluir el IVA
                total += montoIVA;
            }

            // Agregar línea para el total
            tik.AddFooterLine($"Total: ${total:C}");
            tik.AddFooterLine($"SuPago(efe): ${supago:C}");
            tik.AddFooterLine($"Cambio: ${cambio:C}");
            tik.AddFooterLine("");

            // Añadir mensaje de la empresa si está disponible
            if (!string.IsNullOrEmpty(ClsEmpresa.msg1))
                tik.AddSubHeaderLine(ClsEmpresa.msg1);
            if (!string.IsNullOrEmpty(ClsEmpresa.msg2))
                tik.AddSubHeaderLine(ClsEmpresa.msg2);

            // Llamar al método para imprimir el ticket
            tik.PrintTicket(frmEmpresa.impTickets);
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            lblFolio.Text = miclase.FolioSiguiente("factura","encabezado").ToString();
            
            // autocompletar txtDescripcion
            txtDescripcion.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtDescripcion.AutoCompleteCustomSource = miclase.Coleccion(miclase.conexion, "sistemapymes", "articulos", "descripcion");
            txtDescripcion.AutoCompleteMode = AutoCompleteMode.Suggest;

            // autocompletar txtNombre
            txtnombre.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtnombre.AutoCompleteCustomSource = miclase.Coleccion(miclase.conexion, "sistemapymes", "clientes", "nombre");
            txtnombre.AutoCompleteMode = AutoCompleteMode.Suggest;
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            AutocompletarArticulos();
        }

        private void AutocompletarArticulos()
        {
            // Autocompletar articulos con el metodo de autocompletado de descripcion
            string descripcion = txtDescripcion.Text.Trim();

            if (string.IsNullOrWhiteSpace(descripcion))
            {
                txtCodigoArticulo.Clear();
                txtPrecio.Clear();
            }

            List<string> datos = v.ConsultaPorDescripcion(descripcion);

            if (datos != null && datos.Count == 3)
            {
                txtCodigoArticulo.Text = datos[0];
                txtPrecio.Text = datos[1];
                exist = float.Parse(datos[2]);
                exist = float.Parse(datos[2]);
            }
            else
            {
                txtCodigoArticulo.Clear();
                txtPrecio.Clear();
            }
        }

        private void txtDescripcion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCantidad.Focus();
                txtCantidad.Enabled = true;
            }
            else if (e.KeyCode == Keys.End)
            {
                txtDescripcion.Clear();
                txtCodigoArticulo.Enabled = true;
                txtCodigoArticulo.Focus();
            }
        }
    }
}
