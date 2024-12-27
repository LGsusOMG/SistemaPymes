namespace SistemaPymes
{
    partial class frmSushis
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
            this.dgSushis = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.txtdescripcion = new SistemaPymes.JECustom.JETextBox();
            this.txtPrecio = new SistemaPymes.JECustom.JETextBox();
            this.txtNombreSushi = new SistemaPymes.JECustom.JETextBox();
            this.txtcodigo = new SistemaPymes.JECustom.JETextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbRegistros = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsalir = new CustomControls.JECustom.JEButton();
            this.btneliminar = new CustomControls.JECustom.JEButton();
            this.btnmodificar = new CustomControls.JECustom.JEButton();
            this.btnguardar = new CustomControls.JECustom.JEButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgSushis)).BeginInit();
            this.gbDatos.SuspendLayout();
            this.gbRegistros.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgSushis
            // 
            this.dgSushis.AllowUserToAddRows = false;
            this.dgSushis.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.dgSushis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSushis.Location = new System.Drawing.Point(7, 37);
            this.dgSushis.Margin = new System.Windows.Forms.Padding(4);
            this.dgSushis.Name = "dgSushis";
            this.dgSushis.RowHeadersWidth = 51;
            this.dgSushis.Size = new System.Drawing.Size(836, 313);
            this.dgSushis.TabIndex = 40;
            this.dgSushis.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSushis_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(709, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 29);
            this.label4.TabIndex = 37;
            this.label4.Text = "PRECIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(309, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 29);
            this.label2.TabIndex = 35;
            this.label2.Text = "DESCRIPCION";
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.txtdescripcion);
            this.gbDatos.Controls.Add(this.txtPrecio);
            this.gbDatos.Controls.Add(this.txtNombreSushi);
            this.gbDatos.Controls.Add(this.txtcodigo);
            this.gbDatos.Controls.Add(this.label3);
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Controls.Add(this.label4);
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Location = new System.Drawing.Point(16, 12);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(850, 113);
            this.gbDatos.TabIndex = 42;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
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
            this.txtdescripcion.Location = new System.Drawing.Point(314, 61);
            this.txtdescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtdescripcion.Multiline = false;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtdescripcion.PasswordChar = false;
            this.txtdescripcion.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.txtdescripcion.PlaceholderText = "Descripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(392, 35);
            this.txtdescripcion.TabIndex = 1;
            this.txtdescripcion.Tag = "";
            this.txtdescripcion.UnderlinedStyle = true;
            this.txtdescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdescripcion_KeyPress);
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
            this.txtPrecio.Location = new System.Drawing.Point(714, 61);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.Multiline = false;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPrecio.PasswordChar = false;
            this.txtPrecio.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.txtPrecio.PlaceholderText = "Precio Venta";
            this.txtPrecio.Size = new System.Drawing.Size(116, 35);
            this.txtPrecio.TabIndex = 2;
            this.txtPrecio.Tag = "";
            this.txtPrecio.UnderlinedStyle = true;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtNombreSushi
            // 
            this.txtNombreSushi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNombreSushi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNombreSushi.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombreSushi.BorderColor = System.Drawing.Color.Red;
            this.txtNombreSushi.BorderFocusColor = System.Drawing.Color.Orange;
            this.txtNombreSushi.BorderRadius = 10;
            this.txtNombreSushi.BorderSize = 2;
            this.txtNombreSushi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreSushi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombreSushi.Location = new System.Drawing.Point(141, 61);
            this.txtNombreSushi.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreSushi.Multiline = false;
            this.txtNombreSushi.Name = "txtNombreSushi";
            this.txtNombreSushi.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNombreSushi.PasswordChar = false;
            this.txtNombreSushi.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.txtNombreSushi.PlaceholderText = "Nombre Sushi";
            this.txtNombreSushi.Size = new System.Drawing.Size(165, 35);
            this.txtNombreSushi.TabIndex = 0;
            this.txtNombreSushi.Tag = "";
            this.txtNombreSushi.UnderlinedStyle = true;
            this.txtNombreSushi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreSushi_KeyPress);
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
            this.txtcodigo.Location = new System.Drawing.Point(12, 61);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtcodigo.Multiline = false;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtcodigo.PasswordChar = false;
            this.txtcodigo.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.txtcodigo.PlaceholderText = "Codigo";
            this.txtcodigo.Size = new System.Drawing.Size(121, 35);
            this.txtcodigo.TabIndex = 0;
            this.txtcodigo.Tag = "";
            this.txtcodigo.UnderlinedStyle = true;
            this.txtcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(147, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 29);
            this.label3.TabIndex = 38;
            this.label3.Text = "NOMBRE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 29);
            this.label1.TabIndex = 38;
            this.label1.Text = "CÓDIGO";
            // 
            // gbRegistros
            // 
            this.gbRegistros.Controls.Add(this.dgSushis);
            this.gbRegistros.Location = new System.Drawing.Point(16, 150);
            this.gbRegistros.Name = "gbRegistros";
            this.gbRegistros.Size = new System.Drawing.Size(850, 371);
            this.gbRegistros.TabIndex = 43;
            this.gbRegistros.TabStop = false;
            this.gbRegistros.Text = "Registros";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsalir);
            this.groupBox1.Controls.Add(this.btneliminar);
            this.groupBox1.Controls.Add(this.btnmodificar);
            this.groupBox1.Controls.Add(this.btnguardar);
            this.groupBox1.Location = new System.Drawing.Point(16, 537);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(850, 119);
            this.groupBox1.TabIndex = 57;
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
            this.btnsalir.Location = new System.Drawing.Point(705, 21);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(115, 92);
            this.btnsalir.TabIndex = 6;
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
            this.btneliminar.Size = new System.Drawing.Size(142, 92);
            this.btneliminar.TabIndex = 5;
            this.btneliminar.Text = "  Eliminar";
            this.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btnmodificar_Click);
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
            this.btnmodificar.TabIndex = 4;
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
            this.btnguardar.TabIndex = 3;
            this.btnguardar.Text = "  Guardar";
            this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // frmSushis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 673);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbRegistros);
            this.Controls.Add(this.gbDatos);
            this.Name = "frmSushis";
            this.Text = "Sushis";
            this.Load += new System.EventHandler(this.frmSushis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSushis)).EndInit();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.gbRegistros.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgSushis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.GroupBox gbRegistros;
        private JECustom.JETextBox txtdescripcion;
        private JECustom.JETextBox txtcodigo;
        private System.Windows.Forms.Label label1;
        private JECustom.JETextBox txtPrecio;
        private System.Windows.Forms.GroupBox groupBox1;
        private CustomControls.JECustom.JEButton btnsalir;
        private CustomControls.JECustom.JEButton btneliminar;
        private CustomControls.JECustom.JEButton btnmodificar;
        private CustomControls.JECustom.JEButton btnguardar;
        private JECustom.JETextBox txtNombreSushi;
        private System.Windows.Forms.Label label3;
    }
}