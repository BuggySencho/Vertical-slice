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
        ReadData();
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
        //string contents = JsonUtility.ToJson(gameData, true);
        // reads the json file
        string Ian = System.IO.File.ReadAllText(path); // dit werkt
        Debug.Log(Ian);

        //gameData = JsonUtility.FromJson(Ian); // dit werkt niet
        JsonUtility.FromJsonOverwrite(Ian, gameData.hairType); // < SIlvan
        Debug.Log(gameData.hairType);
        //Debug.Log(path);
    }

    void SpawnCharacter()
    {
        
    }
}
