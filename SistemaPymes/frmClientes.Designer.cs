namespace SistemaPymes
{
    partial class frmClientes
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
            this.dgclientes = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtnombre = new SistemaPymes.JECustom.JETextBox();
            this.txtrfc = new SistemaPymes.JECustom.JETextBox();
            this.txtemail = new SistemaPymes.JECustom.JETextBox();
            this.txttelefono = new SistemaPymes.JECustom.JETextBox();
            this.txtdireccion = new SistemaPymes.JECustom.JETextBox();
            this.txtcodigo = new SistemaPymes.JECustom.JETextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnsalir = new CustomControls.JECustom.JEButton();
            this.btneliminar = new CustomControls.JECustom.JEButton();
            this.btnmodificar = new CustomControls.JECustom.JEButton();
            this.btnguardar = new CustomControls.JECustom.JEButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgclientes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "CÓDIGO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "RFC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(465, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "NOMBRE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "DIRECCION";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(366, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "TELEFONO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(610, 105);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "EMAIL";
            // 
            // dgclientes
            // 
            this.dgclientes.AllowUserToAddRows = false;
            this.dgclientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.dgclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgclientes.Location = new System.Drawing.Point(7, 32);
            this.dgclientes.Margin = new System.Windows.Forms.Padding(4);
            this.dgclientes.Name = "dgclientes";
            this.dgclientes.RowHeadersWidth = 51;
            this.dgclientes.Size = new System.Drawing.Size(924, 294);
            this.dgclientes.TabIndex = 50;
            this.dgclientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgclientes_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.txtrfc);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.txttelefono);
            this.groupBox1.Controls.Add(this.txtdireccion);
            this.groupBox1.Controls.Add(this.txtcodigo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(935, 193);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
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
            this.txtnombre.Enabled = false;
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtnombre.Location = new System.Drawing.Point(470, 57);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombre.Multiline = false;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtnombre.PasswordChar = false;
            this.txtnombre.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.txtnombre.PlaceholderText = "Nombre";
            this.txtnombre.Size = new System.Drawing.Size(457, 35);
            this.txtnombre.TabIndex = 2;
            this.txtnombre.Tag = "";
            this.txtnombre.UnderlinedStyle = true;
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            // 
            // txtrfc
            // 
            this.txtrfc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtrfc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtrfc.BackColor = System.Drawing.SystemColors.Window;
            this.txtrfc.BorderColor = System.Drawing.Color.Red;
            this.txtrfc.BorderFocusColor = System.Drawing.Color.Orange;
            this.txtrfc.BorderRadius = 10;
            this.txtrfc.BorderSize = 2;
            this.txtrfc.Enabled = false;
            this.txtrfc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrfc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtrfc.Location = new System.Drawing.Point(166, 57);
            this.txtrfc.Margin = new System.Windows.Forms.Padding(4);
            this.txtrfc.Multiline = false;
            this.txtrfc.Name = "txtrfc";
            this.txtrfc.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtrfc.PasswordChar = false;
            this.txtrfc.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.txtrfc.PlaceholderText = "RFC";
            this.txtrfc.Size = new System.Drawing.Size(296, 35);
            this.txtrfc.TabIndex = 1;
            this.txtrfc.Tag = "";
            this.txtrfc.UnderlinedStyle = true;
            this.txtrfc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtrfc_KeyPress);
            // 
            // txtemail
            // 
            this.txtemail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtemail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtemail.BackColor = System.Drawing.SystemColors.Window;
            this.txtemail.BorderColor = System.Drawing.Color.Red;
            this.txtemail.BorderFocusColor = System.Drawing.Color.Orange;
            this.txtemail.BorderRadius = 10;
            this.txtemail.BorderSize = 2;
            this.txtemail.Enabled = false;
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtemail.Location = new System.Drawing.Point(615, 137);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4);
            this.txtemail.Multiline = false;
            this.txtemail.Name = "txtemail";
            this.txtemail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtemail.PasswordChar = false;
            this.txtemail.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.txtemail.PlaceholderText = "Telefono";
            this.txtemail.Size = new System.Drawing.Size(312, 35);
            this.txtemail.TabIndex = 5;
            this.txtemail.Tag = "";
            this.txtemail.UnderlinedStyle = true;
            this.txtemail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtemail_KeyPress);
            // 
            // txttelefono
            // 
            this.txttelefono.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txttelefono.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txttelefono.BackColor = System.Drawing.SystemColors.Window;
            this.txttelefono.BorderColor = System.Drawing.Color.Red;
            this.txttelefono.BorderFocusColor = System.Drawing.Color.Orange;
            this.txttelefono.BorderRadius = 10;
            this.txttelefono.BorderSize = 2;
            this.txttelefono.Enabled = false;
            this.txttelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txttelefono.Location = new System.Drawing.Point(371, 137);
            this.txttelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txttelefono.Multiline = false;
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txttelefono.PasswordChar = false;
            this.txttelefono.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.txttelefono.PlaceholderText = "Telefono";
            this.txttelefono.Size = new System.Drawing.Size(219, 35);
            this.txttelefono.TabIndex = 4;
            this.txttelefono.Tag = "";
            this.txttelefono.UnderlinedStyle = true;
            this.txttelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttelefono_KeyPress);
            // 
            // txtdireccion
            // 
            this.txtdireccion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtdireccion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtdireccion.BackColor = System.Drawing.SystemColors.Window;
            this.txtdireccion.BorderColor = System.Drawing.Color.Red;
            this.txtdireccion.BorderFocusColor = System.Drawing.Color.Orange;
            this.txtdireccion.BorderRadius = 10;
            this.txtdireccion.BorderSize = 2;
            this.txtdireccion.Enabled = false;
            this.txtdireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtdireccion.Location = new System.Drawing.Point(8, 137);
            this.txtdireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtdireccion.Multiline = false;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtdireccion.PasswordChar = false;
            this.txtdireccion.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.txtdireccion.PlaceholderText = "Direccion";
            this.txtdireccion.Size = new System.Drawing.Size(350, 35);
            this.txtdireccion.TabIndex = 3;
            this.txtdireccion.Tag = "";
            this.txtdireccion.UnderlinedStyle = true;
            this.txtdireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdireccion_KeyPress);
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
            this.txtcodigo.Location = new System.Drawing.Point(8, 57);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtcodigo.Multiline = false;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtcodigo.PasswordChar = false;
            this.txtcodigo.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.txtcodigo.PlaceholderText = "Codigo";
            this.txtcodigo.Size = new System.Drawing.Size(150, 35);
            this.txtcodigo.TabIndex = 0;
            this.txtcodigo.Tag = "";
            this.txtcodigo.UnderlinedStyle = true;
            this.txtcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigo_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgclientes);
            this.groupBox2.Location = new System.Drawing.Point(17, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(935, 342);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registros";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnsalir);
            this.groupBox3.Controls.Add(this.btneliminar);
            this.groupBox3.Controls.Add(this.btnmodificar);
            this.groupBox3.Controls.Add(this.btnguardar);
            this.groupBox3.Location = new System.Drawing.Point(17, 585);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(935, 119);
            this.groupBox3.TabIndex = 57;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Acciones";
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
            this.btnsalir.Location = new System.Drawing.Point(812, 21);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(115, 92);
            this.btnsalir.TabIndex = 9;
            this.btnsalir.Text = "  Salir";
            this.btnsalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
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
            this.btneliminar.Size = new System.Drawing.Size(142, 92);
            this.btneliminar.TabIndex = 8;
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
            this.btnmodificar.Size = new System.Drawing.Size(153, 92);
            this.btnmodificar.TabIndex = 7;
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
            this.btnguardar.Size = new System.Drawing.Size(142, 92);
            this.btnguardar.TabIndex = 6;
            this.btnguardar.Text = "  Guardar";
            this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 728);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.frmclientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgclientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgclientes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private JECustom.JETextBox txtcodigo;
        private JECustom.JETextBox txtrfc;
        private JECustom.JETextBox txtnombre;
        private JECustom.JETextBox txtemail;
        private JECustom.JETextBox txttelefono;
        private JECustom.JETextBox txtdireccion;
        private System.Windows.Forms.GroupBox groupBox3;
        private CustomControls.JECustom.JEButton btnsalir;
        private CustomControls.JECustom.JEButton btneliminar;
        private CustomControls.JECustom.JEButton btnmodificar;
        private CustomControls.JECustom.JEButton btnguardar;
    }
}