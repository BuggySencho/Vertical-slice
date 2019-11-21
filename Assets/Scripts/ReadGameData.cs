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
    public int debug;
    
    // Start is called before the first frame update
    void Start()
    {
        
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
        debug = hairPrefNum;
        Debug.Log(hairPrefNum);
    }
}
