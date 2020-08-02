namespace XMLTools
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
            this.gbxFiltros = new System.Windows.Forms.GroupBox();
            this.btnLocalizarXML = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.gbxTipo = new System.Windows.Forms.GroupBox();
            this.rbMovFinanEnvio = new System.Windows.Forms.RadioButton();
            this.rbMovPrevEnvio = new System.Windows.Forms.RadioButton();
            this.gbxFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbxTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxFiltros
            // 
            this.gbxFiltros.Controls.Add(this.gbxTipo);
            this.gbxFiltros.Controls.Add(this.progressBar1);
            this.gbxFiltros.Controls.Add(this.btnFiltrar);
            this.gbxFiltros.Controls.Add(this.txtId);
            this.gbxFiltros.Controls.Add(this.btnLocalizarXML);
            this.gbxFiltros.Controls.Add(this.txtPath);
            this.gbxFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxFiltros.Location = new System.Drawing.Point(0, 0);
            this.gbxFiltros.Name = "gbxFiltros";
            this.gbxFiltros.Size = new System.Drawing.Size(924, 135);
            this.gbxFiltros.TabIndex = 3;
            this.gbxFiltros.TabStop = false;
            // 
            // btnLocalizarXML
            // 
            this.btnLocalizarXML.Location = new System.Drawing.Point(403, 28);
            this.btnLocalizarXML.Name = "btnLocalizarXML";
            this.btnLocalizarXML.Size = new System.Drawing.Size(165, 23);
            this.btnLocalizarXML.TabIndex = 3;
            this.btnLocalizarXML.Text = "Localizar XML";
            this.btnLocalizarXML.UseVisualStyleBackColor = true;
            this.btnLocalizarXML.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(12, 29);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(385, 20);
            this.txtPath.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(924, 211);
            this.dataGridView1.TabIndex = 4;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 71);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(385, 20);
            this.txtId.TabIndex = 4;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(403, 68);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(165, 23);
            this.btnFiltrar.TabIndex = 5;
            this.btnFiltrar.Text = "Filtrar ID";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(3, 114);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(918, 18);
            this.progressBar1.TabIndex = 6;
            // 
            // gbxTipo
            // 
            this.gbxTipo.Controls.Add(this.rbMovPrevEnvio);
            this.gbxTipo.Controls.Add(this.rbMovFinanEnvio);
            this.gbxTipo.Location = new System.Drawing.Point(574, 8);
            this.gbxTipo.Name = "gbxTipo";
            this.gbxTipo.Size = new System.Drawing.Size(294, 100);
            this.gbxTipo.TabIndex = 7;
            this.gbxTipo.TabStop = false;
            this.gbxTipo.Text = "Tipo de Arquivo";
            // 
            // rbMovFinanEnvio
            // 
            this.rbMovFinanEnvio.AutoSize = true;
            this.rbMovFinanEnvio.Checked = true;
            this.rbMovFinanEnvio.Location = new System.Drawing.Point(27, 26);
            this.rbMovFinanEnvio.Name = "rbMovFinanEnvio";
            this.rbMovFinanEnvio.Size = new System.Drawing.Size(111, 17);
            this.rbMovFinanEnvio.TabIndex = 0;
            this.rbMovFinanEnvio.TabStop = true;
            this.rbMovFinanEnvio.Text = "Mov Finan (Envio)";
            this.rbMovFinanEnvio.UseVisualStyleBackColor = true;
            // 
            // rbMovPrevEnvio
            // 
            this.rbMovPrevEnvio.AutoSize = true;
            this.rbMovPrevEnvio.Enabled = false;
            this.rbMovPrevEnvio.Location = new System.Drawing.Point(27, 60);
            this.rbMovPrevEnvio.Name = "rbMovPrevEnvio";
            this.rbMovPrevEnvio.Size = new System.Drawing.Size(107, 17);
            this.rbMovPrevEnvio.TabIndex = 1;
            this.rbMovPrevEnvio.TabStop = true;
            this.rbMovPrevEnvio.Text = "Mov Prev (Envio)";
            this.rbMovPrevEnvio.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 346);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbxFiltros);
            this.Name = "Form1";
            this.Text = "EFinanceira - XML Tools";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxFiltros.ResumeLayout(false);
            this.gbxFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbxTipo.ResumeLayout(false);
            this.gbxTipo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxFiltros;
        private System.Windows.Forms.Button btnLocalizarXML;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox gbxTipo;
        private System.Windows.Forms.RadioButton rbMovPrevEnvio;
        private System.Windows.Forms.RadioButton rbMovFinanEnvio;
    }
}

