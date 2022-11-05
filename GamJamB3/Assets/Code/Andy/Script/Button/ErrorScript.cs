using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class ErrorScript : MonoBehaviour
{
    //int range = 0;
    public static bool close = false;
    public Sprite image1, image2, image3, image4;
    Image Pub;
    void Start()
    {
        close = false;
        Pub = GetComponent<Image>();
    }

    
    void Update()
    {
        if (SpawnPopUp.plus == 1)
        {
            Pub.sprite = image1;
        }
        else if (SpawnPopUp.plus == 2)
        {
            Pub.sprite = image2;
        }
        else if (SpawnPopUp.plus == 3)
        {
            Pub.sprite = image3;
        }
        else if (SpawnPopUp.plus == 4)
        {
            Pub.sprite = image4;
        }
    }

    public void CloseWindowsError()
    {
        SpawnPopUp.suppPop += 1;
        close = true;
        Destroy(gameObject);
    }
}
