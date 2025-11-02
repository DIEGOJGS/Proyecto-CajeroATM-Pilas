namespace CajeroATM
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpEntrada = new System.Windows.Forms.GroupBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCargarMock = new System.Windows.Forms.Button();
            this.grpHistorial = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numTop = new System.Windows.Forms.NumericUpDown();
            this.btnVerUltimas = new System.Windows.Forms.Button();
            this.lstHistorial = new System.Windows.Forms.ListBox();
            this.Anular = new System.Windows.Forms.Button();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.btnAnularSeleccionado = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpEntrada.SuspendLayout();
            this.grpHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEntrada
            // 
            this.grpEntrada.Controls.Add(this.cmbTipo);
            this.grpEntrada.Controls.Add(this.label4);
            this.grpEntrada.Controls.Add(this.btnRegistrar);
            this.grpEntrada.Controls.Add(this.txtMonto);
            this.grpEntrada.Controls.Add(this.label2);
            this.grpEntrada.Controls.Add(this.txtDetalle);
            this.grpEntrada.Controls.Add(this.label1);
            this.grpEntrada.Location = new System.Drawing.Point(54, 94);
            this.grpEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.grpEntrada.Name = "grpEntrada";
            this.grpEntrada.Padding = new System.Windows.Forms.Padding(2);
            this.grpEntrada.Size = new System.Drawing.Size(223, 161);
            this.grpEntrada.TabIndex = 0;
            this.grpEntrada.TabStop = false;
            this.grpEntrada.Text = "Registrar Transaccion";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(84, 30);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(108, 21);
            this.cmbTipo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tipo";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegistrar.Location = new System.Drawing.Point(16, 106);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(193, 50);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar (PUSH)";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(84, 83);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(2);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(108, 20);
            this.txtMonto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Monto (S/.)";
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(84, 56);
            this.txtDetalle.Margin = new System.Windows.Forms.Padding(2);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(108, 20);
            this.txtDetalle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripcion";
            // 
            // btnCargarMock
            // 
            this.btnCargarMock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnCargarMock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarMock.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCargarMock.Location = new System.Drawing.Point(590, 61);
            this.btnCargarMock.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargarMock.Name = "btnCargarMock";
            this.btnCargarMock.Size = new System.Drawing.Size(135, 44);
            this.btnCargarMock.TabIndex = 5;
            this.btnCargarMock.Text = "Cargar datos de prueba";
            this.btnCargarMock.UseVisualStyleBackColor = false;
            this.btnCargarMock.Click += new System.EventHandler(this.btnCargarMock_Click);
            // 
            // grpHistorial
            // 
            this.grpHistorial.Controls.Add(this.label3);
            this.grpHistorial.Controls.Add(this.numTop);
            this.grpHistorial.Controls.Add(this.btnVerUltimas);
            this.grpHistorial.Controls.Add(this.lstHistorial);
            this.grpHistorial.Location = new System.Drawing.Point(303, 103);
            this.grpHistorial.Margin = new System.Windows.Forms.Padding(2);
            this.grpHistorial.Name = "grpHistorial";
            this.grpHistorial.Padding = new System.Windows.Forms.Padding(2);
            this.grpHistorial.Size = new System.Drawing.Size(422, 172);
            this.grpHistorial.TabIndex = 1;
            this.grpHistorial.TabStop = false;
            this.grpHistorial.Text = "Últimas transacciones (LIFO)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Top";
            // 
            // numTop
            // 
            this.numTop.Location = new System.Drawing.Point(82, 132);
            this.numTop.Margin = new System.Windows.Forms.Padding(2);
            this.numTop.Name = "numTop";
            this.numTop.Size = new System.Drawing.Size(90, 20);
            this.numTop.TabIndex = 2;
            this.numTop.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnVerUltimas
            // 
            this.btnVerUltimas.Location = new System.Drawing.Point(22, 132);
            this.btnVerUltimas.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerUltimas.Name = "btnVerUltimas";
            this.btnVerUltimas.Size = new System.Drawing.Size(56, 19);
            this.btnVerUltimas.TabIndex = 1;
            this.btnVerUltimas.Text = "Ver últimas (Top 10)";
            this.btnVerUltimas.UseVisualStyleBackColor = true;
            this.btnVerUltimas.Click += new System.EventHandler(this.btnVerUltimas_Click);
            // 
            // lstHistorial
            // 
            this.lstHistorial.FormattingEnabled = true;
            this.lstHistorial.Items.AddRange(new object[] {
            "..."});
            this.lstHistorial.Location = new System.Drawing.Point(15, 20);
            this.lstHistorial.Margin = new System.Windows.Forms.Padding(2);
            this.lstHistorial.Name = "lstHistorial";
            this.lstHistorial.Size = new System.Drawing.Size(395, 108);
            this.lstHistorial.TabIndex = 0;
            // 
            // Anular
            // 
            this.Anular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.Anular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Anular.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Anular.Location = new System.Drawing.Point(54, 260);
            this.Anular.Name = "Anular";
            this.Anular.Size = new System.Drawing.Size(223, 38);
            this.Anular.TabIndex = 2;
            this.Anular.Text = "Anular Ultima Transaccion";
            this.Anular.UseVisualStyleBackColor = false;
            this.Anular.Click += new System.EventHandler(this.Anular_Click);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(312, 302);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(0, 31);
            this.lblSaldo.TabIndex = 3;
            // 
            // btnAnularSeleccionado
            // 
            this.btnAnularSeleccionado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnAnularSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnularSeleccionado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAnularSeleccionado.Location = new System.Drawing.Point(54, 304);
            this.btnAnularSeleccionado.Name = "btnAnularSeleccionado";
            this.btnAnularSeleccionado.Size = new System.Drawing.Size(223, 38);
            this.btnAnularSeleccionado.TabIndex = 4;
            this.btnAnularSeleccionado.Text = "Anular Transaccion Seleccionado";
            this.btnAnularSeleccionado.UseVisualStyleBackColor = false;
            this.btnAnularSeleccionado.Click += new System.EventHandler(this.btnAnularSeleccionado_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(243, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(276, 55);
            this.label5.TabIndex = 7;
            this.label5.Text = "CajeroATM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(796, 366);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAnularSeleccionado);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.btnCargarMock);
            this.Controls.Add(this.Anular);
            this.Controls.Add(this.grpHistorial);
            this.Controls.Add(this.grpEntrada);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Historial de Transacciones - Pila (LIFO)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpEntrada.ResumeLayout(false);
            this.grpEntrada.PerformLayout();
            this.grpHistorial.ResumeLayout(false);
            this.grpHistorial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Button btnCargarMock;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.GroupBox grpHistorial;
        private System.Windows.Forms.ListBox lstHistorial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numTop;
        private System.Windows.Forms.Button btnVerUltimas;
        private System.Windows.Forms.Button Anular;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Button btnAnularSeleccionado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label5;
    }
}

