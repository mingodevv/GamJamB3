using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEditor;
using UnityEngine;

public class ErrorScript : MonoBehaviour
{
    private GameObject error;
    public static bool close = false;
    void Start()
    {
        close = false;
        error = GetComponent<GameObject>();
    }

    
    void Update()
    {

    }

    public void CloseWindowsError()
    {
        SpawnPopUp.suppPop += 1;
        close = true;
        Destroy(gameObject);
    }
}
