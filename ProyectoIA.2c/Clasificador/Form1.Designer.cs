namespace Clasificador
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmbPuertos = new System.Windows.Forms.ComboBox();
            this.btnActualizarPuertos = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnExplorar = new System.Windows.Forms.Button();
            this.cmbHoja = new System.Windows.Forms.ComboBox();
            this.lblHoja = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPuertos
            // 
            this.cmbPuertos.FormattingEnabled = true;
            this.cmbPuertos.Location = new System.Drawing.Point(71, 46);
            this.cmbPuertos.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPuertos.Name = "cmbPuertos";
            this.cmbPuertos.Size = new System.Drawing.Size(160, 24);
            this.cmbPuertos.TabIndex = 0;
            this.cmbPuertos.SelectedIndexChanged += new System.EventHandler(this.cmbPuertos_SelectedIndexChanged);
            // 
            // btnActualizarPuertos
            // 
            this.btnActualizarPuertos.Location = new System.Drawing.Point(256, 43);
            this.btnActualizarPuertos.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizarPuertos.Name = "btnActualizarPuertos";
            this.btnActualizarPuertos.Size = new System.Drawing.Size(100, 28);
            this.btnActualizarPuertos.TabIndex = 2;
            this.btnActualizarPuertos.Text = "Actualizar";
            this.btnActualizarPuertos.UseVisualStyleBackColor = true;
            this.btnActualizarPuertos.Click += new System.EventHandler(this.btnActualizarPuertos_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(27, 96);
            this.btnConectar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(100, 28);
            this.btnConectar.TabIndex = 3;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(209, 96);
            this.btnDesconectar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(100, 28);
            this.btnDesconectar.TabIndex = 4;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(43, 36);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(127, 43);
            this.btnEnviar.TabIndex = 6;
            this.btnEnviar.Text = "Tomar Muestra";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Puerto:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbPuertos);
            this.groupBox1.Controls.Add(this.btnActualizarPuertos);
            this.groupBox1.Controls.Add(this.btnConectar);
            this.groupBox1.Controls.Add(this.btnDesconectar);
            this.groupBox1.Location = new System.Drawing.Point(28, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(384, 146);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selección del puerto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnEnviar);
            this.groupBox2.Location = new System.Drawing.Point(447, 24);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(228, 151);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Comunicación";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Datos recibidos";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(16, 204);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(184, 17);
            this.lblData.TabIndex = 11;
            this.lblData.Text = "Patrones de entrenamiento:";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.GridColor = System.Drawing.SystemColors.Desktop;
            this.dgvData.Location = new System.Drawing.Point(16, 278);
            this.dgvData.Margin = new System.Windows.Forms.Padding(4);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.Size = new System.Drawing.Size(485, 309);
            this.dgvData.TabIndex = 12;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(203, 201);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(132, 22);
            this.txtFileName.TabIndex = 13;
            // 
            // btnExplorar
            // 
            this.btnExplorar.Location = new System.Drawing.Point(344, 198);
            this.btnExplorar.Margin = new System.Windows.Forms.Padding(4);
            this.btnExplorar.Name = "btnExplorar";
            this.btnExplorar.Size = new System.Drawing.Size(100, 28);
            this.btnExplorar.TabIndex = 14;
            this.btnExplorar.Text = "Explorar";
            this.btnExplorar.UseVisualStyleBackColor = true;
            this.btnExplorar.Click += new System.EventHandler(this.btnExplorar_Click);
            // 
            // cmbHoja
            // 
            this.cmbHoja.FormattingEnabled = true;
            this.cmbHoja.Location = new System.Drawing.Point(203, 233);
            this.cmbHoja.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHoja.Name = "cmbHoja";
            this.cmbHoja.Size = new System.Drawing.Size(144, 24);
            this.cmbHoja.TabIndex = 15;
            this.cmbHoja.Text = "Seleccione la hoja";
            this.cmbHoja.SelectedIndexChanged += new System.EventHandler(this.cmbHoja_SelectedIndexChanged);
            // 
            // lblHoja
            // 
            this.lblHoja.AutoSize = true;
            this.lblHoja.Location = new System.Drawing.Point(140, 236);
            this.lblHoja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoja.Name = "lblHoja";
            this.lblHoja.Size = new System.Drawing.Size(41, 17);
            this.lblHoja.TabIndex = 16;
            this.lblHoja.Text = "Hoja:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(700, 601);
            this.Controls.Add(this.lblHoja);
            this.Controls.Add(this.cmbHoja);
            this.Controls.Add(this.btnExplorar);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clasificador";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPuertos;
        private System.Windows.Forms.Button btnActualizarPuertos;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnEnviar;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnExplorar;
        private System.Windows.Forms.ComboBox cmbHoja;
        private System.Windows.Forms.Label lblHoja;
        private System.Windows.Forms.Label label4;
    }
}

