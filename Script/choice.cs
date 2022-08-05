using System.Xml.Serialization;

[XmlType("choice")]
public class choice{
  [XmlElement("choiceId")]
  public int choiceId;
  [XmlElement("text")]
  public string choiceText;
  [XmlElement("sendTo")]
  public int sendTo;
  
  // [XmlElement("key")]
  // public string key;
}