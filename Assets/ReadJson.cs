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
        path = Application.persistentDataPath + "/" + filename;
        Debug.Log(path);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ReadData();
        }
    }

 /*   void SaveData()
    {
        string contents = JsonUtility.ToJson(gameData, true);
        System.IO.File.WriteAllText(path, contents);
        Debug.Log("file saved");
    } */

    void ReadData()
    {
        System.IO.File.ReadAllText(path);
        Debug.Log(gameData.hairType);
    }

}
