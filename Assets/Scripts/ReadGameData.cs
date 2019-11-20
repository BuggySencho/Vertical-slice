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
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    public void Write()
    {
       // hairPrefNum = hairPref[];
        JsonUtility.ToJson(hairPrefNum);
    } 
}
