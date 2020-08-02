using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace XMLTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool Filtrado { get; set; }
        List<GridViewApresenta> lista = new List<GridViewApresenta>();

        #region teste individual
        private EFinanceira1 TesteEfinanceira1(string xml)
        {
            using (StringReader sr = new StringReader(xml))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(EFinanceira1));
                return (EFinanceira1)serializer.Deserialize(sr);
            }
        }

        private EvtMovOpFin TesteEvtMovOpFin(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(EvtMovOpFin));
                return (EvtMovOpFin)serializer.Deserialize(sr);
            }
        }

        private IdeEvento TesteIdeEvento(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(IdeEvento));
                return (IdeEvento)serializer.Deserialize(sr);
            }
        }

        private EFinanceira2 TesteEFinanceira2(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(EFinanceira2));
                return (EFinanceira2)serializer.Deserialize(sr);
            }
        }

        private Evento TesteEvento(string path)
        {
            using (MemoryStream m = new MemoryStream())

            using (StreamReader sr = new StreamReader(path))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Evento));
                return (Evento)serializer.Deserialize(sr);
            }
        }

        private LoteEventos TesteLoteEvento(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(LoteEventos));
                return (LoteEventos)serializer.Deserialize(sr);
            }
        }

        private LoteEventos TesteLoteFS(string path)
        {
            XmlSerializer xs1 = new XmlSerializer(typeof(LoteEventos));
            FileStream fs1 = new FileStream(path, FileMode.Open);
            return (LoteEventos)xs1.Deserialize(fs1);
        }
        #endregion        

        private void button1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (Directory.Exists(txtPath.Text))
                {
                    fbd.SelectedPath = txtPath.Text;
                }                

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtPath.Text = fbd.SelectedPath;                    
                    DirectoryInfo Dir = new DirectoryInfo(txtPath.Text);
                    FileInfo[] Files = Dir.GetFiles("eFinanceira_evt*.xml", SearchOption.TopDirectoryOnly);
                    lista.Clear();

                    progressBar1.Maximum = Files.Count();
                    progressBar1.Value += 0;

                    foreach (FileInfo File in Files)
                    {
                        XmlDocument xml = new XmlDocument();

                        if ((!File.FullName.Contains("Assinado")) && (!File.FullName.Contains("Criptografado")) && (!File.FullName.Contains("Retorno")))
                            xml.Load(File.FullName);
                        else
                            continue;


                        xml.InnerXml = xml.InnerXml.Replace("<eFinanceira xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" " +
                                                                     "xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" " +
                                                                     "xmlns=\"http://www.eFinanceira.gov.br/schemas/envioLoteEventos/v1_2_0\">",
                                                        "<eFinanceira>");

                        #region testes separados
                        //IdeEvento ideEvento = TesteIdeEvento(string.Concat(openFileDialog.InitialDirectory, "\\Testes\\ideEvento.xml"));
                        //EvtMovOpFin evtMovOpFin = TesteEvtMovOpFin(string.Concat(openFileDialog.InitialDirectory, "\\Testes\\evtMovOpFin.xml"));
                        //EFinanceira2 eFinanceira2 = TesteEFinanceira2(string.Concat(openFileDialog.InitialDirectory, "\\Testes\\eFinanceira2.xml"));
                        //Evento evento = TesteEvento(string.Concat(openFileDialog.InitialDirectory, "\\Testes\\evento.xml"));
                        //LoteEventos lote = TesteLoteEvento(string.Concat(openFileDialog.InitialDirectory, "\\Testes\\loteEventos.xml"));
                        //LoteEventos loteFS = TesteLoteFS(string.Concat(openFileDialog.InitialDirectory, "\\Testes\\loteEventos.xml"));
                        #endregion

                        EFinanceira1 fFinanceira1 = TesteEfinanceira1(xml.InnerXml);

                        foreach (Evento ev in fFinanceira1.loteEventos.evento)
                        {
                            lista.Add(new GridViewApresenta()
                            {
                                idEvento = ev.id,
                                indRetificacao = ev.eFinanceira.evtMovOpFin.ideEvento.indRetificacao,
                                nrRecibo = ev.eFinanceira.evtMovOpFin.ideEvento.nrRecibo,
                                aplicEmi = ev.eFinanceira.evtMovOpFin.ideEvento.aplicEmi,
                                verAplic = ev.eFinanceira.evtMovOpFin.ideEvento.verAplic
                            });
                        }

                        progressBar1.Value += progressBar1.Value < progressBar1.Maximum ? 1 : 0;
                        //Thread.Sleep(2000);
                    }

                    progressBar1.Value = progressBar1.Maximum;
                    dataGridView1.DataSource = lista;
                    dataGridView1.AutoResizeColumns();
                }
                else
                    txtPath.Text = string.Empty;
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (!Filtrado)
            {
                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    Filtrado = true;
                    btnFiltrar.Text = "Remover Filtro";
                    List<GridViewApresenta> listaFiltrada = lista.Where(l => l.idEvento == txtId.Text).ToList();
                    dataGridView1.DataSource = listaFiltrada;
                    dataGridView1.AutoResizeColumns();
                }
                else
                {
                    MessageBox.Show("Informe o ID no campo de filtro", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                Filtrado = false;
                btnFiltrar.Text = "Filtrar ID";
                dataGridView1.DataSource = lista;
                dataGridView1.AutoResizeColumns();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Filtrado = false;
        }
    }
}
