namespace pryPonceCarlosAgistinIEFI
{
    partial class FrmEIFI
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtpuntaje = new System.Windows.Forms.TextBox();
            this.cmbpais = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtingreso = new System.Windows.Forms.TextBox();
            this.btnpais = new System.Windows.Forms.Button();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.lblRegistrarPais = new System.Windows.Forms.Label();
            this.umEdad = new System.Windows.Forms.NumericUpDown();
            this.lbledad = new System.Windows.Forms.Label();
            this.rbnfemenino = new System.Windows.Forms.RadioButton();
            this.rbnmasculino = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.lblpuntaje = new System.Windows.Forms.Label();
            this.lblingreso = new System.Windows.Forms.Label();
            this.lbltipodesexo = new System.Windows.Forms.Label();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblapellido = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.umEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // txtpuntaje
            // 
            this.txtpuntaje.Location = new System.Drawing.Point(271, 334);
            this.txtpuntaje.Name = "txtpuntaje";
            this.txtpuntaje.Size = new System.Drawing.Size(100, 20);
            this.txtpuntaje.TabIndex = 47;
            this.txtpuntaje.TextChanged += new System.EventHandler(this.txtpuntaje_TextChanged);
            // 
            // cmbpais
            // 
            this.cmbpais.FormattingEnabled = true;
            this.cmbpais.Location = new System.Drawing.Point(271, 297);
            this.cmbpais.Name = "cmbpais";
            this.cmbpais.Size = new System.Drawing.Size(121, 21);
            this.cmbpais.TabIndex = 46;
            this.cmbpais.SelectedIndexChanged += new System.EventHandler(this.cmbpais_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "PAIS:";
            // 
            // txtingreso
            // 
            this.txtingreso.Location = new System.Drawing.Point(271, 270);
            this.txtingreso.Name = "txtingreso";
            this.txtingreso.Size = new System.Drawing.Size(100, 20);
            this.txtingreso.TabIndex = 44;
            this.txtingreso.TextChanged += new System.EventHandler(this.txtingreso_TextChanged);
            // 
            // btnpais
            // 
            this.btnpais.Location = new System.Drawing.Point(227, 468);
            this.btnpais.Name = "btnpais";
            this.btnpais.Size = new System.Drawing.Size(75, 23);
            this.btnpais.TabIndex = 43;
            this.btnpais.Text = "Agregar";
            this.btnpais.UseVisualStyleBackColor = true;
            this.btnpais.Click += new System.EventHandler(this.btnpais_Click);
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(202, 433);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(100, 20);
            this.txtPais.TabIndex = 42;
            // 
            // lblRegistrarPais
            // 
            this.lblRegistrarPais.AutoSize = true;
            this.lblRegistrarPais.Location = new System.Drawing.Point(129, 436);
            this.lblRegistrarPais.Name = "lblRegistrarPais";
            this.lblRegistrarPais.Size = new System.Drawing.Size(67, 13);
            this.lblRegistrarPais.TabIndex = 41;
            this.lblRegistrarPais.Text = "Agregar Pais";
            // 
            // umEdad
            // 
            this.umEdad.Enabled = false;
            this.umEdad.Location = new System.Drawing.Point(242, 145);
            this.umEdad.Name = "umEdad";
            this.umEdad.Size = new System.Drawing.Size(100, 20);
            this.umEdad.TabIndex = 40;
            this.umEdad.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.umEdad.ValueChanged += new System.EventHandler(this.umEdad_ValueChanged);
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.Location = new System.Drawing.Point(122, 152);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(40, 13);
            this.lbledad.TabIndex = 39;
            this.lbledad.Text = "EDAD:";
            // 
            // rbnfemenino
            // 
            this.rbnfemenino.AutoSize = true;
            this.rbnfemenino.Location = new System.Drawing.Point(353, 226);
            this.rbnfemenino.Name = "rbnfemenino";
            this.rbnfemenino.Size = new System.Drawing.Size(81, 17);
            this.rbnfemenino.TabIndex = 38;
            this.rbnfemenino.TabStop = true;
            this.rbnfemenino.Text = "FEMENINO";
            this.rbnfemenino.UseVisualStyleBackColor = true;
            // 
            // rbnmasculino
            // 
            this.rbnmasculino.AutoSize = true;
            this.rbnmasculino.Location = new System.Drawing.Point(242, 226);
            this.rbnmasculino.Name = "rbnmasculino";
            this.rbnmasculino.Size = new System.Drawing.Size(88, 17);
            this.rbnmasculino.TabIndex = 37;
            this.rbnmasculino.TabStop = true;
            this.rbnmasculino.Text = "MASCULINO";
            this.rbnmasculino.UseVisualStyleBackColor = true;
            this.rbnmasculino.CheckedChanged += new System.EventHandler(this.rbnmasculino_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(183, -56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 44);
            this.label2.TabIndex = 36;
            this.label2.Text = "CLUB LOS SAUCE";
            // 
            // btnregistrar
            // 
            this.btnregistrar.Location = new System.Drawing.Point(132, 388);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(75, 23);
            this.btnregistrar.TabIndex = 35;
            this.btnregistrar.Text = "REGISTRAR";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click_1);
            // 
            // lblpuntaje
            // 
            this.lblpuntaje.AutoSize = true;
            this.lblpuntaje.Location = new System.Drawing.Point(122, 337);
            this.lblpuntaje.Name = "lblpuntaje";
            this.lblpuntaje.Size = new System.Drawing.Size(59, 13);
            this.lblpuntaje.TabIndex = 34;
            this.lblpuntaje.Text = "PUNTAJE:";
            // 
            // lblingreso
            // 
            this.lblingreso.AutoSize = true;
            this.lblingreso.Location = new System.Drawing.Point(129, 277);
            this.lblingreso.Name = "lblingreso";
            this.lblingreso.Size = new System.Drawing.Size(59, 13);
            this.lblingreso.TabIndex = 33;
            this.lblingreso.Text = "INGRESO:";
            // 
            // lbltipodesexo
            // 
            this.lbltipodesexo.AutoSize = true;
            this.lbltipodesexo.Location = new System.Drawing.Point(122, 230);
            this.lbltipodesexo.Name = "lbltipodesexo";
            this.lbltipodesexo.Size = new System.Drawing.Size(85, 13);
            this.lbltipodesexo.TabIndex = 32;
            this.lbltipodesexo.Text = "TIPO DE SEXO:";
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(242, 110);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(100, 20);
            this.txtapellido.TabIndex = 31;
            this.txtapellido.TextChanged += new System.EventHandler(this.txtapellido_TextChanged);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(242, 78);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 30;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.Location = new System.Drawing.Point(122, 117);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(62, 13);
            this.lblapellido.TabIndex = 29;
            this.lblapellido.Text = "APELLIDO:";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(128, 85);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(60, 13);
            this.lblnombre.TabIndex = 28;
            this.lblnombre.Text = "NOMBRE :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(117, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 44);
            this.label1.TabIndex = 48;
            this.label1.Text = "CLUB LOS SAUCE";
            // 
            // FrmEIFI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 541);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpuntaje);
            this.Controls.Add(this.cmbpais);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtingreso);
            this.Controls.Add(this.btnpais);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.lblRegistrarPais);
            this.Controls.Add(this.umEdad);
            this.Controls.Add(this.lbledad);
            this.Controls.Add(this.rbnfemenino);
            this.Controls.Add(this.rbnmasculino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.lblpuntaje);
            this.Controls.Add(this.lblingreso);
            this.Controls.Add(this.lbltipodesexo);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lblapellido);
            this.Controls.Add(this.lblnombre);
            this.Name = "FrmEIFI";
            this.Text = "PryPonceCarlosAgustin";
            this.Load += new System.EventHandler(this.FrmEIFI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.umEdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpuntaje;
        private System.Windows.Forms.ComboBox cmbpais;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtingreso;
        private System.Windows.Forms.Button btnpais;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label lblRegistrarPais;
        private System.Windows.Forms.NumericUpDown umEdad;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.RadioButton rbnfemenino;
        private System.Windows.Forms.RadioButton rbnmasculino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Label lblpuntaje;
        private System.Windows.Forms.Label lblingreso;
        private System.Windows.Forms.Label lbltipodesexo;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label label1;
    }
}

