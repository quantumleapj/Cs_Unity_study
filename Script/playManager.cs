using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class playManager : MonoBehaviour
{
    public TMP_Text maintext;
    DataManager dataManager;
    public item[] gameitems; //datamanager will make this data 
    public paragraph[] storys; //datamanager will make this data 

    public Button button1;


    // Start is called before the first frame update
    void Start()
    {
        maintext.text = "is this started?";
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void Button1Clicked(){

        if(gameitems[0]!=null){
        setPlayCanvas(gameitems[0].description);
        }
    }

    public void setPlayCanvas(string main_text){
        maintext.text = main_text;
    }
}
