using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace XMLTools
{
    #region classes do movimento financeiro - envio
    [XmlRoot(ElementName = "eFinanceira")]
    public class EFinanceira1
    {
        #region codigo não utilizado
        //[XmlAttribute(AttributeName = "xsd")]
        //public string xsd { get; set; }
        //[XmlAttribute(AttributeName = "xsd", Namespace = "xsd:http://www.w3.org/2001/XMLSchema")]
        //public string xsi { get; set; }
        //[XmlAttribute(AttributeName = "xmlns", Namespace = "xsi:http://www.w3.org/2001/XMLSchema-instance")]
        //public string xmlns { get; set; }
        #endregion
        [XmlElement(ElementName = "loteEventos")]
        public LoteEventos loteEventos { get; set; }
    }

    [XmlRootAttribute(ElementName = "loteEventos")]
    public class LoteEventos
    {
        [XmlAttribute(AttributeName = "id")]
        public string id { get; set; }
        [XmlElement(ElementName = "evento")]
        public List<Evento> evento { get; set; }
    }

    [XmlRootAttribute(ElementName = "evento")]
    public class Evento
    {
        [XmlAttribute(AttributeName = "id")]
        public string id { get; set; }
        [XmlElement(ElementName = "eFinanceira", Namespace = "http://www.eFinanceira.gov.br/schemas/evtMovOpFin/v1_2_0")]
        public EFinanceira2 eFinanceira { get; set; }
    }

    [XmlRootAttribute(ElementName = "eFinanceira")]
    public class EFinanceira2
    {
        #region codigo não utilizado
        //[XmlAttribute(AttributeName = "xmlns")]
        //public string xmlns { get; set; }
        #endregion
        [XmlElement(ElementName = "evtMovOpFin")]
        public EvtMovOpFin evtMovOpFin { get; set; }
    }

    [XmlRootAttribute(ElementName = "evtMovOpFin")]
    public class EvtMovOpFin
    {
        [XmlAttribute(AttributeName = "id")]
        public string id { get; set; }
        [XmlElement(ElementName = "ideEvento")]
        public IdeEvento ideEvento { get; set; }
        [XmlElement(ElementName = "ideDeclarante")]
        public IdeDeclarante ideDeclarante { get; set; }
        [XmlElement(ElementName = "ideDeclarado")]
        public IdeDeclarado ideDeclarado { get; set; }
        [XmlElement(ElementName = "mesCaixa")]
        public object mesCaixa { get; set; }
    }

    [XmlRootAttribute(ElementName = "ideDeclarado")]
    public class IdeDeclarado
    {
        [XmlElement(ElementName = "tpNI")]
        public string tpNI { get; set; }
        [XmlElement(ElementName = "NIDeclarado")]
        public string NIDeclarado { get; set; }
        [XmlElement(ElementName = "NomeDeclarado")]
        public string NomeDeclarado { get; set; }
        [XmlElement(ElementName = "DataNasc")]
        public string DataNasc { get; set; }
        [XmlElement(ElementName = "EnderecoLivre")]
        public string EnderecoLivre { get; set; }
        [XmlElement(ElementName = "PaisEndereco")]
        public PaisEndereco PaisEndereco { get; set; }
        [XmlElement(ElementName = "paisResid")]
        public PaisResid paisResid { get; set; }
        [XmlElement(ElementName = "PaisNacionalidade")]
        public PaisNacionalidade PaisNacionalidade { get; set; }
    }
    #endregion

    #region classes do movimento prev - envio
    [XmlRoot(ElementName = "eFinanceira")]
    public class EFinanceira1Prev
    {
        [XmlElement(ElementName = "loteEventos")]
        public LoteEventosPrev loteEventosPrev { get; set; }
    }

    [XmlRootAttribute(ElementName = "loteEventos")]
    public class LoteEventosPrev
    {
        [XmlAttribute(AttributeName = "id")]
        public string id { get; set; }
        [XmlElement(ElementName = "evento")]
        public List<EventoPrev> evento { get; set; }
    }

    [XmlRootAttribute(ElementName = "evento")]
    public class EventoPrev
    {
        [XmlAttribute(AttributeName = "id")]
        public string id { get; set; }
        [XmlElement(ElementName = "eFinanceira", Namespace = "http://www.eFinanceira.gov.br/schemas/evtMovPP/v1_2_3")]
        public EFinanceira2Prev eFinanceira { get; set; }
    }

    [XmlRootAttribute(ElementName = "eFinanceira")]
    public class EFinanceira2Prev
    {
        [XmlElement(ElementName = "evtMovPP")]
        public EvtMovPP evtMovPP { get; set; }
    }

    [XmlRootAttribute(ElementName = "evtMovPP")]
    public class EvtMovPP
    {
        [XmlAttribute(AttributeName = "id")]
        public string id { get; set; }
        [XmlElement(ElementName = "ideEvento")]
        public IdeEvento ideEvento { get; set; }
        [XmlElement(ElementName = "ideDeclarante")]
        public object ideDeclarante { get; set; }
        [XmlElement(ElementName = "ideDeclarado")]
        public IdeDeclaradoPrev ideDeclarado { get; set; }
        [XmlElement(ElementName = "mesCaixa")]
        public object mesCaixa { get; set; }
    }


    [XmlRootAttribute(ElementName = "ideDeclarado")]
    public class IdeDeclaradoPrev
    {
        [XmlElement(ElementName = "tpNI")]
        public string tpNI { get; set; }
        [XmlElement(ElementName = "NIDeclarado")]
        public string NIDeclarado { get; set; }
        [XmlElement(ElementName = "NomeDeclarado")]
        public string NomeDeclarado { get; set; }
    }
    #endregion

    #region classes do movimento prev - retorno
    [XmlRoot(ElementName = "eFinanceira")]
    public class EFinanceira1PrevRet
    {
        [XmlElement(ElementName = "retornoLoteEventos")]
        public RetornoLoteEventosPrev retornoLoteEventos { get; set; }
        [XmlElement(ElementName = "Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public object Signature { get; set; }
    }

    [XmlRootAttribute(ElementName = "retornoLoteEventos")]
    public class RetornoLoteEventosPrev
    {
        [XmlAttribute(AttributeName = "id")]
        public string id { get; set; }
        [XmlElement(ElementName = "ideTransmissor")]
        public IdeTransmissor ideTransmissor { get; set; }
        [XmlElement(ElementName = "status")]
        public StatusRet status { get; set; }
        [XmlElement(ElementName = "retornoEventos")]
        public RetornoEventosPrev retornoEventos { get; set; }
    }

    [XmlRootAttribute(ElementName = "ideTransmissor")]
    public class IdeTransmissor
    {
        [XmlElement(ElementName = "IdTransmissor")]
        public string IdTransmissor { get; set; }
    }

    [XmlRootAttribute(ElementName = "status")]
    public class StatusRet
    {
        [XmlElement(ElementName = "cdStatus")]
        public string cdStatus { get; set; }
        [XmlElement(ElementName = "descRetorno")]
        public string descRetorno { get; set; }
    }

    [XmlRootAttribute(ElementName = "retornoEventos")]
    public class RetornoEventosPrev
    {
        [XmlAttribute(AttributeName = "id")]
        public string id { get; set; }
        [XmlElement(ElementName = "evento")]
        public List<EventoRet> evento { get; set; }
    }

    [XmlRootAttribute(ElementName = "evento")]
    public class EventoRet
    {
        [XmlAttribute(AttributeName = "id")]
        public string id { get; set; }
        [XmlElement(ElementName = "eFinanceira", Namespace = "http://www.eFinanceira.gov.br/schemas/retornoEvento/v1_2_0")]
        public EFinanceira2PrevRet eFinanceira { get; set; }
    }

    [XmlRootAttribute(ElementName = "eFinanceira")]
    public class EFinanceira2PrevRet
    {
        [XmlElement(ElementName = "retornoEvento")]
        public RetornoEventoPrev retornoEvento { get; set; }
        [XmlElement(ElementName = "Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public object Signature { get; set; }
    }

    [XmlRootAttribute(ElementName = "retornoEvento ")]
    public class RetornoEventoPrev
    {
        [XmlAttribute(AttributeName = "id")]
        public string id { get; set; }
        [XmlElement(ElementName = "identificacaoEmpresaDeclarante")]
        public IdentificacaoEmpresaDeclarante identificacaoEmpresaDeclarante { get; set; }
        [XmlElement(ElementName = "dadosRecepcaoEvento")]
        public DadosRecepcaoEvento dadosRecepcaoEvento { get; set; }
        [XmlElement(ElementName = "status")]
        public StatusEvento status { get; set; }
        [XmlElement(ElementName = "dadosReciboEntrega")]
        public DadosReciboEntrega dadosReciboEntrega { get; set; }
    }

    [XmlRootAttribute(ElementName = "identificacaoEmpresaDeclarante")]
    public class IdentificacaoEmpresaDeclarante
    {
        [XmlElement(ElementName = "cnpjEmpresaDeclarante")]
        public string cnpjEmpresaDeclarante { get; set; }
    }

    [XmlRootAttribute(ElementName = "status")]
    public class StatusEvento
    {
        [XmlElement(ElementName = "cdRetorno")]
        public string cdRetorno { get; set; }
        [XmlElement(ElementName = "descRetorno")]
        public string descRetorno { get; set; }

        [XmlElement(ElementName = "dadosRegistroOcorrenciaEvento")]
        public DadosRegistroOcorrenciaEvento dadosRegistroOcorrenciaEvento { get; set; }
    }

    [XmlRootAttribute(ElementName = "dadosRegistroOcorrenciaEvento")]
    public class DadosRegistroOcorrenciaEvento
    {
        [XmlElement(ElementName = "ocorrencias")]
        public List<Ocorrencias> ocorrencias { get; set; }
    }

    [XmlRootAttribute(ElementName = "ocorrencias")]
    public class Ocorrencias
    {
        [XmlElement(ElementName = "tipo")]
        public string tipo { get; set; }
        [XmlElement(ElementName = "localizacaoErroAviso")]
        public string localizacaoErroAviso { get; set; }
        [XmlElement(ElementName = "codigo")]
        public string codigo { get; set; }
        [XmlElement(ElementName = "descricao")]
        public string descricao { get; set; }
    }

    [XmlRootAttribute(ElementName = "dadosReciboEntrega")]
    public class DadosReciboEntrega
    {
        [XmlElement(ElementName = "numeroRecibo")]
        public string numeroRecibo { get; set; }
    }

    [XmlRootAttribute(ElementName = "dadosRecepcaoEvento")]
    public class DadosRecepcaoEvento
    {
        [XmlElement(ElementName = "dhProcessamento")]
        public string dhProcessamento { get; set; }
        [XmlElement(ElementName = "tipoEvento")]
        public string tipoEvento { get; set; }
        [XmlElement(ElementName = "idEvento")]
        public string idEvento { get; set; }
        [XmlElement(ElementName = "hash")]
        public string hash { get; set; }
        [XmlElement(ElementName = "nrRecibo")]
        public string nrRecibo { get; set; }
    }
    #endregion

    #region classes de retorno web
    [XmlRoot(ElementName = "eFinanceira")]
    public class EFinanceira1Web
    {
        [XmlElement(ElementName = "retornoConsultaInformacoesMovimento")]
        public RetornoConsultaInformacoesMovimento retornoConsultaInformacoesMovimento { get; set; }
    }

    [XmlRoot(ElementName = "retornoConsultaInformacoesMovimento")]
    public class RetornoConsultaInformacoesMovimento
    {
        [XmlElement(ElementName = "dataHoraProcessamento")]
        public string dataHoraProcessamento { get; set; }
        [XmlElement(ElementName = "status")]
        public StatusRet status { get; set; }
        [XmlElement(ElementName = "identificacaoEmpresaDeclarante")]
        public IdentificacaoEmpresaDeclarante identificacaoEmpresaDeclarante { get; set; }
        [XmlElement(ElementName = "informacoesMovimento")]
        public List<InformacoesMovimento> informacoesMovimento { get; set; }
    }
    [XmlRoot(ElementName = "informacoesMovimento")]
    public class InformacoesMovimento
    {
        [XmlElement(ElementName = "tipoMovimento")]
        public string tipoMovimento { get; set; }
        [XmlElement(ElementName = "tipoNI")]
        public string tipoNI { get; set; }
        [XmlElement(ElementName = "NI")]
        public string NI { get; set; }
        [XmlElement(ElementName = "anoMesCaixa")]
        public string anoMesCaixa { get; set; }
        [XmlElement(ElementName = "situacao")]
        public string situacao { get; set; }
        [XmlElement(ElementName = "numeroRecibo")]
        public string numeroRecibo { get; set; }
        [XmlElement(ElementName = "id")]
        public string id { get; set; }
    }
    #endregion

    #region classes compartilhadas
    [XmlRootAttribute("ideDeclarante")]
    public class IdeDeclarante
    {
        [XmlElement(ElementName = "ideDeclarante")]
        public string ideDeclarante { get; set; }
    }

    [XmlRootAttribute("PaisEndereco")]
    public class PaisEndereco
    {
        [XmlElement(ElementName = "Pais")]
        public string Pais { get; set; }

    }
    [XmlRootAttribute("paisResid")]
    public class PaisResid
    {
        [XmlElement(ElementName = "Pais")]
        public string Pais { get; set; }
    }

    [XmlRootAttribute("PaisNacionalidade")]
    public class PaisNacionalidade
    {
        [XmlElement(ElementName = "Pais")]
        public string Pais { get; set; }

    }
    [XmlRootAttribute("ideEvento")]
    public class IdeEvento
    {
        [XmlElement(ElementName = "indRetificacao")]
        public string indRetificacao { get; set; }
        [XmlElement(ElementName = "nrRecibo")]
        public string nrRecibo { get; set; }
        [XmlElement(ElementName = "tpAmb")]
        public string tpAmb { get; set; }
        [XmlElement(ElementName = "aplicEmi")]
        public string aplicEmi { get; set; }
        [XmlElement(ElementName = "verAplic")]
        public string verAplic { get; set; }
    }
    public class GridViewApresenta : IdeEvento
    {
        public string idEvento { get; set; }
        public string nomeArquivo { get; set; }
        public string status { get; set; }
        public string numeroRecibo { get; set; }
        public string anoMesCaixa { get; set; }
        public string cpf { get; set; }
    }
    #endregion
}
