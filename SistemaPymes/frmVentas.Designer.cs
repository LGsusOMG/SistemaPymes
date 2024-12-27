namespace SistemaPymes
{
    partial class frmVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.txtnombre = new SistemaPymes.JECustom.JETextBox();
            this.txtCodigoCliente = new SistemaPymes.JECustom.JETextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbSuCompra = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblParcial = new System.Windows.Forms.ListBox();
            this.lblPrecio = new System.Windows.Forms.ListBox();
            this.lblDescipcion = new System.Windows.Forms.ListBox();
            this.lblCantidad = new System.Windows.Forms.ListBox();
            this.lblCodigo = new System.Windows.Forms.ListBox();
            this.gbArticulos = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDescripcion = new SistemaPymes.JECustom.JETextBox();
            this.txtCantidad = new SistemaPymes.JECustom.JETextBox();
            this.txtPrecio = new SistemaPymes.JECustom.JETextBox();
            this.txtCodigoArticulo = new SistemaPymes.JECustom.JETextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.gbTicket = new System.Windows.Forms.GroupBox();
            this.lblFolio = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lbltot = new System.Windows.Forms.Label();
            this.lblsupag = new System.Windows.Forms.Label();
            this.lblCambi = new System.Windows.Forms.Label();
            this.lblCambio = new System.Windows.Forms.Label();
            this.gbTotal = new System.Windows.Forms.GroupBox();
            this.btnRealizarPago = new CustomControls.JECustom.JEButton();
            this.txtSuPago = new SistemaPymes.JECustom.JETextBox();
            this.btnCancelar = new CustomControls.JECustom.JEButton();
            this.gbCliente.SuspendLayout();
            this.gbSuCompra.SuspendLayout();
            this.gbArticulos.SuspendLayout();
            this.gbTicket.SuspendLayout();
            this.gbTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCliente
            // 
            this.gbCliente.BackColor = System.Drawing.SystemColors.Control;
            this.gbCliente.Controls.Add(this.txtnombre);
            this.gbCliente.Controls.Add(this.txtCodigoCliente);
            this.gbCliente.Controls.Add(this.label18);
            this.gbCliente.Controls.Add(this.label3);
            this.gbCliente.Controls.Add(this.label7);
            this.gbCliente.Location = new System.Drawing.Point(17, 13);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(535, 115);
            this.gbCliente.TabIndex = 0;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // txtnombre
            // 
            this.txtnombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtnombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtnombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtnombre.BorderColor = System.Drawing.Color.Red;
            this.txtnombre.BorderFocusColor = System.Drawing.Color.Orange;
            this.txtnombre.BorderRadius = 10;
            this.txtnombre.BorderSize = 2;
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtnombre.Location = new System.Drawing.Point(136, 54);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombre.Multiline = false;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtnombre.PasswordChar = false;
            this.txtnombre.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.txtnombre.PlaceholderText = "Nombre del Cliente";
            this.txtnombre.Size = new System.Drawing.Size(377, 35);
            this.txtnombre.TabIndex = 1;
            this.txtnombre.Tag = "";
            this.txtnombre.UnderlinedStyle = true;
            this.txtnombre._TextChanged += new System.EventHandler(this.txtnombre__TextChanged);
            this.txtnombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnombre_KeyDown);
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCodigoCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCodigoCliente.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodigoCliente.BorderColor = System.Drawing.Color.Red;
            this.txtCodigoCliente.BorderFocusColor = System.Drawing.Color.Orange;
            this.txtCodigoCliente.BorderRadius = 10;
            this.txtCodigoCliente.BorderSize = 2;
            this.txtCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodigoCliente.Location = new System.Drawing.Point(12, 54);
            this.txtCodigoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoCliente.Multiline = false;
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCodigoCliente.PasswordChar = false;
            this.txtCodigoCliente.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.txtCodigoCliente.PlaceholderText = "Co. Cliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(113, 35);
            this.txtCodigoCliente.TabIndex = 0;
            this.txtCodigoCliente.Tag = "";
            this.txtCodigoCliente.UnderlinedStyle = true;
            this.txtCodigoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigo_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(1071, 273);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(98, 29);
            this.label18.TabIndex = 27;
            this.label18.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 29);
            this.label3.TabIndex = 29;
            this.label3.Text = "Nombe del Cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 29);
            this.label7.TabIndex = 27;
            this.label7.Text = "Código";
            // 
            // gbSuCompra
            // 
            this.gbSuCompra.BackColor = System.Drawing.SystemColors.Control;
            this.gbSuCompra.Controls.Add(this.label12);
            this.gbSuCompra.Controls.Add(this.label23);
            this.gbSuCompra.Controls.Add(this.label10);
            this.gbSuCompra.Controls.Add(this.label9);
            this.gbSuCompra.Controls.Add(this.label8);
            this.gbSuCompra.Controls.Add(this.label6);
            this.gbSuCompra.Controls.Add(this.label1);
            this.gbSuCompra.Controls.Add(this.lblParcial);
            this.gbSuCompra.Controls.Add(this.lblPrecio);
            this.gbSuCompra.Controls.Add(this.lblDescipcion);
            this.gbSuCompra.Controls.Add(this.lblCantidad);
            this.gbSuCompra.Controls.Add(this.lblCodigo);
            this.gbSuCompra.Location = new System.Drawing.Point(17, 149);
            this.gbSuCompra.Name = "gbSuCompra";
            this.gbSuCompra.Size = new System.Drawing.Size(699, 373);
            this.gbSuCompra.TabIndex = 1;
            this.gbSuCompra.TabStop = false;
            this.gbSuCompra.Text = "Compra";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(291, 341);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 20);
            this.label12.TabIndex = 42;
            this.label12.Text = "ESC = Terminar";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Red;
            this.label23.Location = new System.Drawing.Point(273, 316);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(188, 20);
            this.label23.TabIndex = 41;
            this.label23.Text = "Elimina al doble click";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(590, 18);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 22);
            this.label10.TabIndex = 40;
            this.label10.Text = "Parcial";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(493, 18);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 22);
            this.label9.TabIndex = 39;
            this.label9.Text = "Precio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(227, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 22);
            this.label8.TabIndex = 38;
            this.label8.Text = "Descripción";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(90, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 22);
            this.label6.TabIndex = 37;
            this.label6.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 36;
            this.label1.Text = "Código";
            // 
            // lblParcial
            // 
            this.lblParcial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParcial.FormattingEnabled = true;
            this.lblParcial.ItemHeight = 25;
            this.lblParcial.Location = new System.Drawing.Point(594, 50);
            this.lblParcial.Name = "lblParcial";
            this.lblParcial.Size = new System.Drawing.Size(92, 254);
            this.lblParcial.TabIndex = 50;
            this.lblParcial.DoubleClick += new System.EventHandler(this.Eliminar);
            // 
            // lblPrecio
            // 
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.FormattingEnabled = true;
            this.lblPrecio.ItemHeight = 25;
            this.lblPrecio.Location = new System.Drawing.Point(497, 50);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(91, 254);
            this.lblPrecio.TabIndex = 50;
            this.lblPrecio.DoubleClick += new System.EventHandler(this.Eliminar);
            // 
            // lblDescipcion
            // 
            this.lblDescipcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescipcion.FormattingEnabled = true;
            this.lblDescipcion.ItemHeight = 25;
            this.lblDescipcion.Location = new System.Drawing.Point(165, 50);
            this.lblDescipcion.Name = "lblDescipcion";
            this.lblDescipcion.Size = new System.Drawing.Size(326, 254);
            this.lblDescipcion.TabIndex = 50;
            this.lblDescipcion.DoubleClick += new System.EventHandler(this.Eliminar);
            // 
            // lblCantidad
            // 
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.FormattingEnabled = true;
            this.lblCantidad.ItemHeight = 25;
            this.lblCantidad.Location = new System.Drawing.Point(80, 50);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(79, 254);
            this.lblCantidad.TabIndex = 50;
            this.lblCantidad.DoubleClick += new System.EventHandler(this.Eliminar);
            // 
            // lblCodigo
            // 
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.FormattingEnabled = true;
            this.lblCodigo.ItemHeight = 25;
            this.lblCodigo.Location = new System.Drawing.Point(13, 50);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(61, 254);
            this.lblCodigo.TabIndex = 50;
            this.lblCodigo.DoubleClick += new System.EventHandler(this.Eliminar);
            // 
            // gbArticulos
            // 
            this.gbArticulos.BackColor = System.Drawing.SystemColors.Control;
            this.gbArticulos.Controls.Add(this.label16);
            this.gbArticulos.Controls.Add(this.txtDescripcion);
            this.gbArticulos.Controls.Add(this.txtCantidad);
            this.gbArticulos.Controls.Add(this.txtPrecio);
            this.gbArticulos.Controls.Add(this.txtCodigoArticulo);
            this.gbArticulos.Controls.Add(this.label14);
            this.gbArticulos.Controls.Add(this.label11);
            this.gbArticulos.Controls.Add(this.label13);
            this.gbArticulos.Location = new System.Drawing.Point(17, 539);
            this.gbArticulos.Name = "gbArticulos";
            this.gbArticulos.Size = new System.Drawing.Size(965, 102);
            this.gbArticulos.TabIndex = 2;
            this.gbArticulos.TabStop = false;
            this.gbArticulos.Text = "Articulos";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(818, 18);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(117, 29);
            this.label16.TabIndex = 37;
            this.label16.Text = "Cantidad";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDescripcion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescripcion.BorderColor = System.Drawing.Color.Red;
            this.txtDescripcion.BorderFocusColor = System.Drawing.Color.Orange;
            this.txtDescripcion.BorderRadius = 10;
            this.txtDescripcion.BorderSize = 2;
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescripcion.Location = new System.Drawing.Point(136, 50);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Multiline = false;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDescripcion.PasswordChar = false;
            this.txtDescripcion.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.txtDescripcion.PlaceholderText = "Descripcion Producto";
            this.txtDescripcion.Size = new System.Drawing.Size(534, 35);
            this.txtDescripcion.TabIndex = 3;
            this.txtDescripcion.Tag = "";
            this.txtDescripcion.UnderlinedStyle = true;
            this.txtDescripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescripcion_KeyDown);
            // 
            // txtCantidad
            // 
            this.txtCantidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCantidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCantidad.BackColor = System.Drawing.SystemColors.Window;
            this.txtCantidad.BorderColor = System.Drawing.Color.Red;
            this.txtCantidad.BorderFocusColor = System.Drawing.Color.Orange;
            this.txtCantidad.BorderRadius = 10;
            this.txtCantidad.BorderSize = 2;
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCantidad.Location = new System.Drawing.Point(823, 50);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Multiline = false;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCantidad.PasswordChar = false;
            this.txtCantidad.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.txtCantidad.PlaceholderText = "Cantidad";
            this.txtCantidad.Size = new System.Drawing.Size(113, 35);
            this.txtCantidad.TabIndex = 5;
            this.txtCantidad.Tag = "";
            this.txtCantidad.UnderlinedStyle = true;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCant_KeyPress);
            // 
            // txtPrecio
            // 
            this.txtPrecio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPrecio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPrecio.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrecio.BorderColor = System.Drawing.Color.Red;
            this.txtPrecio.BorderFocusColor = System.Drawing.Color.Orange;
            this.txtPrecio.BorderRadius = 10;
            this.txtPrecio.BorderSize = 2;
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrecio.Location = new System.Drawing.Point(683, 52);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.Multiline = false;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPrecio.PasswordChar = false;
            this.txtPrecio.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.txtPrecio.PlaceholderText = "Precio";
            this.txtPrecio.Size = new System.Drawing.Size(113, 35);
            this.txtPrecio.TabIndex = 4;
            this.txtPrecio.Tag = "";
            this.txtPrecio.UnderlinedStyle = true;
            // 
            // txtCodigoArticulo
            // 
            this.txtCodigoArticulo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCodigoArticulo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCodigoArticulo.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodigoArticulo.BorderColor = System.Drawing.Color.Red;
            this.txtCodigoArticulo.BorderFocusColor = System.Drawing.Color.Orange;
            this.txtCodigoArticulo.BorderRadius = 10;
            this.txtCodigoArticulo.BorderSize = 2;
            this.txtCodigoArticulo.Enabled = false;
            this.txtCodigoArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoArticulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodigoArticulo.Location = new System.Drawing.Point(12, 50);
            this.txtCodigoArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoArticulo.Multiline = false;
            this.txtCodigoArticulo.Name = "txtCodigoArticulo";
            this.txtCodigoArticulo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCodigoArticulo.PasswordChar = false;
            this.txtCodigoArticulo.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.txtCodigoArticulo.PlaceholderText = "Co. Articulo";
            this.txtCodigoArticulo.Size = new System.Drawing.Size(113, 35);
            this.txtCodigoArticulo.TabIndex = 2;
            this.txtCodigoArticulo.Tag = "";
            this.txtCodigoArticulo.UnderlinedStyle = true;
            this.txtCodigoArticulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoArticulo_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(678, 19);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 29);
            this.label14.TabIndex = 39;
            this.label14.Text = "Precio";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 18);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 29);
            this.label11.TabIndex = 36;
            this.label11.Text = "Código";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(128, 18);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(152, 29);
            this.label13.TabIndex = 38;
            this.label13.Text = "Descripción";
            // 
            // gbTicket
            // 
            this.gbTicket.BackColor = System.Drawing.SystemColors.Control;
            this.gbTicket.Controls.Add(this.lblFolio);
            this.gbTicket.Controls.Add(this.label15);
            this.gbTicket.Location = new System.Drawing.Point(558, 13);
            this.gbTicket.Name = "gbTicket";
            this.gbTicket.Size = new System.Drawing.Size(158, 115);
            this.gbTicket.TabIndex = 3;
            this.gbTicket.TabStop = false;
            this.gbTicket.Text = "Ticket";
            // 
            // lblFolio
            // 
            this.lblFolio.AutoSize = true;
            this.lblFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolio.Location = new System.Drawing.Point(102, 51);
            this.lblFolio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(27, 29);
            this.lblFolio.TabIndex = 27;
            this.lblFolio.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(7, 51);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 25);
            this.label15.TabIndex = 27;
            this.label15.Text = "Folío:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(129, 51);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(27, 29);
            this.lblTotal.TabIndex = 27;
            this.lblTotal.Text = "0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbltot
            // 
            this.lbltot.AutoSize = true;
            this.lbltot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltot.Location = new System.Drawing.Point(42, 51);
            this.lbltot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltot.Name = "lbltot";
            this.lbltot.Size = new System.Drawing.Size(79, 22);
            this.lbltot.TabIndex = 27;
            this.lbltot.Text = "Total  $";
            // 
            // lblsupag
            // 
            this.lblsupag.AutoSize = true;
            this.lblsupag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsupag.Location = new System.Drawing.Point(48, 108);
            this.lblsupag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsupag.Name = "lblsupag";
            this.lblsupag.Size = new System.Drawing.Size(73, 22);
            this.lblsupag.TabIndex = 27;
            this.lblsupag.Text = "Pago $";
            // 
            // lblCambi
            // 
            this.lblCambi.AutoSize = true;
            this.lblCambi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambi.Location = new System.Drawing.Point(27, 154);
            this.lblCambi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCambi.Name = "lblCambi";
            this.lblCambi.Size = new System.Drawing.Size(94, 22);
            this.lblCambi.TabIndex = 27;
            this.lblCambi.Text = "Cambio $";
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambio.Location = new System.Drawing.Point(129, 149);
            this.lblCambio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(27, 29);
            this.lblCambio.TabIndex = 30;
            this.lblCambio.Text = "0";
            this.lblCambio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbTotal
            // 
            this.gbTotal.BackColor = System.Drawing.SystemColors.Control;
            this.gbTotal.Controls.Add(this.btnRealizarPago);
            this.gbTotal.Controls.Add(this.txtSuPago);
            this.gbTotal.Controls.Add(this.lblCambio);
            this.gbTotal.Controls.Add(this.lblCambi);
            this.gbTotal.Controls.Add(this.lblsupag);
            this.gbTotal.Controls.Add(this.lbltot);
            this.gbTotal.Controls.Add(this.lblTotal);
            this.gbTotal.Location = new System.Drawing.Point(724, 149);
            this.gbTotal.Name = "gbTotal";
            this.gbTotal.Size = new System.Drawing.Size(258, 282);
            this.gbTotal.TabIndex = 4;
            this.gbTotal.TabStop = false;
            this.gbTotal.Text = "Total";
            // 
            // btnRealizarPago
            // 
            this.btnRealizarPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRealizarPago.BorderColor = System.Drawing.Color.Orange;
            this.btnRealizarPago.BorderRadius = 10;
            this.btnRealizarPago.BorderSize = 0;
            this.btnRealizarPago.FlatAppearance.BorderSize = 0;
            this.btnRealizarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealizarPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarPago.ForeColor = System.Drawing.Color.Black;
            this.btnRealizarPago.Image = global::SistemaPymes.Properties.Resources.dolar;
            this.btnRealizarPago.Location = new System.Drawing.Point(29, 217);
            this.btnRealizarPago.Name = "btnRealizarPago";
            this.btnRealizarPago.Size = new System.Drawing.Size(196, 48);
            this.btnRealizarPago.TabIndex = 7;
            this.btnRealizarPago.Text = "  Realizar Pago";
            this.btnRealizarPago.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRealizarPago.UseVisualStyleBackColor = true;
            this.btnRealizarPago.Click += new System.EventHandler(this.btnRealizarPago_Click);
            // 
            // txtSuPago
            // 
            this.txtSuPago.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSuPago.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSuPago.BackColor = System.Drawing.SystemColors.Window;
            this.txtSuPago.BorderColor = System.Drawing.Color.Red;
            this.txtSuPago.BorderFocusColor = System.Drawing.Color.Orange;
            this.txtSuPago.BorderRadius = 10;
            this.txtSuPago.BorderSize = 2;
            this.txtSuPago.Enabled = false;
            this.txtSuPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSuPago.Location = new System.Drawing.Point(129, 95);
            this.txtSuPago.Margin = new System.Windows.Forms.Padding(4);
            this.txtSuPago.Multiline = false;
            this.txtSuPago.Name = "txtSuPago";
            this.txtSuPago.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSuPago.PasswordChar = false;
            this.txtSuPago.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.txtSuPago.PlaceholderText = "Pago Cliente";
            this.txtSuPago.Size = new System.Drawing.Size(114, 35);
            this.txtSuPago.TabIndex = 6;
            this.txtSuPago.Tag = "";
            this.txtSuPago.UnderlinedStyle = true;
            this.txtSuPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSuPago_KeyPress_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancelar.BorderColor = System.Drawing.Color.Orange;
            this.btnCancelar.BorderRadius = 10;
            this.btnCancelar.BorderSize = 0;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Image = global::SistemaPymes.Properties.Resources.incorrecto__1_;
            this.btnCancelar.Location = new System.Drawing.Point(770, 449);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(154, 48);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = " Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 655);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gbTotal);
            this.Controls.Add(this.gbTicket);
            this.Controls.Add(this.gbArticulos);
            this.Controls.Add(this.gbSuCompra);
            this.Controls.Add(this.gbCliente);
            this.Name = "frmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.gbSuCompra.ResumeLayout(false);
            this.gbSuCompra.PerformLayout();
            this.gbArticulos.ResumeLayout(false);
            this.gbArticulos.PerformLayout();
            this.gbTicket.ResumeLayout(false);
            this.gbTicket.PerformLayout();
            this.gbTotal.ResumeLayout(false);
            this.gbTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.GroupBox gbSuCompra;
        private System.Windows.Forms.GroupBox gbArticulos;
        private System.Windows.Forms.GroupBox gbTicket;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lblParcial;
        private System.Windows.Forms.ListBox lblPrecio;
        private System.Windows.Forms.ListBox lblDescipcion;
        private System.Windows.Forms.ListBox lblCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblFolio;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListBox lblCantidad;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lbltot;
        private System.Windows.Forms.Label lblsupag;
        private System.Windows.Forms.Label lblCambi;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.GroupBox gbTotal;
        private System.Windows.Forms.Label label12;
        private CustomControls.JECustom.JEButton btnCancelar;
        private CustomControls.JECustom.JEButton btnRealizarPago;
        private JECustom.JETextBox txtnombre;
        private JECustom.JETextBox txtCodigoArticulo;
        private JECustom.JETextBox txtSuPago;
        private JECustom.JETextBox txtCodigoCliente;
        private JECustom.JETextBox txtDescripcion;
        private JECustom.JETextBox txtCantidad;
        private JECustom.JETextBox txtPrecio;
    }
}