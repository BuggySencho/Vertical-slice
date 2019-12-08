using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadZoom : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            GetComponent<Camera>().fieldOfView--;
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            GetComponent<Camera>().fieldOfView++;
        }
    }
}
