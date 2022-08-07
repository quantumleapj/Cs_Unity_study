using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class playManager : MonoBehaviour
{
    DataManager dataManager;
    public item[] gameitems; //datamanager will make this data 
    public paragraph[] storys; //datamanager will make this data 
    public player player;
    
    public Button button1;
    public TMP_Text maintext;
    public TMP_Text playername;
    public TMP_Text playerskill;


    // Start is called before the first frame update
    void Start()
    {
        maintext.text = "it's not started?";
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void Button1Clicked(){

        if(gameitems[0]!=null){
        setPlayCanvas(2);
        }
    }

    public void setPlayCanvas(int paragraphNumber){
        playername.text=player.name;
        playerskill.text=player.skills[0].name;
        maintext.text = storys[paragraphNumber].mainText;
        
    }
}
