using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace XMLTools
{
    [XmlRoot(ElementName = "eFinanceira")]
    public class EFinanceira1
    {
        //[XmlAttribute(AttributeName = "xsd")]
        //public string xsd { get; set; }
        //[XmlAttribute(AttributeName = "xsd", Namespace = "xsd:http://www.w3.org/2001/XMLSchema")]
        //public string xsi { get; set; }
        //[XmlAttribute(AttributeName = "xmlns", Namespace = "xsi:http://www.w3.org/2001/XMLSchema-instance")]
        //public string xmlns { get; set; }

        [XmlElement(ElementName = "loteEventos", Namespace = "")]
        public LoteEventos loteEventos { get; set; }
    }

    [XmlRootAttribute(ElementName = "loteEventos", Namespace = "")]
    public class LoteEventos
    {
        [XmlAttribute(AttributeName = "id", Namespace = "")]
        public string id { get; set; }
        [XmlElement(ElementName = "evento", Namespace = "")]
        public List<Evento> evento { get; set; }
    }

    [XmlRootAttribute(ElementName = "evento", Namespace = "")]
    public class Evento
    {
        [XmlAttribute(AttributeName = "id", Namespace = "")]
        public string id { get; set; }
        [XmlElement(ElementName = "eFinanceira", Namespace = "http://www.eFinanceira.gov.br/schemas/evtMovOpFin/v1_2_0")]
        public EFinanceira2 eFinanceira { get; set; }
    }

    [XmlRootAttribute(ElementName = "eFinanceira", Namespace = "http://www.eFinanceira.gov.br/schemas/evtMovOpFin/v1_2_0")]
    public class EFinanceira2
    {
        //[XmlAttribute(AttributeName = "xmlns", Namespace = "http://www.eFinanceira.gov.br/schemas/evtMovOpFin/v1_2_0")]
        //public string xmlns { get; set; }
        [XmlElement(ElementName = "evtMovOpFin", Namespace = "http://www.eFinanceira.gov.br/schemas/evtMovOpFin/v1_2_0")]
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
        public object ideDeclarante { get; set; }
        [XmlElement(ElementName = "ideDeclarado")]
        public object ideDeclarado { get; set; }
        [XmlElement(ElementName = "mesCaixa")]
        public object mesCaixa { get; set; }
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

    public class GridViewApresenta: IdeEvento
    {
        public string idEvento { get; set; }
    }


}
