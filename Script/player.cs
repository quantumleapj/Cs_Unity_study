using System.Xml.Serialization;

[XmlType("player")]
public class player{
    [XmlElement("name")]
    public string name;

    [XmlElement("health")]
    public float health;


}
