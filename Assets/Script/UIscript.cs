﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIscript : HairSelect
{
    [SerializeField] private Canvas canvas;
    [SerializeField] private GameObject scrollbar;
    [SerializeField] private float number = 100f;
    [SerializeField] private Button Up;
    [SerializeField] private Button Down;
    [SerializeField] private GameObject[] HButton;
    [SerializeField] private bool goUp = false;
    [SerializeField] private bool goDown = false;
    [SerializeField] private GameObject middle;
                     public static int HN = 0;
    [SerializeField] private RectTransform rectTransform;
    [SerializeField] private GameObject[] FNumbers;
    [SerializeField] protected Transform HSpawnPoint;
    [SerializeField] private GameObject parent;
    [SerializeField] private GameObject[] ActiveNumber;
    [SerializeField] private GameObject GreyUp;
    [SerializeField] private GameObject GreyDown;

    private void Start()
    {
        Up.onClick.AddListener(GoUp);
        Down.onClick.AddListener(GoDown);

    }
    private void Update()
    {
        Vector3 aPos = rectTransform.position;
        aPos = transform.position;
        aPos.x = aPos.z = 0;
        aPos.y = number;
       RectTransform objectRectTransform = GetComponent<RectTransform>();
        if (goUp == true)
        {
            rectTransform.localPosition -= aPos;
            goUp = false;
        }
       if (goDown == true)
        {
            rectTransform.localPosition += aPos;
            goDown = false;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            GoUp();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            GoDown();
        }
    }

    void GoUp()
    {
        //        scrollbar.transform.position -= new Vector3(0, number, 0);
        goUp = true;
        if (HN >= 1)
        {
            HN -= 1;
        }
        Switch();
    }
    void GoDown()
    {
        //        scrollbar.transform.position += new Vector3(0, number, 0);
        goDown = true;
        if (HN <= 5)
        {
            HN += 1;
        }
        Switch();
    }

    void Switch()
    {
        Number();
        if (HN == 0)
            GreyUp.SetActive(true);
        else if (HN == 6)
            GreyDown.SetActive(true);
        else
        {
            GreyDown.SetActive(false);
            GreyUp.SetActive(false);
        }
    }
    void Number()
    {
        //Debug.Log("efhkeh");
        Object.Destroy(GameObject.FindGameObjectWithTag("Number"));
        Instantiate(FNumbers[HN], GameObject.FindGameObjectWithTag("SpawnPoint").transform);
        HairSelection(HN);
    }
}
