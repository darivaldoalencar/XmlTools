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
            this.components = new System.ComponentModel.Container();
            this.gbxTop = new System.Windows.Forms.GroupBox();
            this.btnConsolidarWeb = new System.Windows.Forms.Button();
            this.btnExportaRecibo = new System.Windows.Forms.Button();
            this.gbxFiltros = new System.Windows.Forms.GroupBox();
            this.rbNumCPF = new System.Windows.Forms.RadioButton();
            this.cbxReciboEnv = new System.Windows.Forms.CheckBox();
            this.cbxReciboRet = new System.Windows.Forms.CheckBox();
            this.cbxRetErro = new System.Windows.Forms.CheckBox();
            this.rbNumRecibo = new System.Windows.Forms.RadioButton();
            this.rbRetificacao = new System.Windows.Forms.RadioButton();
            this.rbIdXml = new System.Windows.Forms.RadioButton();
            this.gbxTipo = new System.Windows.Forms.GroupBox();
            this.rbRetornoWeb = new System.Windows.Forms.RadioButton();
            this.rbMovPrevRetorno = new System.Windows.Forms.RadioButton();
            this.rbMovPrevEnvio = new System.Windows.Forms.RadioButton();
            this.rbMovFinanEnvio = new System.Windows.Forms.RadioButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnLocalizarXML = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlOpMov = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodVersao = new System.Windows.Forms.TextBox();
            this.btnOkOp = new System.Windows.Forms.Button();
            this.btnCancelaOp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rbOpPrev = new System.Windows.Forms.RadioButton();
            this.rbOpFinanc = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbxResultados = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gbxTop.SuspendLayout();
            this.gbxFiltros.SuspendLayout();
            this.gbxTipo.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlOpMov.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxTop
            // 
            this.gbxTop.Controls.Add(this.btnConsolidarWeb);
            this.gbxTop.Controls.Add(this.btnExportaRecibo);
            this.gbxTop.Controls.Add(this.gbxFiltros);
            this.gbxTop.Controls.Add(this.gbxTipo);
            this.gbxTop.Controls.Add(this.progressBar1);
            this.gbxTop.Controls.Add(this.btnFiltrar);
            this.gbxTop.Controls.Add(this.txtId);
            this.gbxTop.Controls.Add(this.btnLocalizarXML);
            this.gbxTop.Controls.Add(this.txtPath);
            this.gbxTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxTop.Location = new System.Drawing.Point(0, 0);
            this.gbxTop.Name = "gbxTop";
            this.gbxTop.Size = new System.Drawing.Size(957, 151);
            this.gbxTop.TabIndex = 3;
            this.gbxTop.TabStop = false;
            // 
            // btnConsolidarWeb
            // 
            this.btnConsolidarWeb.Enabled = false;
            this.btnConsolidarWeb.Location = new System.Drawing.Point(133, 101);
            this.btnConsolidarWeb.Name = "btnConsolidarWeb";
            this.btnConsolidarWeb.Size = new System.Drawing.Size(124, 23);
            this.btnConsolidarWeb.TabIndex = 10;
            this.btnConsolidarWeb.Text = "Consolidar WEB";
            this.btnConsolidarWeb.UseVisualStyleBackColor = true;
            this.btnConsolidarWeb.Click += new System.EventHandler(this.btnConsolidarWeb_Click);
            // 
            // btnExportaRecibo
            // 
            this.btnExportaRecibo.Enabled = false;
            this.btnExportaRecibo.Location = new System.Drawing.Point(12, 101);
            this.btnExportaRecibo.Name = "btnExportaRecibo";
            this.btnExportaRecibo.Size = new System.Drawing.Size(115, 23);
            this.btnExportaRecibo.TabIndex = 9;
            this.btnExportaRecibo.Text = "Exportar Recibos";
            this.btnExportaRecibo.UseVisualStyleBackColor = true;
            this.btnExportaRecibo.Click += new System.EventHandler(this.btnExportaRecibo_Click);
            // 
            // gbxFiltros
            // 
            this.gbxFiltros.Controls.Add(this.rbNumCPF);
            this.gbxFiltros.Controls.Add(this.cbxReciboEnv);
            this.gbxFiltros.Controls.Add(this.cbxReciboRet);
            this.gbxFiltros.Controls.Add(this.cbxRetErro);
            this.gbxFiltros.Controls.Add(this.rbNumRecibo);
            this.gbxFiltros.Controls.Add(this.rbRetificacao);
            this.gbxFiltros.Controls.Add(this.rbIdXml);
            this.gbxFiltros.Enabled = false;
            this.gbxFiltros.Location = new System.Drawing.Point(654, 0);
            this.gbxFiltros.Name = "gbxFiltros";
            this.gbxFiltros.Size = new System.Drawing.Size(299, 128);
            this.gbxFiltros.TabIndex = 8;
            this.gbxFiltros.TabStop = false;
            this.gbxFiltros.Text = "Filtros";
            // 
            // rbNumCPF
            // 
            this.rbNumCPF.AutoSize = true;
            this.rbNumCPF.Location = new System.Drawing.Point(15, 101);
            this.rbNumCPF.Name = "rbNumCPF";
            this.rbNumCPF.Size = new System.Drawing.Size(45, 17);
            this.rbNumCPF.TabIndex = 8;
            this.rbNumCPF.TabStop = true;
            this.rbNumCPF.Text = "CPF";
            this.rbNumCPF.UseVisualStyleBackColor = true;
            // 
            // cbxReciboEnv
            // 
            this.cbxReciboEnv.AutoSize = true;
            this.cbxReciboEnv.Location = new System.Drawing.Point(125, 30);
            this.cbxReciboEnv.Name = "cbxReciboEnv";
            this.cbxReciboEnv.Size = new System.Drawing.Size(136, 17);
            this.cbxReciboEnv.TabIndex = 7;
            this.cbxReciboEnv.Text = "Rec. Envio Preenchido";
            this.cbxReciboEnv.UseVisualStyleBackColor = true;
            // 
            // cbxReciboRet
            // 
            this.cbxReciboRet.AutoSize = true;
            this.cbxReciboRet.Location = new System.Drawing.Point(125, 56);
            this.cbxReciboRet.Name = "cbxReciboRet";
            this.cbxReciboRet.Size = new System.Drawing.Size(147, 17);
            this.cbxReciboRet.TabIndex = 6;
            this.cbxReciboRet.Text = "Rec. Retorno Preenchido";
            this.cbxReciboRet.UseVisualStyleBackColor = true;
            // 
            // cbxRetErro
            // 
            this.cbxRetErro.AutoSize = true;
            this.cbxRetErro.Location = new System.Drawing.Point(125, 84);
            this.cbxRetErro.Name = "cbxRetErro";
            this.cbxRetErro.Size = new System.Drawing.Size(125, 17);
            this.cbxRetErro.TabIndex = 5;
            this.cbxRetErro.Text = "Somente retorno erro";
            this.cbxRetErro.UseVisualStyleBackColor = true;
            // 
            // rbNumRecibo
            // 
            this.rbNumRecibo.AutoSize = true;
            this.rbNumRecibo.Location = new System.Drawing.Point(15, 78);
            this.rbNumRecibo.Name = "rbNumRecibo";
            this.rbNumRecibo.Size = new System.Drawing.Size(84, 17);
            this.rbNumRecibo.TabIndex = 2;
            this.rbNumRecibo.TabStop = true;
            this.rbNumRecibo.Text = "Num Recibo";
            this.rbNumRecibo.UseVisualStyleBackColor = true;
            // 
            // rbRetificacao
            // 
            this.rbRetificacao.AutoSize = true;
            this.rbRetificacao.Location = new System.Drawing.Point(15, 55);
            this.rbRetificacao.Name = "rbRetificacao";
            this.rbRetificacao.Size = new System.Drawing.Size(93, 17);
            this.rbRetificacao.TabIndex = 1;
            this.rbRetificacao.Text = "ID Retificação";
            this.rbRetificacao.UseVisualStyleBackColor = true;
            // 
            // rbIdXml
            // 
            this.rbIdXml.AutoSize = true;
            this.rbIdXml.Checked = true;
            this.rbIdXml.Location = new System.Drawing.Point(15, 28);
            this.rbIdXml.Name = "rbIdXml";
            this.rbIdXml.Size = new System.Drawing.Size(58, 17);
            this.rbIdXml.TabIndex = 0;
            this.rbIdXml.TabStop = true;
            this.rbIdXml.Text = "IDXML";
            this.rbIdXml.UseVisualStyleBackColor = true;
            // 
            // gbxTipo
            // 
            this.gbxTipo.Controls.Add(this.rbRetornoWeb);
            this.gbxTipo.Controls.Add(this.rbMovPrevRetorno);
            this.gbxTipo.Controls.Add(this.rbMovPrevEnvio);
            this.gbxTipo.Controls.Add(this.rbMovFinanEnvio);
            this.gbxTipo.Location = new System.Drawing.Point(500, 0);
            this.gbxTipo.Name = "gbxTipo";
            this.gbxTipo.Size = new System.Drawing.Size(155, 128);
            this.gbxTipo.TabIndex = 7;
            this.gbxTipo.TabStop = false;
            this.gbxTipo.Text = "Tipo de Arquivo";
            // 
            // rbRetornoWeb
            // 
            this.rbRetornoWeb.AutoSize = true;
            this.rbRetornoWeb.Location = new System.Drawing.Point(27, 97);
            this.rbRetornoWeb.Name = "rbRetornoWeb";
            this.rbRetornoWeb.Size = new System.Drawing.Size(89, 17);
            this.rbRetornoWeb.TabIndex = 3;
            this.rbRetornoWeb.TabStop = true;
            this.rbRetornoWeb.Text = "Retorno Web";
            this.rbRetornoWeb.UseVisualStyleBackColor = true;
            // 
            // rbMovPrevRetorno
            // 
            this.rbMovPrevRetorno.AutoSize = true;
            this.rbMovPrevRetorno.Location = new System.Drawing.Point(27, 74);
            this.rbMovPrevRetorno.Name = "rbMovPrevRetorno";
            this.rbMovPrevRetorno.Size = new System.Drawing.Size(121, 17);
            this.rbMovPrevRetorno.TabIndex = 2;
            this.rbMovPrevRetorno.TabStop = true;
            this.rbMovPrevRetorno.Text = "Mov. Prev (Retorno)";
            this.rbMovPrevRetorno.UseVisualStyleBackColor = true;
            // 
            // rbMovPrevEnvio
            // 
            this.rbMovPrevEnvio.AutoSize = true;
            this.rbMovPrevEnvio.Location = new System.Drawing.Point(27, 49);
            this.rbMovPrevEnvio.Name = "rbMovPrevEnvio";
            this.rbMovPrevEnvio.Size = new System.Drawing.Size(107, 17);
            this.rbMovPrevEnvio.TabIndex = 1;
            this.rbMovPrevEnvio.TabStop = true;
            this.rbMovPrevEnvio.Text = "Mov Prev (Envio)";
            this.rbMovPrevEnvio.UseVisualStyleBackColor = true;
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
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(3, 130);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(951, 18);
            this.progressBar1.TabIndex = 6;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Enabled = false;
            this.btnFiltrar.Location = new System.Drawing.Point(403, 68);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(91, 23);
            this.btnFiltrar.TabIndex = 5;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 71);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(385, 20);
            this.txtId.TabIndex = 4;
            // 
            // btnLocalizarXML
            // 
            this.btnLocalizarXML.Location = new System.Drawing.Point(403, 28);
            this.btnLocalizarXML.Name = "btnLocalizarXML";
            this.btnLocalizarXML.Size = new System.Drawing.Size(91, 23);
            this.btnLocalizarXML.TabIndex = 3;
            this.btnLocalizarXML.Text = "Localizar XML";
            this.btnLocalizarXML.UseVisualStyleBackColor = true;
            this.btnLocalizarXML.Click += new System.EventHandler(this.btnLocalizarXML_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(12, 29);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(385, 20);
            this.txtPath.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 151);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(957, 234);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlOpMov);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(949, 208);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Arquivos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlOpMov
            // 
            this.pnlOpMov.BackColor = System.Drawing.Color.NavajoWhite;
            this.pnlOpMov.Controls.Add(this.label2);
            this.pnlOpMov.Controls.Add(this.txtCodVersao);
            this.pnlOpMov.Controls.Add(this.btnOkOp);
            this.pnlOpMov.Controls.Add(this.btnCancelaOp);
            this.pnlOpMov.Controls.Add(this.label1);
            this.pnlOpMov.Controls.Add(this.rbOpPrev);
            this.pnlOpMov.Controls.Add(this.rbOpFinanc);
            this.pnlOpMov.Location = new System.Drawing.Point(218, 6);
            this.pnlOpMov.Name = "pnlOpMov";
            this.pnlOpMov.Size = new System.Drawing.Size(280, 171);
            this.pnlOpMov.TabIndex = 6;
            this.pnlOpMov.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cod. Versão  Mov.";
            // 
            // txtCodVersao
            // 
            this.txtCodVersao.Location = new System.Drawing.Point(136, 60);
            this.txtCodVersao.Name = "txtCodVersao";
            this.txtCodVersao.Size = new System.Drawing.Size(100, 20);
            this.txtCodVersao.TabIndex = 5;
            // 
            // btnOkOp
            // 
            this.btnOkOp.Location = new System.Drawing.Point(38, 118);
            this.btnOkOp.Name = "btnOkOp";
            this.btnOkOp.Size = new System.Drawing.Size(75, 23);
            this.btnOkOp.TabIndex = 4;
            this.btnOkOp.Text = "OK";
            this.btnOkOp.UseVisualStyleBackColor = true;
            this.btnOkOp.Click += new System.EventHandler(this.btnOkOp_Click);
            // 
            // btnCancelaOp
            // 
            this.btnCancelaOp.Location = new System.Drawing.Point(119, 118);
            this.btnCancelaOp.Name = "btnCancelaOp";
            this.btnCancelaOp.Size = new System.Drawing.Size(75, 23);
            this.btnCancelaOp.TabIndex = 3;
            this.btnCancelaOp.Text = "Cancelar";
            this.btnCancelaOp.UseVisualStyleBackColor = true;
            this.btnCancelaOp.Click += new System.EventHandler(this.btnCancelaOp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecione o tipo de arquivo";
            // 
            // rbOpPrev
            // 
            this.rbOpPrev.AutoSize = true;
            this.rbOpPrev.Location = new System.Drawing.Point(12, 74);
            this.rbOpPrev.Name = "rbOpPrev";
            this.rbOpPrev.Size = new System.Drawing.Size(74, 17);
            this.rbOpPrev.TabIndex = 1;
            this.rbOpPrev.TabStop = true;
            this.rbOpPrev.Text = "Mov. Prev";
            this.rbOpPrev.UseVisualStyleBackColor = true;
            // 
            // rbOpFinanc
            // 
            this.rbOpFinanc.AutoSize = true;
            this.rbOpFinanc.Location = new System.Drawing.Point(12, 42);
            this.rbOpFinanc.Name = "rbOpFinanc";
            this.rbOpFinanc.Size = new System.Drawing.Size(101, 17);
            this.rbOpFinanc.TabIndex = 0;
            this.rbOpFinanc.TabStop = true;
            this.rbOpFinanc.Text = "Mov. Financeira";
            this.rbOpFinanc.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(943, 202);
            this.dataGridView1.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbxResultados);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(949, 208);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Processamento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbxResultados
            // 
            this.lbxResultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxResultados.FormattingEnabled = true;
            this.lbxResultados.Location = new System.Drawing.Point(3, 3);
            this.lbxResultados.Name = "lbxResultados";
            this.lbxResultados.Size = new System.Drawing.Size(943, 202);
            this.lbxResultados.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 385);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.gbxTop);
            this.Name = "Form1";
            this.Text = "EFinanceira - XML Tools";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxTop.ResumeLayout(false);
            this.gbxTop.PerformLayout();
            this.gbxFiltros.ResumeLayout(false);
            this.gbxFiltros.PerformLayout();
            this.gbxTipo.ResumeLayout(false);
            this.gbxTipo.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pnlOpMov.ResumeLayout(false);
            this.pnlOpMov.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxTop;
        private System.Windows.Forms.Button btnLocalizarXML;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox gbxTipo;
        private System.Windows.Forms.RadioButton rbMovPrevEnvio;
        private System.Windows.Forms.RadioButton rbMovFinanEnvio;
        private System.Windows.Forms.GroupBox gbxFiltros;
        private System.Windows.Forms.RadioButton rbRetificacao;
        private System.Windows.Forms.RadioButton rbIdXml;
        private System.Windows.Forms.RadioButton rbNumRecibo;
        private System.Windows.Forms.RadioButton rbMovPrevRetorno;
        private System.Windows.Forms.Button btnExportaRecibo;
        private System.Windows.Forms.CheckBox cbxRetErro;
        private System.Windows.Forms.CheckBox cbxReciboEnv;
        private System.Windows.Forms.CheckBox cbxReciboRet;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lbxResultados;
        private System.Windows.Forms.Button btnConsolidarWeb;
        private System.Windows.Forms.RadioButton rbRetornoWeb;
        private System.Windows.Forms.RadioButton rbNumCPF;
        private System.Windows.Forms.Panel pnlOpMov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbOpPrev;
        private System.Windows.Forms.RadioButton rbOpFinanc;
        private System.Windows.Forms.Button btnCancelaOp;
        private System.Windows.Forms.Button btnOkOp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodVersao;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

