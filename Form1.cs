using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace XMLTools
{
    public partial class Form1 : Form
    {
        #region propriedades
        private bool Filtrado { get; set; }
        List<GridViewApresenta> listaFiltrada;
        List<GridViewApresenta> lista;
        #endregion

        #region teste individual        
        private EFinanceira1 ExecEfinanceira1(string xml)
        {
            using (StringReader sr = new StringReader(xml))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(EFinanceira1));
                return (EFinanceira1)serializer.Deserialize(sr);
            }
        }

        private EFinanceira1Prev ExecEfinanceira1Prev(string xml)
        {
            using (StringReader sr = new StringReader(xml))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(EFinanceira1Prev));
                return (EFinanceira1Prev)serializer.Deserialize(sr);
            }
        }

        private EFinanceira1PrevRet ExecEfinanceira1PrevRet(string xml)
        {
            using (StringReader sr = new StringReader(xml))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(EFinanceira1PrevRet));
                return (EFinanceira1PrevRet)serializer.Deserialize(sr);
            }
        }

        private EFinanceira1Web ExecEfinanceiraWeb(string xml)
        {
            using (StringReader sr = new StringReader(xml))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(EFinanceira1Web));
                return (EFinanceira1Web)serializer.Deserialize(sr);
            }
        }
        #endregion

        #region métodos
        private void RemoverFiltros()
        {
            Filtrado = false;
            btnFiltrar.Text = "Filtrar";

            gbxTipo.Enabled = true;
            gbxFiltros.Enabled = true;

            dataGridView1.DataSource = lista;
            dataGridView1.AutoResizeColumns();
        }

        private void ExportaConsolidacaoWEB(string tabela)
        {
            using (FileStream fs = new FileStream(@"C:\temp\consolidar.txt", FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    if (listaFiltrada == null)
                        listaFiltrada = lista;

                    progressBar1.Maximum = listaFiltrada.Count();
                    progressBar1.Value += 0;

                    foreach (GridViewApresenta item in listaFiltrada)
                    {
                        if (!string.IsNullOrEmpty(item.numeroRecibo))
                        {
                            sw.WriteLine(string.Format("UPDATE {3} SET NUMRECIBO= '{0}' WHERE IDXML = '{1}' AND CPF = '{2}' ;",
                               item.numeroRecibo,
                               item.idEvento,
                               item.cpf,
                               tabela));
                        }
                        progressBar1.Value += progressBar1.Value < progressBar1.Maximum ? 1 : 0;
                    }

                    progressBar1.Value = progressBar1.Maximum;

                    MessageBox.Show("Arquivo: 'C:\\temp\\consolidar.txt' foi exportado", "Exportação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    sw.Flush();
                    sw.Close();
                    fs.Close();
                }
            }
        }
        private void ExportarUpdate(bool atualizaRecibo)
        {
            using (FileStream fs = new FileStream(@"C:\temp\update.txt", FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    progressBar1.Maximum = listaFiltrada.Count();
                    progressBar1.Value += 0;

                    foreach (GridViewApresenta item in listaFiltrada)
                    {
                        if (atualizaRecibo)
                        {
                            sw.WriteLine(string.Format("UPDATE EXTRATOMOVPREVIN1571 SET NUMRECIBO = '{0}' WHERE IDXML = '{1}' AND SITUACAO = 3;",
                                string.IsNullOrEmpty(item.numeroRecibo) ? item.nrRecibo : item.numeroRecibo,
                                item.idEvento));
                        }
                        else
                        {
                            sw.WriteLine(string.Format("UPDATE EXTRATOMOVPREVIN1571 SET NUMRECIBO = '{0}' WHERE IDXML = '{1}' AND NUMRECIBO IS NULL ;",
                               string.IsNullOrEmpty(item.numeroRecibo) ? item.nrRecibo : item.numeroRecibo,
                               item.idEvento));
                        }

                        progressBar1.Value += progressBar1.Value < progressBar1.Maximum ? 1 : 0;
                    }

                    progressBar1.Value = progressBar1.Maximum;

                    MessageBox.Show("Arquivo: 'C:\\temp\\update.txt' foi exportado", "Exportação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    sw.Flush();
                    sw.Close();
                    fs.Close();
                }
            }
        }
        private string RemoveCabecalho(string texto)
        {
            if (rbMovPrevEnvio.Checked || rbMovFinanEnvio.Checked)
                return texto.Replace("<eFinanceira xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" " +
                                       "xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" " +
                                       "xmlns=\"http://www.eFinanceira.gov.br/schemas/envioLoteEventos/v1_2_0\">",
                                     "<eFinanceira>");
            if (rbRetornoWeb.Checked)
                return texto.Replace("<eFinanceira xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" " +
                                       "xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" " +
                                       "xmlns=\"http://www.eFinanceira.gov.br/schemas/retornoConsultaInformacoesMovimento/v1_2_0\">",
                                       "<eFinanceira>");
            else
                return texto.Replace("<eFinanceira xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" " +
                                        "xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" " +
                                        "xmlns=\"http://www.eFinanceira.gov.br/schemas/retornoLoteEventos/v1_2_0\">",
                                      "<eFinanceira>");
        }

        private FileInfo[] ListarArquivos(ref bool lerRetorno)
        {
            DirectoryInfo Dir = new DirectoryInfo(txtPath.Text);
            if (rbMovPrevEnvio.Checked)
            {
                lerRetorno = false;
                return Dir.GetFiles("eFinanceira_evtMov*PP*.xml", SearchOption.TopDirectoryOnly);
            }
            else if (rbMovPrevRetorno.Checked)
            {
                lerRetorno = true;
                return Dir.GetFiles("eFinanceira_evtMov*PP*Retorno.xml", SearchOption.TopDirectoryOnly);
            }
            else if (rbRetornoWeb.Checked)
            {
                lerRetorno = false;
                return Dir.GetFiles("*.xml", SearchOption.TopDirectoryOnly);
            }
            else
            {
                lerRetorno = false;
                return Dir.GetFiles("eFinanceira_evtMovOpFin*.xml", SearchOption.TopDirectoryOnly);

            }
        }
        private void CarregarGridView()
        {
            progressBar1.Value = progressBar1.Maximum;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lista;
            dataGridView1.AutoResizeColumns();
        }
        private void PreencheListaGridView(string pathFiles, object fFinanceira1)
        {
            if (rbMovPrevRetorno.Checked)
            {
                EFinanceira1PrevRet itens = (EFinanceira1PrevRet)fFinanceira1;
                lbxResultados.Items.Add(string.Format("Quant. Eventos: {0}", itens.retornoLoteEventos.retornoEventos.evento.Count));
                foreach (EventoRet ev in itens.retornoLoteEventos.retornoEventos.evento)
                {
                    lista.Add(new GridViewApresenta()
                    {
                        idEvento = ev.id,
                        indRetificacao = ev.eFinanceira.retornoEvento.id,
                        nrRecibo = ev.eFinanceira.retornoEvento.dadosRecepcaoEvento.nrRecibo,
                        numeroRecibo = ev.eFinanceira.retornoEvento.dadosReciboEntrega != null ? ev.eFinanceira.retornoEvento.dadosReciboEntrega.numeroRecibo : string.Empty,
                        status = ev.eFinanceira.retornoEvento.status.descRetorno,
                        aplicEmi = string.Empty,
                        verAplic = string.Empty,
                        cpf = string.Empty,
                        nomeArquivo = Path.GetFileName(pathFiles)
                    });
                }
            }
            else if (rbMovPrevEnvio.Checked)
            {
                EFinanceira1Prev itens = (EFinanceira1Prev)fFinanceira1;
                lbxResultados.Items.Add(string.Format("Quant. Eventos: {0}", itens.loteEventosPrev.evento.Count));
                foreach (EventoPrev ev in itens.loteEventosPrev.evento)
                {
                    lista.Add(new GridViewApresenta()
                    {
                        idEvento = ev.id,
                        indRetificacao = ev.eFinanceira.evtMovPP.ideEvento.indRetificacao,
                        nrRecibo = ev.eFinanceira.evtMovPP.ideEvento.nrRecibo,
                        aplicEmi = ev.eFinanceira.evtMovPP.ideEvento.aplicEmi,
                        verAplic = ev.eFinanceira.evtMovPP.ideEvento.verAplic,
                        cpf = ev.eFinanceira.evtMovPP.ideDeclarado.NIDeclarado,
                        nomeArquivo = Path.GetFileName(pathFiles)
                    });
                }
            }
            else if (rbRetornoWeb.Checked)
            {
                EFinanceira1Web itens = (EFinanceira1Web)fFinanceira1;
                lbxResultados.Items.Add(string.Format("Quant. Eventos: {0}", itens.retornoConsultaInformacoesMovimento.informacoesMovimento.Count));
                foreach (InformacoesMovimento ev in itens.retornoConsultaInformacoesMovimento.informacoesMovimento)
                {
                    lista.Add(new GridViewApresenta()
                    {
                        idEvento = ev.id,
                        anoMesCaixa = ev.anoMesCaixa,
                        status = ev.situacao,
                        numeroRecibo = ev.numeroRecibo,
                        cpf = ev.NI,
                        nomeArquivo = Path.GetFileName(pathFiles)
                    });
                }
            }
            else if (rbMovFinanEnvio.Checked)
            {
                EFinanceira1 itens = (EFinanceira1)fFinanceira1;
                lbxResultados.Items.Add(string.Format("Quant. Eventos: {0}", itens.loteEventos.evento.Count));
                foreach (Evento ev in itens.loteEventos.evento)
                {
                    lista.Add(new GridViewApresenta()
                    {
                        idEvento = ev.id,
                        indRetificacao = ev.eFinanceira.evtMovOpFin.ideEvento.indRetificacao,
                        nrRecibo = ev.eFinanceira.evtMovOpFin.ideEvento.nrRecibo,
                        aplicEmi = ev.eFinanceira.evtMovOpFin.ideEvento.aplicEmi,
                        verAplic = ev.eFinanceira.evtMovOpFin.ideEvento.verAplic,
                        cpf = ev.eFinanceira.evtMovOpFin.ideDeclarado.NIDeclarado,
                        nomeArquivo = Path.GetFileName(pathFiles)
                    });
                }
            }
        }

        private bool CarregarXMLDOC(XmlDocument xml, string path, bool lerRetorno)
        {
            if (!path.Contains("Assinado") && !path.Contains("Criptografado"))
            {
                if (lerRetorno)
                {
                    xml.Load(path);
                    xml.InnerXml = RemoveCabecalho(xml.InnerXml);
                    return true;
                }
                else
                {
                    if (!path.Contains("Retorno"))
                    {
                        xml.Load(path);
                        xml.InnerXml = RemoveCabecalho(xml.InnerXml);
                        return true;
                    }
                    else
                        return false;
                }
            }
            else
                return false;
        }

        private void SerializaXML(ref object fFinanceira1, string xml)
        {
            if (rbMovPrevEnvio.Checked)
                fFinanceira1 = ExecEfinanceira1Prev(xml);
            else if (rbMovPrevRetorno.Checked)
                fFinanceira1 = ExecEfinanceira1PrevRet(xml);
            else if (rbRetornoWeb.Checked)
                fFinanceira1 = ExecEfinanceiraWeb(xml);
            else
                fFinanceira1 = ExecEfinanceira1(xml);
        }
        #endregion

        private void btnLocalizarXML_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (Directory.Exists(txtPath.Text))
                    fbd.SelectedPath = txtPath.Text;

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtPath.Text = fbd.SelectedPath;
                    bool lerRetorno = false;
                    FileInfo[] Files = ListarArquivos(ref lerRetorno);
                    progressBar1.Maximum = Files.Count();
                    progressBar1.Value += 0;

                    btnExportaRecibo.Enabled = rbMovPrevRetorno.Checked;
                    btnConsolidarWeb.Enabled = rbRetornoWeb.Checked;
                    btnFiltrar.Enabled = true;
                    gbxFiltros.Enabled = true;

                    lista = new List<GridViewApresenta>();

                    lbxResultados.Items.Clear();
                    foreach (FileInfo File in Files)
                    {
                        XmlDocument xml = new XmlDocument();
                        try
                        {
                            if (!CarregarXMLDOC(xml, File.FullName, lerRetorno))
                                continue;

                            object fFinanceira1 = null;
                            SerializaXML(ref fFinanceira1, xml.InnerXml);

                            lbxResultados.Items.Add(string.Format("Listagem {0} Arquivo: {1}", DateTime.Now, File.FullName));

                            PreencheListaGridView(File.FullName, fFinanceira1);
                        }
                        catch (Exception ex)
                        {
                            lbxResultados.Items.Add("ERRO: " + File.FullName + " - " + ex.Message);
                        }
                        progressBar1.Value += progressBar1.Value < progressBar1.Maximum ? 1 : 0;
                    }

                    RemoverFiltros();
                    CarregarGridView();
                }
                else
                    txtPath.Text = string.Empty;
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (!Filtrado)
            {
                Filtrado = true;
                btnFiltrar.Text = "Remover Filtro";
                listaFiltrada = lista;

                gbxTipo.Enabled = false;
                gbxFiltros.Enabled = false;

                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    if (rbIdXml.Checked)
                        listaFiltrada = listaFiltrada.Where(l => l.idEvento.Contains(txtId.Text)).ToList();
                    else if (rbNumRecibo.Checked)
                        listaFiltrada = listaFiltrada.Where(l => (string.IsNullOrEmpty(l.nrRecibo) ? string.Empty : l.nrRecibo).Contains(txtId.Text)).ToList();
                    else if (rbRetificacao.Checked)
                        listaFiltrada = listaFiltrada.Where(l => l.indRetificacao.Contains(txtId.Text)).ToList();
                    else if (rbNumCPF.Checked)
                        listaFiltrada = listaFiltrada.Where(l => l.cpf.Contains(txtId.Text)).ToList();
                }

                if (cbxRetErro.Checked)
                    listaFiltrada = listaFiltrada.Where(l => l.status.Contains("ERRO")).ToList();

                if (cbxReciboRet.Checked)
                    listaFiltrada = listaFiltrada.Where(l => !string.IsNullOrEmpty(l.numeroRecibo)).ToList();

                if (cbxReciboEnv.Checked)
                    listaFiltrada = listaFiltrada.Where(l => !string.IsNullOrEmpty(l.nrRecibo)).ToList();

                dataGridView1.DataSource = listaFiltrada;
                dataGridView1.AutoResizeColumns();
            }
            else
                RemoverFiltros();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Filtrado = false;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExportaRecibo_Click(object sender, EventArgs e)
        {
            if (!Filtrado)
            {
                MessageBox.Show("Faça um filtro antes de exportar", "Filtro Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (rbMovPrevRetorno.Checked)
                ExportarUpdate(MessageBox.Show("Você deseja atualizar dados que já possuem recibo?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
            else
                MessageBox.Show("Selecione uma opção de retonor", "Filtro Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnConsolidarWeb_Click(object sender, EventArgs e)
        {
            pnlOpMov.Location = new Point((tabControl1.Width - pnlOpMov.Width) / 2, 5);
            rbOpFinanc.Checked = false;
            rbOpPrev.Checked = false;
            pnlOpMov.Visible = true;
        }
       
        private void btnCancelaOp_Click(object sender, EventArgs e)
        {
            rbOpFinanc.Checked = false;
            rbOpPrev.Checked = false;
            pnlOpMov.Visible = false;
        }

        private void btnOkOp_Click(object sender, EventArgs e)
        {
            if (rbOpPrev.Checked)
                ExportaConsolidacaoWEB("EXTRATOMOVPREVIN1571");
            else
                ExportaConsolidacaoWEB("extratomovfinancin1571");
           
            pnlOpMov.Visible = false;
        }
    }
}
