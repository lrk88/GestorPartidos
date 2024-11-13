namespace UI
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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnModificarMarcador = new System.Windows.Forms.Button();
            this.btnEliminarPartido = new System.Windows.Forms.Button();
            this.btnAgregarPartido = new System.Windows.Forms.Button();
            this.txtMarcadorVisitante = new System.Windows.Forms.TextBox();
            this.txtMarcadorLocal = new System.Windows.Forms.TextBox();
            this.txtIdModificar = new System.Windows.Forms.TextBox();
            this.txtIdEliminar = new System.Windows.Forms.TextBox();
            this.dtpFechaPartido = new System.Windows.Forms.DateTimePicker();
            this.txtEquipoVisitante = new System.Windows.Forms.TextBox();
            this.txtEquipoLocal = new System.Windows.Forms.TextBox();
            this.cmbDeporte = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(531, 345);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "MARCADOR";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(611, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Visitante";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(533, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Local";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(531, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Actualizar Marcador Partido, ingrese ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Eliminar Partido, ingrese ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Fecha Partido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Equipo Visitante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Equipo Local";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Deporte";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(274, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(722, 226);
            this.dataGridView1.TabIndex = 33;
            // 
            // btnModificarMarcador
            // 
            this.btnModificarMarcador.Location = new System.Drawing.Point(534, 410);
            this.btnModificarMarcador.Name = "btnModificarMarcador";
            this.btnModificarMarcador.Size = new System.Drawing.Size(63, 37);
            this.btnModificarMarcador.TabIndex = 32;
            this.btnModificarMarcador.Text = "Modificar Marcador";
            this.btnModificarMarcador.UseVisualStyleBackColor = true;
            this.btnModificarMarcador.Click += new System.EventHandler(this.btnModificarMarcador_Click);
            // 
            // btnEliminarPartido
            // 
            this.btnEliminarPartido.Location = new System.Drawing.Point(274, 337);
            this.btnEliminarPartido.Name = "btnEliminarPartido";
            this.btnEliminarPartido.Size = new System.Drawing.Size(58, 50);
            this.btnEliminarPartido.TabIndex = 31;
            this.btnEliminarPartido.Text = "Eliminar Partido";
            this.btnEliminarPartido.UseVisualStyleBackColor = true;
            this.btnEliminarPartido.Click += new System.EventHandler(this.btnEliminarPartido_Click);
            // 
            // btnAgregarPartido
            // 
            this.btnAgregarPartido.Location = new System.Drawing.Point(20, 315);
            this.btnAgregarPartido.Name = "btnAgregarPartido";
            this.btnAgregarPartido.Size = new System.Drawing.Size(55, 50);
            this.btnAgregarPartido.TabIndex = 30;
            this.btnAgregarPartido.Text = "Agregar Partido";
            this.btnAgregarPartido.UseVisualStyleBackColor = true;
            this.btnAgregarPartido.Click += new System.EventHandler(this.btnAgregarPartido_Click);
            // 
            // txtMarcadorVisitante
            // 
            this.txtMarcadorVisitante.Location = new System.Drawing.Point(614, 384);
            this.txtMarcadorVisitante.Name = "txtMarcadorVisitante";
            this.txtMarcadorVisitante.Size = new System.Drawing.Size(32, 20);
            this.txtMarcadorVisitante.TabIndex = 29;
            // 
            // txtMarcadorLocal
            // 
            this.txtMarcadorLocal.Location = new System.Drawing.Point(534, 384);
            this.txtMarcadorLocal.Name = "txtMarcadorLocal";
            this.txtMarcadorLocal.Size = new System.Drawing.Size(32, 20);
            this.txtMarcadorLocal.TabIndex = 28;
            // 
            // txtIdModificar
            // 
            this.txtIdModificar.Location = new System.Drawing.Point(534, 309);
            this.txtIdModificar.Name = "txtIdModificar";
            this.txtIdModificar.Size = new System.Drawing.Size(152, 20);
            this.txtIdModificar.TabIndex = 27;
            // 
            // txtIdEliminar
            // 
            this.txtIdEliminar.Location = new System.Drawing.Point(274, 306);
            this.txtIdEliminar.Name = "txtIdEliminar";
            this.txtIdEliminar.Size = new System.Drawing.Size(182, 20);
            this.txtIdEliminar.TabIndex = 26;
            // 
            // dtpFechaPartido
            // 
            this.dtpFechaPartido.Location = new System.Drawing.Point(20, 271);
            this.dtpFechaPartido.Name = "dtpFechaPartido";
            this.dtpFechaPartido.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaPartido.TabIndex = 25;
            // 
            // txtEquipoVisitante
            // 
            this.txtEquipoVisitante.Location = new System.Drawing.Point(24, 191);
            this.txtEquipoVisitante.Name = "txtEquipoVisitante";
            this.txtEquipoVisitante.Size = new System.Drawing.Size(196, 20);
            this.txtEquipoVisitante.TabIndex = 24;
            // 
            // txtEquipoLocal
            // 
            this.txtEquipoLocal.Location = new System.Drawing.Point(23, 116);
            this.txtEquipoLocal.Name = "txtEquipoLocal";
            this.txtEquipoLocal.Size = new System.Drawing.Size(197, 20);
            this.txtEquipoLocal.TabIndex = 23;
            // 
            // cmbDeporte
            // 
            this.cmbDeporte.FormattingEnabled = true;
            this.cmbDeporte.Location = new System.Drawing.Point(23, 42);
            this.cmbDeporte.Name = "cmbDeporte";
            this.cmbDeporte.Size = new System.Drawing.Size(197, 21);
            this.cmbDeporte.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(271, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "TABLA PARTIDOS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 486);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnModificarMarcador);
            this.Controls.Add(this.btnEliminarPartido);
            this.Controls.Add(this.btnAgregarPartido);
            this.Controls.Add(this.txtMarcadorVisitante);
            this.Controls.Add(this.txtMarcadorLocal);
            this.Controls.Add(this.txtIdModificar);
            this.Controls.Add(this.txtIdEliminar);
            this.Controls.Add(this.dtpFechaPartido);
            this.Controls.Add(this.txtEquipoVisitante);
            this.Controls.Add(this.txtEquipoLocal);
            this.Controls.Add(this.cmbDeporte);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnModificarMarcador;
        private System.Windows.Forms.Button btnEliminarPartido;
        private System.Windows.Forms.Button btnAgregarPartido;
        private System.Windows.Forms.TextBox txtMarcadorVisitante;
        private System.Windows.Forms.TextBox txtMarcadorLocal;
        private System.Windows.Forms.TextBox txtIdModificar;
        private System.Windows.Forms.TextBox txtIdEliminar;
        private System.Windows.Forms.DateTimePicker dtpFechaPartido;
        private System.Windows.Forms.TextBox txtEquipoVisitante;
        private System.Windows.Forms.TextBox txtEquipoLocal;
        private System.Windows.Forms.ComboBox cmbDeporte;
        private System.Windows.Forms.Label label10;
    }
}

