using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHair : MonoBehaviour
{
    [SerializeField]
    private GameObject[] hairStyle;
    [SerializeField]
    private GameObject hair;
    [SerializeField]
    private Transform hairSpawnPoint;
    private bool selected = false;
    // Update is called once per frame

    private void Start()
    {

    }
    void Update()
    {
        HairSpawner();
    }

    void HairSpawner()
    {
        if (hair == null && !selected)
        {
            Destroy(gameObject);
            hair = Instantiate(hairStyle[HairSelect.hairPrefNum], hairSpawnPoint.position, hairSpawnPoint.rotation);
            selected = true;
            Debug.Log("true");
        }

        if (hair != null && selected)
        {
            Destroy(gameObject);
            hair = Instantiate(hairStyle[HairSelect.hairPrefNum], hairSpawnPoint.position, hairSpawnPoint.rotation);
            selected = false;
            Debug.Log("false");
        }
    }
}
