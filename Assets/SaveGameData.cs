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

    public void SaveData()
    {
        // saves the GameData value into a contents variable
        string contents = JsonUtility.ToJson(gameData, true);
        // writes the contents variable to the json file
        System.IO.File.WriteAllText(path, contents);
        Debug.Log("file saved");
    }
}
