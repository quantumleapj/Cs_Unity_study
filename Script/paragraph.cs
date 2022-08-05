using System.Xml.Serialization;

[XmlType("paragraph")]
public class paragraph{
    [XmlElement("mainText")]
    public string mainText;
    [XmlElement("type")]
    public string type;

    [XmlElement("choice")]
    public choice[] choice;

}
