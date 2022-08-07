using System.Xml.Serialization;
[XmlType("skill")]
public class skill{
  [XmlElement("code")]
  public int code;

  [XmlElement("name")]
  public string name;

  [XmlElement("level")]
  public int level;
  
}
