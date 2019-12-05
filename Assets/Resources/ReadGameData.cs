using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using UnityEngine;
using System;

public class ReadGameData : MonoBehaviour
{
    [SerializeField]
    private GameObject character;
    [SerializeField]
    private GameObject [] hairPref;
    [SerializeField]
    private int _hairPrefNum;
    
    [System.Serializable]
    public class CharacterData
    {
        public int hairStyle;
    }

    void Start()
    {
        //    var jsonFile = Resources.Load<TextAsset>("Resources/DataRead.json");
        string filePath = Application.persistentDataPath + "/Assets/Resources/DataRead.json";

        //   JsonUtility.ToJson(_hairPrefNum);
        print(filePath);
        CharacterData cd = JsonUtility.FromJson<CharacterData>(filePath);
        print(cd.hairStyle);
        /*
        if (jsonFile != null)
        {
            Debug.Log("working!");
        }

        if(jsonFile == null)
        {
            Debug.Log("not working");
        }
        */
      //  string file = Resources.Load<TextAsset>("Resources/DataRead.json").ToString();
      //  string jsonString = File.ReadAllText(file);
      // jsonString = File.ReadAllText(path);
      //   Debug.Log(jsonString);
      //   Debug.Log("path: " + path);
      // WriteToJson(selectedPrefab: _hairPrefNum);
      //    JsonInsert Yumo = JsonUtility.FromJson<JsonInsert>(jsonString);
      //     string newYumo = JsonUtility.ToJson(Yumo);
      //     Debug.Log(newYumo);
    }

    
    private void Update()
    {
        //JsonData.WriteToJson(_hairPrefNum);
       
    }
}


