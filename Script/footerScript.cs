using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class footerScript : MonoBehaviour
{

    public TMP_Text footerText;
    private DateTime date { get; set;}
    private string dateString;

    // Start is called before the first frame update
    void Start()
    {
    //     date=DateTime.Now.ToLocalTime();
    //     dateString = String.Concat(date.ToLongDateString()," - ",date.ToLongTimeString());
    //  footerText.text=dateString;  
    }

    // Update is called once per frame
    void Update()
    {
        
        date=DateTime.Now.ToLocalTime();
        dateString = String.Concat(date.ToLongDateString()," - ",date.ToLongTimeString());
     footerText.text=dateString;   
    }

}
