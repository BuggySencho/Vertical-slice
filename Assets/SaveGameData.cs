using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveGameData : ReadJson
{
    public void SaveData()
    {
        path = Application.persistentDataPath + "/" + filename;
        // saves the GameData value into a contents variable
        string contents = JsonUtility.ToJson(gameData, true);
        // writes the contents variable to the json file
        System.IO.File.WriteAllText(path, contents);
    }
}
