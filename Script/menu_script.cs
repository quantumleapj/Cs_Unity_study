using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menu_script : MonoBehaviour
{
    public Button menuclosebutton;
    public Button menuopenbutton;

    // public Button menusavebutton;
    // public Button menuloadbutton;
    public Button menuexitbutton;


    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void menuclosebuttonClicked() {
        gameObject.SetActive(false);
    }

    public void menuopenbuttonClicked(){
        gameObject.SetActive(true);
    }

    public void menuexitbuttonClicked(){

        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying=false;
        #else
            Application.Quit();
        #endif
    }
}
