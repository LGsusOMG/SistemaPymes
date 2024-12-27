namespace SistemaPymes
{
    partial class frmUsuarios
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
            this.dgusuarios = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtrol = new SistemaPymes.JECustom.JETextBox();
            this.txtclave = new SistemaPymes.JECustom.JETextBox();
            this.txtusuario = new SistemaPymes.JECustom.JETextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnsalir = new CustomControls.JECustom.JEButton();
            this.btneliminar = new CustomControls.JECustom.JEButton();
            this.btnmodificar = new CustomControls.JECustom.JEButton();
            this.btnguardar = new CustomControls.JECustom.JEButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgusuarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgusuarios
            // 
            this.dgusuarios.AllowUserToAddRows = false;
            this.dgusuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.dgusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgusuarios.Location = new System.Drawing.Point(4, 30);
            this.dgusuarios.Margin = new System.Windows.Forms.Padding(4);
            this.dgusuarios.Name = "dgusuarios";
            this.dgusuarios.RowHeadersWidth = 51;
            this.dgusuarios.Size = new System.Drawing.Size(930, 294);
            this.dgusuarios.TabIndex = 39;
            this.dgusuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgusuarios_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(626, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 29);
            this.label3.TabIndex = 34;
            this.label3.Text = "ROL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 29);
            this.label2.TabIndex = 33;
            this.label2.Text = "CLAVE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "USUARIO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtrol);
            this.groupBox1.Controls.Add(this.txtclave);
            this.groupBox1.Controls.Add(this.txtusuario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(936, 109);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // txtrol
            // 
            this.txtrol.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtrol.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtrol.BackColor = System.Drawing.SystemColors.Window;
            this.txtrol.BorderColor = System.Drawing.Color.Red;
            this.txtrol.BorderFocusColor = System.Drawing.Color.Orange;
            this.txtrol.BorderRadius = 10;
            this.txtrol.BorderSize = 2;
            this.txtrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtrol.Location = new System.Drawing.Point(631, 55);
            this.txtrol.Margin = new System.Windows.Forms.Padding(4);
            this.txtrol.Multiline = false;
            this.txtrol.Name = "txtrol";
            this.txtrol.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtrol.PasswordChar = false;
            this.txtrol.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.txtrol.PlaceholderText = "Rol";
            this.txtrol.Size = new System.Drawing.Size(298, 35);
            this.txtrol.TabIndex = 40;
            this.txtrol.Tag = "";
            this.txtrol.UnderlinedStyle = true;
            this.txtrol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtrol_KeyPress);
            // 
            // txtclave
            // 
            this.txtclave.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtclave.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtclave.BackColor = System.Drawing.SystemColors.Window;
            this.txtclave.BorderColor = System.Drawing.Color.Red;
            this.txtclave.BorderFocusColor = System.Drawing.Color.Orange;
            this.txtclave.BorderRadius = 10;
            this.txtclave.BorderSize = 2;
            this.txtclave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtclave.Location = new System.Drawing.Point(290, 55);
            this.txtclave.Margin = new System.Windows.Forms.Padding(4);
            this.txtclave.Multiline = false;
            this.txtclave.Name = "txtclave";
            this.txtclave.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtclave.PasswordChar = false;
            this.txtclave.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.txtclave.PlaceholderText = "Clave o Password";
            this.txtclave.Size = new System.Drawing.Size(333, 35);
            this.txtclave.TabIndex = 40;
            this.txtclave.Tag = "";
            this.txtclave.UnderlinedStyle = true;
            this.txtclave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtclave_KeyPress);
            // 
            // txtusuario
            // 
            this.txtusuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtusuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtusuario.BackColor = System.Drawing.SystemColors.Window;
            this.txtusuario.BorderColor = System.Drawing.Color.Red;
            this.txtusuario.BorderFocusColor = System.Drawing.Color.Orange;
            this.txtusuario.BorderRadius = 10;
            this.txtusuario.BorderSize = 2;
            this.txtusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtusuario.Location = new System.Drawing.Point(7, 55);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtusuario.Multiline = false;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtusuario.PasswordChar = false;
            this.txtusuario.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.txtusuario.PlaceholderText = "Usuario";
            this.txtusuario.Size = new System.Drawing.Size(275, 35);
            this.txtusuario.TabIndex = 40;
            this.txtusuario.Tag = "";
            this.txtusuario.UnderlinedStyle = true;
            this.txtusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtusuario_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgusuarios);
            this.groupBox2.Location = new System.Drawing.Point(9, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(934, 340);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registros";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnsalir);
            this.groupBox3.Controls.Add(this.btneliminar);
            this.groupBox3.Controls.Add(this.btnmodificar);
            this.groupBox3.Controls.Add(this.btnguardar);
            this.groupBox3.Location = new System.Drawing.Point(9, 501);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(934, 119);
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
            this.btnsalir.Location = new System.Drawing.Point(813, 21);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(115, 92);
            this.btnsalir.TabIndex = 11;
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
            this.btneliminar.TabIndex = 11;
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
            this.btnmodificar.TabIndex = 11;
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
            this.btnguardar.TabIndex = 11;
            this.btnguardar.Text = "  Guardar";
            this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 632);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.frmusuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgusuarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgusuarios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private JECustom.JETextBox txtclave;
        private JECustom.JETextBox txtusuario;
        private JECustom.JETextBox txtrol;
        private System.Windows.Forms.GroupBox groupBox3;
        private CustomControls.JECustom.JEButton btnsalir;
        private CustomControls.JECustom.JEButton btneliminar;
        private CustomControls.JECustom.JEButton btnmodificar;
        private CustomControls.JECustom.JEButton btnguardar;
    }
}