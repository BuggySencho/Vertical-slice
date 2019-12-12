using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HairSelect : MonoBehaviour
{
    // the number of the hair prefab is saved in here
    static public int hairPrefNum;
    // array with all posible hairstyles
    public GameObject[] hairStyle;
    // hair object wich determens what hairstyle is currently displayed
    public GameObject hair;
    // position where the hair prefab will spawn
    public Transform hairSpawnPoint;

    private void Start()
    {
        HairSelection();
    }
    public void HairSelection()
    {        
        // makes the hair prefab number the number of the selected hairstyle
        hairPrefNum = UIscript.HN;
       Debug.Log(hairPrefNum);

        // spawns first hairpiece if there is no hair on the player
        if (hair == null)
        {
            // spawns hair at the right position and with the right rotation
            hair = Instantiate(hairStyle[0], hairSpawnPoint, false);
            hair.transform.position = hairSpawnPoint.position;
            hair.transform.rotation = hairSpawnPoint.rotation;
          //  hair.AddComponent<RotateChar>();
          //  Debug.Log("true");
        }

        // spawns another hairstyle if selected and destroys the previous hairstyle
        else
        {
            // destroys previous hairstyle and spawns hair at the right position and with the right rotation
            Destroy(hair);
            hair = Instantiate(hairStyle[hairPrefNum], hairSpawnPoint, false);
            hair.transform.position = hairSpawnPoint.position;
            hair.transform.rotation = hairSpawnPoint.rotation;
        //    hair.AddComponent<RotateChar>();
           // Debug.Log(hairPrefNum);
        }
    }
}