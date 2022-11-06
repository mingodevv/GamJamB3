using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class SpawnPopUp : MonoBehaviour
{
    static public int range = 0;
    float randomX,randomY;
    float delay;
    static public bool ok = false;
    public GameObject errorpop;
    public GameObject pos;
    public static int plus = 0;

    public static int suppPop = 0;
    void Start()
    {
       range = 0;
       suppPop = 1;
       ok = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(ScriptMain.StepGame == 1 && ok == false)
        {
            randomSpawnF();
            suppPop = 0;
            ok = true;
        }
        if (range == suppPop && ok == true)
        {
            StartCoroutine(waitForSpawn());
            suppPop = 0;
        }
        if(ScriptMain.StepGame == -1)
        {
            ok = false;
        }
    }
    void randomSpawnF()
    {
        plus = 0;
        range = Random.Range(1, 5);
        delay = Random.Range(1f,2.8f);  
        for ( int i = 0; i < range; i++)
        {
            randomX = Random.Range(-50f, 50f);
            randomY = Random.Range(-50f, 50f);
            Vector2 position = pos.transform.position;
            position.x += randomX;
            position.y += randomY;
            Instantiate(errorpop, position, pos.transform.rotation, pos.transform);
            plus++;

        }
        
    }
    IEnumerator waitForSpawn()
    {
        yield return new WaitForSeconds(delay);
        if(ok == true)
        {
            randomSpawnF();
        }
        
    }
}
