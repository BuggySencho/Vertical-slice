﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHair : MonoBehaviour
{
    [SerializeField]
    protected GameObject[] hairStyle;
    [SerializeField]
    protected GameObject hair;
    [SerializeField]
    protected Transform hairSpawnPoint;
    protected bool selected = false;
    // Update is called once per frame

    private void Start()
    {

    }
    void Update()
    {
        HairSpawner();
    }

    public void HairSpawner()
    {
        if (hair == null && !selected)
        {
            hair = Instantiate(hairStyle[HairSelect.hairPrefNum], hairSpawnPoint.position, hairSpawnPoint.rotation);
            selected = true;
            Debug.Log("true");
        }


            Destroy(gameObject);
            hair = Instantiate(hairStyle[HairSelect.hairPrefNum], hairSpawnPoint.position, hairSpawnPoint.rotation);
        //    Debug.Log(HairSelect.hairPrefNum);
        
    }
}
