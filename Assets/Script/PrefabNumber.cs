using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabNumber : MonoBehaviour
{
    // the number of the hair prefab
    protected int hairPrefNum;

   public void HairSelection(int selectedNumber)
    {
        hairPrefNum = selectedNumber;
    }
}
