using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HairSelect : SpawnHair
{
    public static int hairPrefNum;

    public void HairSelection(int selectedNum)
    {
        hairPrefNum = selectedNum;
        Debug.Log("pressed");
        Debug.Log(hairPrefNum);

        if (hair == null && !selected)
        {
            Destroy(gameObject);
            hair = Instantiate(hairStyle[hairPrefNum], hairSpawnPoint.position, hairSpawnPoint.rotation);
            selected = true;
            Debug.Log("true");
        }

        if (hair != null && selected)
        {
            Destroy(gameObject);
            hair = Instantiate(hairStyle[hairPrefNum], hairSpawnPoint.position, hairSpawnPoint.rotation);
            Debug.Log(hairPrefNum);
        }

    }
}
