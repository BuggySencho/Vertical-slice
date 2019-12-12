using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{

    public UIscript uiScript;
    // Loads new scene
    public void Loading()
    {
        uiScript = GameObject.Find("Scrollbar").GetComponent<UIscript>();
        uiScript.canvasOBJ.SetActive(false);
     //  SceneManager.LoadScene("LoadPlayer");
    }
}