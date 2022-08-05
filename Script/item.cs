using System.Xml.Serialization;

[XmlType("item")]
public class item{
    [XmlElement("itemId")]
    public string itemId;
    
    [XmlElement("name")]
    public string name;
    
    [XmlElement("type")]
    public string type;

    [XmlElement("description")]
    public string description;

    
    [XmlElement("weight")]
    public int weight;

    
    [XmlElement("value")]
    public int value;

    
    [XmlElement("warmth")]
    public string warmth;

    
    [XmlElement("slot")]
    public string slot;

}
