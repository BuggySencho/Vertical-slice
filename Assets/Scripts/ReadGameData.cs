using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using UnityEngine;

public class ReadGameData : MonoBehaviour
{
    public GameObject character;
    public GameObject [] hairPref;
    private int hairPrefNum;
    public string path;
    public string jsonString;

    // Start is called before the first frame update
    void Start()
    {
        path = Application.dataPath + "/StreamingAssets";
        jsonString = File.ReadAllText(path);
        Debug.Log(jsonString);
        Debug.Log("path: " + path);
        WriteToJson(selectedPrefab: hairPrefNum);
    }
    
    public void WriteToJson(int selectedPrefab)
    {
        
        hairPrefNum = selectedPrefab;
        JsonUtility.ToJson(hairPrefNum);
        Debug.Log(hairPrefNum);
    }

    public void ReadJson()
    {
        JsonUtility.FromJson<int>(hairPrefNum.ToString());
        Debug.Log(hairPrefNum);
    }
}