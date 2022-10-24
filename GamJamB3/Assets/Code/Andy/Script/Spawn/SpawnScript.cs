using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnScript : MonoBehaviour
{
    [SerializeField]  public GameObject Error;
    [SerializeField] int numberOfItems;



    void Start()
    {
        SpawnObject();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void SpawnObject()
    {
        for(int i= 0; i < numberOfItems; i++)
        {
            Vector2 position = new Vector2(Random.Range(0f, 10f), Random.Range(0f, 10f));
            Instantiate(Error,position,Quaternion.identity);
        }
    }
}
