using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadJson : MonoBehaviour
{
    string filename = "CharacterData.json";
   protected string path;
   protected GameData gameData = new GameData();

    // Start is called before the first frame update
    void Start()
    {
        // reads path to the json file and saves it in the path variable
        path = Application.persistentDataPath + "/" + filename;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ReadData();
        }
    }

    void ReadData()
    {
        // reads the json file
        System.IO.File.ReadAllText(path);
        Debug.Log(gameData.hairType);
        Debug.Log(path);
    }
}
