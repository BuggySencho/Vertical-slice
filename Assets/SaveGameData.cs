using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveGameData : ReadJson
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SaveData();
        }
        
    }

    void SaveData()
    {
        string contents = JsonUtility.ToJson(gameData, true);
        System.IO.File.WriteAllText(path, contents);
        Debug.Log("file saved");
    }
}
