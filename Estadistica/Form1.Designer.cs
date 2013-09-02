namespace Estadistica
{
    partial class Form1
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
            this.dtgrDatos = new System.Windows.Forms.DataGridView();
            this.clmDatos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrTabla = new System.Windows.Forms.DataGridView();
            this.clmNoClase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInterClase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFrecuencua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFrecAcu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFrecuenciaRelativa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFrecuenciaRelativaAcumulada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMarcaClase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGrados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDesvEsta = new System.Windows.Forms.Label();
            this.lblModa = new System.Windows.Forms.Label();
            this.lblMediana = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblVarianza = new System.Windows.Forms.Label();
            this.lblIntClase = new System.Windows.Forms.Label();
            this.lblNoClase = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrTabla)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgrDatos
            // 
            this.dtgrDatos.AllowUserToOrderColumns = true;
            this.dtgrDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtgrDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmDatos});
            this.dtgrDatos.Location = new System.Drawing.Point(12, 12);
            this.dtgrDatos.Name = "dtgrDatos";
            this.dtgrDatos.Size = new System.Drawing.Size(106, 309);
            this.dtgrDatos.TabIndex = 0;
            this.dtgrDatos.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.validarDato);
            this.dtgrDatos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.cuandoValorCambia);
            this.dtgrDatos.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.cuandoDatosCambian);
            this.dtgrDatos.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.cuandoDatosCambian);
            // 
            // clmDatos
            // 
            this.clmDatos.HeaderText = "Datos";
            this.clmDatos.Name = "clmDatos";
            // 
            // dtgrTabla
            // 
            this.dtgrTabla.AllowUserToAddRows = false;
            this.dtgrTabla.AllowUserToDeleteRows = false;
            this.dtgrTabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgrTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNoClase,
            this.clmInterClase,
            this.clmFrecuencua,
            this.clmFrecAcu,
            this.clmFrecuenciaRelativa,
            this.clmFrecuenciaRelativaAcumulada,
            this.clmMarcaClase,
            this.clmGrados});
            this.dtgrTabla.Location = new System.Drawing.Point(125, 13);
            this.dtgrTabla.Name = "dtgrTabla";
            this.dtgrTabla.ReadOnly = true;
            this.dtgrTabla.Size = new System.Drawing.Size(843, 270);
            this.dtgrTabla.TabIndex = 1;
            // 
            // clmNoClase
            // 
            this.clmNoClase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmNoClase.HeaderText = "Número de Clase";
            this.clmNoClase.Name = "clmNoClase";
            this.clmNoClase.ReadOnly = true;
            // 
            // clmInterClase
            // 
            this.clmInterClase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmInterClase.HeaderText = "Intérvalo de Clase";
            this.clmInterClase.Name = "clmInterClase";
            this.clmInterClase.ReadOnly = true;
            // 
            // clmFrecuencua
            // 
            this.clmFrecuencua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmFrecuencua.HeaderText = "Frecuencia";
            this.clmFrecuencua.Name = "clmFrecuencua";
            this.clmFrecuencua.ReadOnly = true;
            // 
            // clmFrecAcu
            // 
            this.clmFrecAcu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmFrecAcu.HeaderText = "Frecuencia Acumulada";
            this.clmFrecAcu.Name = "clmFrecAcu";
            this.clmFrecAcu.ReadOnly = true;
            // 
            // clmFrecuenciaRelativa
            // 
            this.clmFrecuenciaRelativa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmFrecuenciaRelativa.HeaderText = "Frecuencia Relativa";
            this.clmFrecuenciaRelativa.Name = "clmFrecuenciaRelativa";
            this.clmFrecuenciaRelativa.ReadOnly = true;
            // 
            // clmFrecuenciaRelativaAcumulada
            // 
            this.clmFrecuenciaRelativaAcumulada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmFrecuenciaRelativaAcumulada.HeaderText = "Frecuencia R. Acumulada";
            this.clmFrecuenciaRelativaAcumulada.Name = "clmFrecuenciaRelativaAcumulada";
            this.clmFrecuenciaRelativaAcumulada.ReadOnly = true;
            // 
            // clmMarcaClase
            // 
            this.clmMarcaClase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmMarcaClase.HeaderText = "Marca de Clase";
            this.clmMarcaClase.Name = "clmMarcaClase";
            this.clmMarcaClase.ReadOnly = true;
            // 
            // clmGrados
            // 
            this.clmGrados.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmGrados.HeaderText = "Grados";
            this.clmGrados.Name = "clmGrados";
            this.clmGrados.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblDesvEsta);
            this.groupBox1.Controls.Add(this.lblModa);
            this.groupBox1.Controls.Add(this.lblMediana);
            this.groupBox1.Controls.Add(this.lblPromedio);
            this.groupBox1.Controls.Add(this.lblVarianza);
            this.groupBox1.Controls.Add(this.lblIntClase);
            this.groupBox1.Controls.Add(this.lblNoClase);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(125, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(843, 60);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Variables";
            // 
            // lblDesvEsta
            // 
            this.lblDesvEsta.AutoSize = true;
            this.lblDesvEsta.Location = new System.Drawing.Point(745, 18);
            this.lblDesvEsta.Name = "lblDesvEsta";
            this.lblDesvEsta.Size = new System.Drawing.Size(13, 13);
            this.lblDesvEsta.TabIndex = 13;
            this.lblDesvEsta.Text = "0";
            // 
            // lblModa
            // 
            this.lblModa.AutoSize = true;
            this.lblModa.Location = new System.Drawing.Point(495, 42);
            this.lblModa.Name = "lblModa";
            this.lblModa.Size = new System.Drawing.Size(13, 13);
            this.lblModa.TabIndex = 12;
            this.lblModa.Text = "0";
            // 
            // lblMediana
            // 
            this.lblMediana.AutoSize = true;
            this.lblMediana.Location = new System.Drawing.Point(495, 18);
            this.lblMediana.Name = "lblMediana";
            this.lblMediana.Size = new System.Drawing.Size(13, 13);
            this.lblMediana.TabIndex = 11;
            this.lblMediana.Text = "0";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(298, 42);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(13, 13);
            this.lblPromedio.TabIndex = 10;
            this.lblPromedio.Text = "0";
            // 
            // lblVarianza
            // 
            this.lblVarianza.AutoSize = true;
            this.lblVarianza.Location = new System.Drawing.Point(298, 18);
            this.lblVarianza.Name = "lblVarianza";
            this.lblVarianza.Size = new System.Drawing.Size(13, 13);
            this.lblVarianza.TabIndex = 9;
            this.lblVarianza.Text = "0";
            // 
            // lblIntClase
            // 
            this.lblIntClase.AutoSize = true;
            this.lblIntClase.Location = new System.Drawing.Point(103, 42);
            this.lblIntClase.Name = "lblIntClase";
            this.lblIntClase.Size = new System.Drawing.Size(13, 13);
            this.lblIntClase.TabIndex = 8;
            this.lblIntClase.Text = "0";
            // 
            // lblNoClase
            // 
            this.lblNoClase.AutoSize = true;
            this.lblNoClase.Location = new System.Drawing.Point(103, 18);
            this.lblNoClase.Name = "lblNoClase";
            this.lblNoClase.Size = new System.Drawing.Size(13, 13);
            this.lblNoClase.TabIndex = 7;
            this.lblNoClase.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(634, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Desviación Estandar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(398, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Moda:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(398, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mediana:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Media Aritmética:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "S²:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Intérvalo de Clase:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de Clase:";
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.Location = new System.Drawing.Point(12, 327);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(106, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Eliminar";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 362);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgrTabla);
            this.Controls.Add(this.dtgrDatos);
            this.Name = "Form1";
            this.Text = "Tabla de Estadística";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrTabla)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDatos;
        private System.Windows.Forms.DataGridView dtgrTabla;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDesvEsta;
        private System.Windows.Forms.Label lblModa;
        private System.Windows.Forms.Label lblMediana;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblVarianza;
        private System.Windows.Forms.Label lblIntClase;
        private System.Windows.Forms.Label lblNoClase;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNoClase;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInterClase;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFrecuencua;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFrecAcu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFrecuenciaRelativa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFrecuenciaRelativaAcumulada;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMarcaClase;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGrados;
    }
}

