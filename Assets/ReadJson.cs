using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadJson : MonoBehaviour
{
   protected string filename = "CharacterData.json";
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
        string contents = JsonUtility.ToJson(gameData, true);
        // reads the json file
        System.IO.File.ReadAllText(path);
        gameData = JsonUtility.FromJson<GameData>(contents);
        Debug.Log(gameData.hairType);
        Debug.Log(path);
    }
}
