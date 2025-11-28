using System;
using System.Xml.Serialization;

[Serializable]
public class ProdutoXML
{
    [XmlElement("id")]
    public int Id { get; set; }

    [XmlElement("nome")]
    public string Nome { get; set; }

    [XmlElement("preco")]
    public decimal Preco { get; set; }

    [XmlElement("quantidade")]
    public int Quantidade { get; set; }
}
