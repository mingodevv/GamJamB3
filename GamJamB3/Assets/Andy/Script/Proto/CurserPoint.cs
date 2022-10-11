using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurserPoint : MonoBehaviour
{
    [SerializeField] private Camera Maincamera;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 WorldPointCurser = Maincamera.ScreenToWorldPoint(Input.mousePosition);
        WorldPointCurser.z = 0f;
        transform.position = WorldPointCurser;
    }
}
