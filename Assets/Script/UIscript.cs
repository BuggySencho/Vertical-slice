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
       Debug.Log(", height: " + objectRectTransform.rect.position);

        if (goUp == true)
        {
            rectTransform.localPosition += aPos;
            goUp = false;
        }
       if (goDown == true)
        {
            rectTransform.localPosition -= aPos;
            goDown = false;
        }
    }

void GoUp()
    {
        goUp = true;
        HN -= 1;
    }
    void GoDown()
    {
        goDown = true;
        HN += 1;
    }
}
