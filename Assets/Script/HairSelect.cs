using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HairSelect : MonoBehaviour
{
    public static int hairPrefNum;

    public void HairSelection(int selectedNum)
    {
        hairPrefNum = selectedNum;
    }
}
