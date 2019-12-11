using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RotateChar : MonoBehaviour
{
    Vector3 prevPos = Vector3.zero;
    Vector3 curPos = Vector3.zero;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            curPos = Input.mousePosition - prevPos;
            transform.Rotate(transform.up, -Vector3.Dot(curPos, Camera.main.transform.right), Space.World);
        }
        prevPos = Input.mousePosition;
    }
}
