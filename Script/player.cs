using System.Xml.Serialization;
// this is main data

[XmlType("player")]
public class player{
    [XmlElement("name")]
    public string name;

    [XmlElement("health")]
    public float health;

    [XmlElement("energy")]
    public float energy;

    
    [XmlElement("rest")]
    public float rest;

    [XmlElement("hunger")]
    public float hunger;

    
    [XmlElement("thirst")]
    public float thirst;

    
    [XmlElement("sanity")]
    public float sanity;

    
    [XmlElement("willpower")]
    public float willpower;

    [XmlElement("stress")]
    public float stress;

    
    [XmlElement("pain")]
    public float pain;

    
    [XmlElement("str")]
    public int str;


    [XmlElement("int")]
    public int intel; 

    
    [XmlElement("agl")]
    public int agl;

    
    [XmlElement("dex")]
    public int dex;

    
    [XmlElement("will")]
    public int will;

    
    [XmlElement("awe")]
    public int awe;

    
    [XmlElement("strExp")]
    public int strExp;

    
    [XmlElement("intExp")]
    public int intExp;

    
    [XmlElement("aglExp")]
    public int aglExp;

    
    [XmlElement("dexExp")]
    public int dexExp;

    
    [XmlElement("willExp")]
    public int willExp;

    
    [XmlElement("aweExp")]
    public int aweExp;

    
    // information
    [XmlElement("sex")]
    public string sex;
    
    [XmlElement("haircolor")]
    public string haricolor;

    
    [XmlElement("eyecolor")]
    public string eyecolor;

    
    [XmlElement("weight")]
    public float weight;

    
    [XmlElement("height")]
    public float height;

    
    [XmlElement("skill")]
    public skill[] skills ;

    // [XmlElement("")]
    // public;

}
