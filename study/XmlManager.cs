using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using UnityEngine;

//https://ssscool.tistory.com/341
public class XmlManager : MonoBehaviour
{
    // Start is called before the first frame update

    string xmlFileName="gametext";

    void Start()
    {
        xmlLoad(xmlFileName);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void xmlLoad(string _filename){

        TextAsset textAst = (TextAsset)Resources.Load("GameText/"+_filename);

        XmlDocument doc = new XmlDocument();
        Debug.Log(textAst.text);
        doc.LoadXml(textAst.text);

        XmlNodeList all_nodes= doc.SelectNodes("gameItem/item");
        foreach (XmlNode node in all_nodes){
            Debug.Log("[at once]itemId : "+node.SelectSingleNode("itemId").InnerText);
        }

    }
}
