using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIscript : MonoBehaviour
{
    [SerializeField] private Canvas canvas;
    [SerializeField]private GameObject scrollbar;
    [SerializeField] private float number;
    [SerializeField] private Button Up;
    [SerializeField] private Button Down;

    private void Start()
    {
        Up.onClick.AddListener(GoUp);
        Down.onClick.AddListener(GoDown);
    }
    private void Update()
    { 

        RectTransform objectRectTransform = gameObject.GetComponent<RectTransform>();
        Debug.Log("width: " + objectRectTransform.rect.width + ", height: " + objectRectTransform.rect.height);
        number = objectRectTransform.rect.height / 5.7f;

    }

    void GoUp()
    {
        scrollbar.transform.position -= new Vector3(0, number, 0);
    }
    void GoDown()
    {
        scrollbar.transform.position += new Vector3(0, number, 0);
    }
}
