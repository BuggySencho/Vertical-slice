using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHair : HairSelect
{

    protected bool selected = false;
    // Update is called once per frame

    private void Start()
    {
        hairPrefNum = UIscript.HN;
        hair = Instantiate(hairStyle[HairSelect.hairPrefNum], hairSpawnPoint, false);
        if (hair == null && !selected)
        {
            hair = Instantiate(hairStyle[HairSelect.hairPrefNum], hairSpawnPoint, false);
        }
    }
    void Update()
    {
        HairSpawner();
    }

    public void HairSpawner()
    {
     /*   if (hair == null && !selected)
        {
            hair = Instantiate(hairStyle[HairSelect.hairPrefNum], hairSpawnPoint.position, hairSpawnPoint.rotation);
            selected = true;
            Debug.Log("true");
        }


            hair = Instantiate(hairStyle[HairSelect.hairPrefNum], hairSpawnPoint.position, hairSpawnPoint.rotation);
        //    Debug.Log(HairSelect.hairPrefNum); */
        
    } 
}
