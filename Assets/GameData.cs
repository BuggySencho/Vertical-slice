using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData : HairSelect
{
    // hairtype variable that gets pushed to the json file, is used to get the right hair prefab
    public int hairType =  hairPrefNum;
}
