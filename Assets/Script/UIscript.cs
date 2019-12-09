using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIscript : MonoBehaviour
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
    [SerializeField] private int HN = 3;
    [SerializeField] private RectTransform rectTransform;
    [SerializeField] private GameObject[] FNumbers;
    [SerializeField] private GameObject HSpawnPoint;

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
     //  Debug.Log(", height: " + objectRectTransform.rect.position);
        //              number = objectRectTransform.rect.height / 5.7f;

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
        switch (HN)
        {
            case 1:
                print("Hair number 1");
                Instantiate(FNumbers[HN]);
                break;
            case 2:
                print("Hair number 2");
                Instantiate(FNumbers[HN]);
                break;
            case 3:
                print("Hair number 3");
                Instantiate(FNumbers[HN]);
                break;
            case 4:
                print("Hair number 4");
                Instantiate(FNumbers[HN]);
                break;
            case 5:
                print("Hair number 5");
                Instantiate(FNumbers[HN]);
                break;
            case 6:
                print("Hair number 6");
                Instantiate(FNumbers[HN]);
                break;
            case 7:
                print("Hair number 7");
                Instantiate(FNumbers[HN]);
                break;
        }
    }

void GoUp()
    {
        //        scrollbar.transform.position -= new Vector3(0, number, 0);
        goUp = true;
        if(HN >= 2)
        {
            HN -= 1;
        }
    }
    void GoDown()
    {
        //        scrollbar.transform.position += new Vector3(0, number, 0);
        goDown = true;
        if(HN <= 6)
        {
            HN += 1;
        }
    }
}
