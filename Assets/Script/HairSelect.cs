using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HairSelect : SpawnHair
{
    // the number of the hair prefab is saved in here
    public static int hairPrefNum;
    // array with all posible hairstyles
    [SerializeField]
    protected GameObject[] hairStyle;
    // hair object wich determens what hairstyle is currently displayed
    [SerializeField]
    protected GameObject hair;
    // position where the hair prefab will spawn
    [SerializeField]
    protected Transform hairSpawnPoint;


    private void Start()
    {
        HairSelection(0);
    }
    public void HairSelection(int selectedNum)
    {
        // makes the hair prefab number the number of the selected hairstyle
        hairPrefNum = selectedNum;
        Debug.Log(hairPrefNum);

        // spawns first hairpiece if there is no hair on the player
        if (hair == null)
        {
            // spawns hair at the right position and with the right rotation
            hair = Instantiate(hairStyle[hairPrefNum], hairSpawnPoint.position, hairSpawnPoint.rotation);
            Debug.Log("true");
        }

        // spawns another hairstyle if selected and destroys the previous hairstyle
        if (hair != null)
        {
            // destroys previous hairstyle and spawns hair at the right position and with the right rotation
            Destroy(hair);
            hair = Instantiate(hairStyle[hairPrefNum], hairSpawnPoint.position, hairSpawnPoint.rotation);
            Debug.Log(hairPrefNum);
        }

    }
}
