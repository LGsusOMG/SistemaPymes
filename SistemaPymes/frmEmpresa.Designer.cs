namespace SistemaPymes
{
    partial class frmEmpresa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label10 = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblMensaje1 = new System.Windows.Forms.Label();
            this.lblMensaje2 = new System.Windows.Forms.Label();
            this.lblRFC = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new CustomControls.JECustom.JEButton();
            this.btnGuardar = new CustomControls.JECustom.JEButton();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarImagen = new CustomControls.JECustom.JEButton();
            this.btnBuscarLogo = new CustomControls.JECustom.JEButton();
            this.txtLinea2 = new SistemaPymes.JECustom.JETextBox();
            this.txtLinea1 = new SistemaPymes.JECustom.JETextBox();
            this.txtCaja = new SistemaPymes.JECustom.JETextBox();
            this.txtLogo = new SistemaPymes.JECustom.JETextBox();
            this.txtImagen = new SistemaPymes.JECustom.JETextBox();
            this.txtTelefono = new SistemaPymes.JECustom.JETextBox();
            this.txtRFC = new SistemaPymes.JECustom.JETextBox();
            this.txtDireccion = new SistemaPymes.JECustom.JETextBox();
            this.pbTicket = new System.Windows.Forms.PictureBox();
            this.pbEmpresa = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pbLogoTicket = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNomEmpresa = new SistemaPymes.JECustom.JETextBox();
            this.cbImpTickets = new SistemaPymes.JECustom.JEComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmpresa)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de la Empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "RFC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Imagen de la Empresa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Logotipo para Ticket";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 536);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(271, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mensaje del Ticket Linea 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 609);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(271, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mensaje del Ticket Linea 2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(222, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Empresa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(371, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ticket";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 460);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Numero de Caja";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(136, 149);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(133, 16);
            this.lblEmpresa.TabIndex = 14;
            this.lblEmpresa.Text = "Nombre de Empresa";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(22, 176);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(141, 16);
            this.lblDireccion.TabIndex = 15;
            this.lblDireccion.Text = "Direccion de Empresa";
            // 
            // lblMensaje1
            // 
            this.lblMensaje1.AutoSize = true;
            this.lblMensaje1.Location = new System.Drawing.Point(22, 570);
            this.lblMensaje1.Name = "lblMensaje1";
            this.lblMensaje1.Size = new System.Drawing.Size(69, 16);
            this.lblMensaje1.TabIndex = 15;
            this.lblMensaje1.Text = "Mensaje 1";
            // 
            // lblMensaje2
            // 
            this.lblMensaje2.AutoSize = true;
            this.lblMensaje2.Location = new System.Drawing.Point(22, 637);
            this.lblMensaje2.Name = "lblMensaje2";
            this.lblMensaje2.Size = new System.Drawing.Size(69, 16);
            this.lblMensaje2.TabIndex = 15;
            this.lblMensaje2.Text = "Mensaje 2";
            // 
            // lblRFC
            // 
            this.lblRFC.AutoSize = true;
            this.lblRFC.Location = new System.Drawing.Point(22, 205);
            this.lblRFC.Name = "lblRFC";
            this.lblRFC.Size = new System.Drawing.Size(34, 16);
            this.lblRFC.TabIndex = 15;
            this.lblRFC.Text = "RFC";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Location = new System.Drawing.Point(15, 705);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 123);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BorderColor = System.Drawing.Color.Transparent;
            this.btnSalir.BorderRadius = 10;
            this.btnSalir.BorderSize = 1;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Image = global::SistemaPymes.Properties.Resources.incorrecto__1_;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.Location = new System.Drawing.Point(340, 17);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(123, 100);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "  Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BorderColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BorderRadius = 10;
            this.btnGuardar.BorderSize = 1;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Image = global::SistemaPymes.Properties.Resources.correcto__1_;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.Location = new System.Drawing.Point(40, 23);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(139, 96);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "  Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 242);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Telefono";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(22, 233);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(61, 16);
            this.lblTelefono.TabIndex = 15;
            this.lblTelefono.Text = "Telefono";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscarImagen);
            this.groupBox2.Controls.Add(this.btnBuscarLogo);
            this.groupBox2.Controls.Add(this.txtLinea2);
            this.groupBox2.Controls.Add(this.txtLinea1);
            this.groupBox2.Controls.Add(this.txtCaja);
            this.groupBox2.Controls.Add(this.txtLogo);
            this.groupBox2.Controls.Add(this.txtImagen);
            this.groupBox2.Controls.Add(this.txtTelefono);
            this.groupBox2.Controls.Add(this.txtRFC);
            this.groupBox2.Controls.Add(this.txtDireccion);
            this.groupBox2.Controls.Add(this.pbTicket);
            this.groupBox2.Controls.Add(this.pbEmpresa);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(15, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 687);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // btnBuscarImagen
            // 
            this.btnBuscarImagen.BackColor = System.Drawing.Color.Bisque;
            this.btnBuscarImagen.BorderColor = System.Drawing.Color.Bisque;
            this.btnBuscarImagen.BorderRadius = 10;
            this.btnBuscarImagen.BorderSize = 2;
            this.btnBuscarImagen.FlatAppearance.BorderSize = 0;
            this.btnBuscarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarImagen.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarImagen.Location = new System.Drawing.Point(381, 338);
            this.btnBuscarImagen.Name = "btnBuscarImagen";
            this.btnBuscarImagen.Size = new System.Drawing.Size(103, 40);
            this.btnBuscarImagen.TabIndex = 5;
            this.btnBuscarImagen.Text = "  Buscar";
            this.btnBuscarImagen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarImagen.UseVisualStyleBackColor = false;
            this.btnBuscarImagen.Click += new System.EventHandler(this.btnBuscarImagen_Click);
            // 
            // btnBuscarLogo
            // 
            this.btnBuscarLogo.BackColor = System.Drawing.Color.Bisque;
            this.btnBuscarLogo.BorderColor = System.Drawing.Color.Bisque;
            this.btnBuscarLogo.BorderRadius = 10;
            this.btnBuscarLogo.BorderSize = 2;
            this.btnBuscarLogo.FlatAppearance.BorderSize = 0;
            this.btnBuscarLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarLogo.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarLogo.Location = new System.Drawing.Point(381, 421);
            this.btnBuscarLogo.Name = "btnBuscarLogo";
            this.btnBuscarLogo.Size = new System.Drawing.Size(103, 40);
            this.btnBuscarLogo.TabIndex = 7;
            this.btnBuscarLogo.Text = "  Buscar";
            this.btnBuscarLogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarLogo.UseVisualStyleBackColor = false;
            this.btnBuscarLogo.Click += new System.EventHandler(this.btnBuscarLogo_Click);
            // 
            // txtLinea2
            // 
            this.txtLinea2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtLinea2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtLinea2.BackColor = System.Drawing.SystemColors.Window;
            this.txtLinea2.BorderColor = System.Drawing.Color.Red;
            this.txtLinea2.BorderFocusColor = System.Drawing.Color.Orange;
            this.txtLinea2.BorderRadius = 0;
            this.txtLinea2.BorderSize = 2;
            this.txtLinea2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinea2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLinea2.Location = new System.Drawing.Point(14, 637);
            this.txtLinea2.Margin = new System.Windows.Forms.Padding(4);
            this.txtLinea2.Multiline = false;
            this.txtLinea2.Name = "txtLinea2";
            this.txtLinea2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtLinea2.PasswordChar = false;
            this.txtLinea2.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.txtLinea2.PlaceholderText = "Mensaje 2";
            this.txtLinea2.Size = new System.Drawing.Size(462, 35);
            this.txtLinea2.TabIndex = 10;
            this.txtLinea2.UnderlinedStyle = true;
            this.txtLinea2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLinea2_KeyPress);
            // 
            // txtLinea1
            // 
            this.txtLinea1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtLinea1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtLinea1.BackColor = System.Drawing.SystemColors.Window;
            this.txtLinea1.BorderColor = System.Drawing.Color.Red;
            this.txtLinea1.BorderFocusColor = System.Drawing.Color.Orange;
            this.txtLinea1.BorderRadius = 0;
            this.txtLinea1.BorderSize = 2;
            this.txtLinea1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinea1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLinea1.Location = new System.Drawing.Point(14, 570);
            this.txtLinea1.Margin = new System.Windows.Forms.Padding(4);
            this.txtLinea1.Multiline = false;
            this.txtLinea1.Name = "txtLinea1";
            this.txtLinea1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtLinea1.PasswordChar = false;
            this.txtLinea1.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.txtLinea1.PlaceholderText = "Mensaje 1";
            this.txtLinea1.Size = new System.Drawing.Size(462, 35);
            this.txtLinea1.TabIndex = 9;
            this.txtLinea1.UnderlinedStyle = true;
            this.txtLinea1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLinea1_KeyPress);
            // 
            // txtCaja
            // 
            this.txtCaja.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCaja.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCaja.BackColor = System.Drawing.SystemColors.Window;
            this.txtCaja.BorderColor = System.Drawing.Color.Red;
            this.txtCaja.BorderFocusColor = System.Drawing.Color.Orange;
            this.txtCaja.BorderRadius = 0;
            this.txtCaja.BorderSize = 2;
            this.txtCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCaja.Location = new System.Drawing.Point(14, 497);
            this.txtCaja.Margin = new System.Windows.Forms.Padding(4);
            this.txtCaja.Multiline = false;
            this.txtCaja.Name = "txtCaja";
            this.txtCaja.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCaja.PasswordChar = false;
            this.txtCaja.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.txtCaja.PlaceholderText = "Caja de Cobro";
            this.txtCaja.Size = new System.Drawing.Size(191, 35);
            this.txtCaja.TabIndex = 8;
            this.txtCaja.UnderlinedStyle = true;
            this.txtCaja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaja_KeyPress);
            // 
            // txtLogo
            // 
            this.txtLogo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtLogo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtLogo.BackColor = System.Drawing.SystemColors.Window;
            this.txtLogo.BorderColor = System.Drawing.Color.Red;
            this.txtLogo.BorderFocusColor = System.Drawing.Color.Orange;
            this.txtLogo.BorderRadius = 0;
            this.txtLogo.BorderSize = 2;
            this.txtLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLogo.Location = new System.Drawing.Point(14, 421);
            this.txtLogo.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogo.Multiline = false;
            this.txtLogo.Name = "txtLogo";
            this.txtLogo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtLogo.PasswordChar = false;
            this.txtLogo.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.txtLogo.PlaceholderText = "Logo de Empresa";
            this.txtLogo.Size = new System.Drawing.Size(352, 35);
            this.txtLogo.TabIndex = 6;
            this.txtLogo.UnderlinedStyle = true;
            this.txtLogo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogo_KeyPress);
            // 
            // txtImagen
            // 
            this.txtImagen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtImagen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtImagen.BackColor = System.Drawing.SystemColors.Window;
            this.txtImagen.BorderColor = System.Drawing.Color.Red;
            this.txtImagen.BorderFocusColor = System.Drawing.Color.Orange;
            this.txtImagen.BorderRadius = 0;
            this.txtImagen.BorderSize = 2;
            this.txtImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImagen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtImagen.Location = new System.Drawing.Point(14, 343);
            this.txtImagen.Margin = new System.Windows.Forms.Padding(4);
            this.txtImagen.Multiline = false;
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtImagen.PasswordChar = false;
            this.txtImagen.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.txtImagen.PlaceholderText = "Imagen de Empresa";
            this.txtImagen.Size = new System.Drawing.Size(352, 35);
            this.txtImagen.TabIndex = 4;
            this.txtImagen.UnderlinedStyle = true;
            this.txtImagen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImagen_KeyPress);
            // 
            // txtTelefono
            // 
            this.txtTelefono.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTelefono.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTelefono.BackColor = System.Drawing.SystemColors.Window;
            this.txtTelefono.BorderColor = System.Drawing.Color.Red;
            this.txtTelefono.BorderFocusColor = System.Drawing.Color.Orange;
            this.txtTelefono.BorderRadius = 0;
            this.txtTelefono.BorderSize = 2;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTelefono.Location = new System.Drawing.Point(14, 271);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Multiline = false;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTelefono.PasswordChar = false;
            this.txtTelefono.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.txtTelefono.PlaceholderText = "Telefono";
            this.txtTelefono.Size = new System.Drawing.Size(193, 35);
            this.txtTelefono.TabIndex = 3;
            this.txtTelefono.UnderlinedStyle = true;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtRFC
            // 
            this.txtRFC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtRFC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtRFC.BackColor = System.Drawing.SystemColors.Window;
            this.txtRFC.BorderColor = System.Drawing.Color.Red;
            this.txtRFC.BorderFocusColor = System.Drawing.Color.Orange;
            this.txtRFC.BorderRadius = 0;
            this.txtRFC.BorderSize = 2;
            this.txtRFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRFC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRFC.Location = new System.Drawing.Point(12, 203);
            this.txtRFC.Margin = new System.Windows.Forms.Padding(4);
            this.txtRFC.Multiline = false;
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtRFC.PasswordChar = false;
            this.txtRFC.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.txtRFC.PlaceholderText = "RFC";
            this.txtRFC.Size = new System.Drawing.Size(193, 35);
            this.txtRFC.TabIndex = 2;
            this.txtRFC.UnderlinedStyle = true;
            this.txtRFC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRFC_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDireccion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDireccion.BackColor = System.Drawing.SystemColors.Window;
            this.txtDireccion.BorderColor = System.Drawing.Color.Red;
            this.txtDireccion.BorderFocusColor = System.Drawing.Color.Orange;
            this.txtDireccion.BorderRadius = 0;
            this.txtDireccion.BorderSize = 2;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDireccion.Location = new System.Drawing.Point(14, 138);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Multiline = false;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDireccion.PasswordChar = false;
            this.txtDireccion.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.txtDireccion.PlaceholderText = "Direccion";
            this.txtDireccion.Size = new System.Drawing.Size(462, 35);
            this.txtDireccion.TabIndex = 1;
            this.txtDireccion.UnderlinedStyle = true;
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // pbTicket
            // 
            this.pbTicket.Location = new System.Drawing.Point(376, 208);
            this.pbTicket.Name = "pbTicket";
            this.pbTicket.Size = new System.Drawing.Size(100, 50);
            this.pbTicket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTicket.TabIndex = 12;
            this.pbTicket.TabStop = false;
            // 
            // pbEmpresa
            // 
            this.pbEmpresa.Location = new System.Drawing.Point(219, 208);
            this.pbEmpresa.Name = "pbEmpresa";
            this.pbEmpresa.Size = new System.Drawing.Size(100, 50);
            this.pbEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEmpresa.TabIndex = 11;
            this.pbEmpresa.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblMensaje1);
            this.groupBox3.Controls.Add(this.lblMensaje2);
            this.groupBox3.Controls.Add(this.lblTelefono);
            this.groupBox3.Controls.Add(this.lblRFC);
            this.groupBox3.Controls.Add(this.lblDireccion);
            this.groupBox3.Controls.Add(this.lblEmpresa);
            this.groupBox3.Controls.Add(this.pbLogoTicket);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Location = new System.Drawing.Point(575, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(429, 687);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ticket";
            // 
            // pbLogoTicket
            // 
            this.pbLogoTicket.Location = new System.Drawing.Point(39, 32);
            this.pbLogoTicket.Name = "pbLogoTicket";
            this.pbLogoTicket.Size = new System.Drawing.Size(346, 103);
            this.pbLogoTicket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoTicket.TabIndex = 13;
            this.pbLogoTicket.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaPymes.Properties.Resources.Ticket_de_Ejemplo1;
            this.pictureBox1.Location = new System.Drawing.Point(5, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(418, 651);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // txtNomEmpresa
            // 
            this.txtNomEmpresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNomEmpresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNomEmpresa.BackColor = System.Drawing.SystemColors.Window;
            this.txtNomEmpresa.BorderColor = System.Drawing.Color.Red;
            this.txtNomEmpresa.BorderFocusColor = System.Drawing.Color.Orange;
            this.txtNomEmpresa.BorderRadius = 0;
            this.txtNomEmpresa.BorderSize = 2;
            this.txtNomEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNomEmpresa.Location = new System.Drawing.Point(29, 70);
            this.txtNomEmpresa.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomEmpresa.Multiline = false;
            this.txtNomEmpresa.Name = "txtNomEmpresa";
            this.txtNomEmpresa.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNomEmpresa.PasswordChar = false;
            this.txtNomEmpresa.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.txtNomEmpresa.PlaceholderText = "Nombre de Empresa";
            this.txtNomEmpresa.Size = new System.Drawing.Size(462, 35);
            this.txtNomEmpresa.TabIndex = 0;
            this.txtNomEmpresa.UnderlinedStyle = true;
            this.txtNomEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomEmpresa_KeyPress);
            // 
            // cbImpTickets
            // 
            this.cbImpTickets.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbImpTickets.BorderColor = System.Drawing.Color.Black;
            this.cbImpTickets.BorderSize = 1;
            this.cbImpTickets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbImpTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbImpTickets.ForeColor = System.Drawing.Color.DimGray;
            this.cbImpTickets.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbImpTickets.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbImpTickets.ListTextColor = System.Drawing.Color.DimGray;
            this.cbImpTickets.Location = new System.Drawing.Point(580, 733);
            this.cbImpTickets.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbImpTickets.Name = "cbImpTickets";
            this.cbImpTickets.Padding = new System.Windows.Forms.Padding(1);
            this.cbImpTickets.Size = new System.Drawing.Size(363, 30);
            this.cbImpTickets.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(575, 705);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(214, 25);
            this.label13.TabIndex = 22;
            this.label13.Text = "Impresora de Tickets";
            // 
            // frmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 904);
            this.Controls.Add(this.cbImpTickets);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtNomEmpresa);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurar Empresa";
            this.Load += new System.EventHandler(this.frmEmpresa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmpresa)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbEmpresa;
        private System.Windows.Forms.PictureBox pbTicket;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pbLogoTicket;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblMensaje1;
        private System.Windows.Forms.Label lblMensaje2;
        private System.Windows.Forms.Label lblRFC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private CustomControls.JECustom.JEButton btnSalir;
        private CustomControls.JECustom.JEButton btnGuardar;
        private JECustom.JETextBox txtNomEmpresa;
        private JECustom.JETextBox txtLogo;
        private JECustom.JETextBox txtImagen;
        private JECustom.JETextBox txtTelefono;
        private JECustom.JETextBox txtRFC;
        private JECustom.JETextBox txtDireccion;
        private JECustom.JETextBox txtLinea2;
        private JECustom.JETextBox txtLinea1;
        private JECustom.JETextBox txtCaja;
        private CustomControls.JECustom.JEButton btnBuscarLogo;
        private CustomControls.JECustom.JEButton btnBuscarImagen;
        private JECustom.JEComboBox cbImpTickets;
        private System.Windows.Forms.Label label13;
    }
}