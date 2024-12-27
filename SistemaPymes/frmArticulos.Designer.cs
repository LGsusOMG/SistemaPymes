namespace SistemaPymes
{
    partial class frmArticulos
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
            this.dgarticulos = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtdescripcion = new SistemaPymes.JECustom.JETextBox();
            this.txtpventa = new SistemaPymes.JECustom.JETextBox();
            this.txtpcompra = new SistemaPymes.JECustom.JETextBox();
            this.txtsmaximo = new SistemaPymes.JECustom.JETextBox();
            this.txtsminimo = new SistemaPymes.JECustom.JETextBox();
            this.txtexistencia = new SistemaPymes.JECustom.JETextBox();
            this.txtcodigo = new SistemaPymes.JECustom.JETextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsalir = new CustomControls.JECustom.JEButton();
            this.btneliminar = new CustomControls.JECustom.JEButton();
            this.btnmodificar = new CustomControls.JECustom.JEButton();
            this.btnguardar = new CustomControls.JECustom.JEButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgarticulos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgarticulos
            // 
            this.dgarticulos.AllowUserToAddRows = false;
            this.dgarticulos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.dgarticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgarticulos.Location = new System.Drawing.Point(7, 35);
            this.dgarticulos.Margin = new System.Windows.Forms.Padding(4);
            this.dgarticulos.Name = "dgarticulos";
            this.dgarticulos.RowHeadersWidth = 51;
            this.dgarticulos.Size = new System.Drawing.Size(908, 294);
            this.dgarticulos.TabIndex = 21;
            this.dgarticulos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgarticulos_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(359, 102);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 29);
            this.label7.TabIndex = 18;
            this.label7.Text = "SMAXIMO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(188, 102);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "SMINIMO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 102);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 29);
            this.label5.TabIndex = 19;
            this.label5.Text = "EXISTENCIA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(749, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 29);
            this.label4.TabIndex = 16;
            this.label4.Text = "PVENTA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(547, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "PCOMPRA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "DESCRIPCION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "CÓDIGO";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtdescripcion);
            this.groupBox2.Controls.Add(this.txtpventa);
            this.groupBox2.Controls.Add(this.txtpcompra);
            this.groupBox2.Controls.Add(this.txtsmaximo);
            this.groupBox2.Controls.Add(this.txtsminimo);
            this.groupBox2.Controls.Add(this.txtexistencia);
            this.groupBox2.Controls.Add(this.txtcodigo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(13, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(925, 189);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtdescripcion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtdescripcion.BackColor = System.Drawing.SystemColors.Window;
            this.txtdescripcion.BorderColor = System.Drawing.Color.Red;
            this.txtdescripcion.BorderFocusColor = System.Drawing.Color.Orange;
            this.txtdescripcion.BorderRadius = 10;
            this.txtdescripcion.BorderSize = 2;
            this.txtdescripcion.Enabled = false;
            this.txtdescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtdescripcion.Location = new System.Drawing.Point(162, 53);
            this.txtdescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtdescripcion.Multiline = false;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtdescripcion.PasswordChar = false;
            this.txtdescripcion.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.txtdescripcion.PlaceholderText = "Descripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(374, 35);
            this.txtdescripcion.TabIndex = 1;
            this.txtdescripcion.Tag = "";
            this.txtdescripcion.UnderlinedStyle = true;
            this.txtdescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdescripcion_KeyPress);
            // 
            // txtpventa
            // 
            this.txtpventa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtpventa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtpventa.BackColor = System.Drawing.SystemColors.Window;
            this.txtpventa.BorderColor = System.Drawing.Color.Red;
            this.txtpventa.BorderFocusColor = System.Drawing.Color.Orange;
            this.txtpventa.BorderRadius = 10;
            this.txtpventa.BorderSize = 2;
            this.txtpventa.Enabled = false;
            this.txtpventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpventa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtpventa.Location = new System.Drawing.Point(742, 54);
            this.txtpventa.Margin = new System.Windows.Forms.Padding(4);
            this.txtpventa.Multiline = false;
            this.txtpventa.Name = "txtpventa";
            this.txtpventa.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtpventa.PasswordChar = false;
            this.txtpventa.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.txtpventa.PlaceholderText = "Precio Venta";
            this.txtpventa.Size = new System.Drawing.Size(173, 35);
            this.txtpventa.TabIndex = 3;
            this.txtpventa.Tag = "";
            this.txtpventa.UnderlinedStyle = true;
            this.txtpventa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpventa_KeyPress);
            // 
            // txtpcompra
            // 
            this.txtpcompra.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtpcompra.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtpcompra.BackColor = System.Drawing.SystemColors.Window;
            this.txtpcompra.BorderColor = System.Drawing.Color.Red;
            this.txtpcompra.BorderFocusColor = System.Drawing.Color.Orange;
            this.txtpcompra.BorderRadius = 10;
            this.txtpcompra.BorderSize = 2;
            this.txtpcompra.Enabled = false;
            this.txtpcompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpcompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtpcompra.Location = new System.Drawing.Point(549, 54);
            this.txtpcompra.Margin = new System.Windows.Forms.Padding(4);
            this.txtpcompra.Multiline = false;
            this.txtpcompra.Name = "txtpcompra";
            this.txtpcompra.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtpcompra.PasswordChar = false;
            this.txtpcompra.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.txtpcompra.PlaceholderText = "Precio Compra";
            this.txtpcompra.Size = new System.Drawing.Size(185, 35);
            this.txtpcompra.TabIndex = 2;
            this.txtpcompra.Tag = "";
            this.txtpcompra.UnderlinedStyle = true;
            this.txtpcompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpcompra_KeyPress);
            // 
            // txtsmaximo
            // 
            this.txtsmaximo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtsmaximo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtsmaximo.BackColor = System.Drawing.SystemColors.Window;
            this.txtsmaximo.BorderColor = System.Drawing.Color.Red;
            this.txtsmaximo.BorderFocusColor = System.Drawing.Color.Orange;
            this.txtsmaximo.BorderRadius = 10;
            this.txtsmaximo.BorderSize = 2;
            this.txtsmaximo.Enabled = false;
            this.txtsmaximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsmaximo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtsmaximo.Location = new System.Drawing.Point(364, 135);
            this.txtsmaximo.Margin = new System.Windows.Forms.Padding(4);
            this.txtsmaximo.Multiline = false;
            this.txtsmaximo.Name = "txtsmaximo";
            this.txtsmaximo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtsmaximo.PasswordChar = false;
            this.txtsmaximo.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.txtsmaximo.PlaceholderText = "Existencia Maxima";
            this.txtsmaximo.Size = new System.Drawing.Size(172, 35);
            this.txtsmaximo.TabIndex = 6;
            this.txtsmaximo.Tag = "";
            this.txtsmaximo.UnderlinedStyle = true;
            this.txtsmaximo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsmaximo_KeyPress);
            // 
            // txtsminimo
            // 
            this.txtsminimo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtsminimo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtsminimo.BackColor = System.Drawing.SystemColors.Window;
            this.txtsminimo.BorderColor = System.Drawing.Color.Red;
            this.txtsminimo.BorderFocusColor = System.Drawing.Color.Orange;
            this.txtsminimo.BorderRadius = 10;
            this.txtsminimo.BorderSize = 2;
            this.txtsminimo.Enabled = false;
            this.txtsminimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsminimo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtsminimo.Location = new System.Drawing.Point(182, 134);
            this.txtsminimo.Margin = new System.Windows.Forms.Padding(4);
            this.txtsminimo.Multiline = false;
            this.txtsminimo.Name = "txtsminimo";
            this.txtsminimo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtsminimo.PasswordChar = false;
            this.txtsminimo.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.txtsminimo.PlaceholderText = "Existencia Minima";
            this.txtsminimo.Size = new System.Drawing.Size(157, 35);
            this.txtsminimo.TabIndex = 5;
            this.txtsminimo.Tag = "";
            this.txtsminimo.UnderlinedStyle = true;
            this.txtsminimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsminimo_KeyPress);
            // 
            // txtexistencia
            // 
            this.txtexistencia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtexistencia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtexistencia.BackColor = System.Drawing.SystemColors.Window;
            this.txtexistencia.BorderColor = System.Drawing.Color.Red;
            this.txtexistencia.BorderFocusColor = System.Drawing.Color.Orange;
            this.txtexistencia.BorderRadius = 10;
            this.txtexistencia.BorderSize = 2;
            this.txtexistencia.Enabled = false;
            this.txtexistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtexistencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtexistencia.Location = new System.Drawing.Point(7, 134);
            this.txtexistencia.Margin = new System.Windows.Forms.Padding(4);
            this.txtexistencia.Multiline = false;
            this.txtexistencia.Name = "txtexistencia";
            this.txtexistencia.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtexistencia.PasswordChar = false;
            this.txtexistencia.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.txtexistencia.PlaceholderText = "Existencia";
            this.txtexistencia.Size = new System.Drawing.Size(157, 35);
            this.txtexistencia.TabIndex = 4;
            this.txtexistencia.Tag = "";
            this.txtexistencia.UnderlinedStyle = true;
            this.txtexistencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtexistencia_KeyPress);
            // 
            // txtcodigo
            // 
            this.txtcodigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtcodigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtcodigo.BackColor = System.Drawing.SystemColors.Window;
            this.txtcodigo.BorderColor = System.Drawing.Color.Red;
            this.txtcodigo.BorderFocusColor = System.Drawing.Color.Orange;
            this.txtcodigo.BorderRadius = 10;
            this.txtcodigo.BorderSize = 2;
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcodigo.Location = new System.Drawing.Point(7, 54);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtcodigo.Multiline = false;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtcodigo.PasswordChar = false;
            this.txtcodigo.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.txtcodigo.PlaceholderText = "Codigo";
            this.txtcodigo.Size = new System.Drawing.Size(133, 35);
            this.txtcodigo.TabIndex = 0;
            this.txtcodigo.Tag = "";
            this.txtcodigo.UnderlinedStyle = true;
            this.txtcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigo_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgarticulos);
            this.groupBox3.Location = new System.Drawing.Point(13, 221);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(925, 347);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Registros";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsalir);
            this.groupBox1.Controls.Add(this.btneliminar);
            this.groupBox1.Controls.Add(this.btnmodificar);
            this.groupBox1.Controls.Add(this.btnguardar);
            this.groupBox1.Location = new System.Drawing.Point(13, 589);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(925, 119);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Transparent;
            this.btnsalir.BorderColor = System.Drawing.Color.Transparent;
            this.btnsalir.BorderRadius = 10;
            this.btnsalir.BorderSize = 1;
            this.btnsalir.FlatAppearance.BorderSize = 0;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.Color.Black;
            this.btnsalir.Image = global::SistemaPymes.Properties.Resources.incorrecto__1_;
            this.btnsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsalir.Location = new System.Drawing.Point(800, 21);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(115, 88);
            this.btnsalir.TabIndex = 11;
            this.btnsalir.Text = "  Salir";
            this.btnsalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click_1);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.Transparent;
            this.btneliminar.BorderColor = System.Drawing.Color.Transparent;
            this.btneliminar.BorderRadius = 10;
            this.btneliminar.BorderSize = 1;
            this.btneliminar.FlatAppearance.BorderSize = 0;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.ForeColor = System.Drawing.Color.Black;
            this.btneliminar.Image = global::SistemaPymes.Properties.Resources.incorrecto__1_;
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminar.Location = new System.Drawing.Point(327, 21);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(142, 88);
            this.btneliminar.TabIndex = 10;
            this.btneliminar.Text = "  Eliminar";
            this.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackColor = System.Drawing.Color.Transparent;
            this.btnmodificar.BorderColor = System.Drawing.Color.Transparent;
            this.btnmodificar.BorderRadius = 10;
            this.btnmodificar.BorderSize = 1;
            this.btnmodificar.FlatAppearance.BorderSize = 0;
            this.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.ForeColor = System.Drawing.Color.Black;
            this.btnmodificar.Image = global::SistemaPymes.Properties.Resources.modificar;
            this.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmodificar.Location = new System.Drawing.Point(166, 21);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(153, 88);
            this.btnmodificar.TabIndex = 9;
            this.btnmodificar.Text = "  Modificar";
            this.btnmodificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnmodificar.UseVisualStyleBackColor = false;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.Transparent;
            this.btnguardar.BorderColor = System.Drawing.Color.Transparent;
            this.btnguardar.BorderRadius = 10;
            this.btnguardar.BorderSize = 1;
            this.btnguardar.FlatAppearance.BorderSize = 0;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.Black;
            this.btnguardar.Image = global::SistemaPymes.Properties.Resources.correcto__1_;
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.Location = new System.Drawing.Point(17, 21);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(142, 88);
            this.btnguardar.TabIndex = 8;
            this.btnguardar.Text = "  Guardar";
            this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 723);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.frmarticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgarticulos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgarticulos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private CustomControls.JECustom.JEButton btnsalir;
        private CustomControls.JECustom.JEButton btneliminar;
        private CustomControls.JECustom.JEButton btnmodificar;
        private CustomControls.JECustom.JEButton btnguardar;
        private JECustom.JETextBox txtcodigo;
        private JECustom.JETextBox txtdescripcion;
        private JECustom.JETextBox txtpventa;
        private JECustom.JETextBox txtpcompra;
        private JECustom.JETextBox txtexistencia;
        private JECustom.JETextBox txtsmaximo;
        private JECustom.JETextBox txtsminimo;
    }
}