using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HairSelect : SaveGameData
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
        hairPrefNum = UIscript.HN;
       Debug.Log(hairPrefNum);

        // spawns first hairpiece if there is no hair on the player
        if (hair == null)
        {
            // spawns hair at the right position and with the right rotation
            hair = Instantiate(hairStyle[UIscript.HN], hairSpawnPoint, false);
            hair.transform.position = hairSpawnPoint.position;
            hair.transform.rotation = hairSpawnPoint.rotation;
          //  hair.AddComponent<RotateChar>();
            SaveData();
          //  Debug.Log("true");
        }

        // spawns another hairstyle if selected and destroys the previous hairstyle
        if (hair != null)
        {
            // destroys previous hairstyle and spawns hair at the right position and with the right rotation
            Destroy(hair);
            hair = Instantiate(hairStyle[UIscript.HN], hairSpawnPoint, false);
            hair.transform.position = hairSpawnPoint.position;
            hair.transform.rotation = hairSpawnPoint.rotation;
        //    hair.AddComponent<RotateChar>();
            gameData.hairType = hairPrefNum;
           // Debug.Log(hairPrefNum);
            SaveData();
        }
    }
}
