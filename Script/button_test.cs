using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button_test : MonoBehaviour
{
	public void Scene1(){
		Debug.Log("scene1 change");
		SceneManager.LoadScene("scene1");
	}
	public void Scene2(){
		Debug.Log("scene2 change");
		SceneManager.LoadScene("Scene2");
	}
	
	public void exit(){
		Debug.Log("quit");
		Application.Quit();
	}
}
