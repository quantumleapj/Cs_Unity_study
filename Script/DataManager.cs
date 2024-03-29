using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Xml.Serialization;

public class DataManager : MonoBehaviour
{

    public playManager playManager;
    public item[] gameitems;
    public paragraph[] storys;

    public player player;


    // Start is called before the first frame update
    void Start()
    {
        LoadXmlData();
        LoadStoryData();
        defaultPlayerStart();
        playManager =  GameObject.Find("EventSystem").GetComponent<playManager>();
        PleaseBeShallowCopy();
        StartGameCanvas();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

//https://medium.com/codex/why-you-should-use-xml-data-for-your-unity-c-games-51fe15d30dc7
    public void LoadXmlData(){
        string path = $"{Application.dataPath}/Resources/GameText/gameitem.xml";

        XmlSerializer serializer = new XmlSerializer(typeof(item[]), new XmlRootAttribute("gameitem"));

        StreamReader reader = new StreamReader(path);
        using(reader){
        gameitems=(item[])serializer.Deserialize(reader.BaseStream);
        }
        reader.Close();

        //test
        // Debug.Log($"Loaded item : {gameitems[0]}");
        // Debug.Log($"itemID: {gameitems[0].name}");
        // Debug.Log($"description: {gameitems[0].description}");
        // Debug.Log($"description: {gameitems[0].value}");
        // Debug.Log($"description: {gameitems[0].warmth}");
        // if(gameitems[0].warmth == null){
        //     Debug.Log("warmth property of bone coin item is null");
        // }//it printed this log. 

    }

    public void LoadStoryData(){
        string path = $"{Application.dataPath}/Resources/GameText/story.xml";

        XmlSerializer serializer = new XmlSerializer(typeof(paragraph[]), new XmlRootAttribute("story"));

        StreamReader reader = new StreamReader(path);
        using(reader){
        storys=(paragraph[])serializer.Deserialize(reader.BaseStream);
        }
        reader.Close();

        // test
        // Debug.Log($"paragraph 0 :{storys[0].mainText}");
        // Debug.Log($"paragraph 0 :{storys[0].choice}");
        // Debug.Log($"paragraph 0 :{storys[0].choice[0].choiceText}");
        // Debug.Log($"paragraph 0 :{storys[0].choice.Length}");

    }

    public void defaultPlayerStart(){

        string path = $"{Application.dataPath}/Resources/GameText/defaultplayer.xml";

        XmlSerializer serializer = new XmlSerializer(typeof(player), new XmlRootAttribute("player"));

        StreamReader reader = new StreamReader(path);
        using(reader){
        player=(player)serializer.Deserialize(reader.BaseStream);
        }
        reader.Close();

    }

    public void PleaseBeShallowCopy(){
        //is this shallowcopy? i hope so. i'm not really sure though..

        playManager.storys=storys;
        playManager.gameitems=gameitems;
        playManager.player=player;

    }

    public void StartGameCanvas(){

        playManager.setPlayCanvas(0);

    }
}
