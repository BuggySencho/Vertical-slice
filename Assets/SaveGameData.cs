using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveGameData : ReadJson
{

    //Werkt niet meer

 /*   public void SaveData()
    {
        path = Application.persistentDataPath + "/" + filename;
        // saves the GameData value into a contents variable
        //Debug.Log(gameData);
        string contents = JsonUtility.ToJson(gameData.hairType, true);
        //Debug.Log(contents);
        // writes the contents variable to the json file
        Debug.Log(path);
        Debug.Log(gameData.hairType);
        System.IO.File.WriteAllText(path, contents);
       // Debug.Log(HairSelect.hairPrefNum);
    }   */
}
