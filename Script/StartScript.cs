using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScript : MonoBehaviour
{
	public void timecall(){
    DateTime thistime;
    thistime = DateTime.Now;
		Debug.Log("timecall");
		Debug.Log(thistime);
	}
	
    // Start is called before the first frame update
    void Start()
    {
		Time.timeScale=1;
        
    }

    // Update is called once per frame
    void Update()
    {
    }
}
