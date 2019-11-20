using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using UnityEngine;

public class ReadGameData : MonoBehaviour
{
    public GameObject character;
    public GameObject hairType;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public string write()
    {
        return JsonUtility.ToJson(character, hairType);
    }    
}
