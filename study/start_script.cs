using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class start_script : MonoBehaviour
{
    public Button StartButton;
        // Start is called before the first frame update
        
    public void StartButtonClicked()
    {
        SceneManager.LoadScene("MainScene");
    }
}
