using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCaptcha : MonoBehaviour
{
    static public int rangeC = 0;
    int rangeSpawn = 0;
    float delay;
    static public bool ok = false;
    public GameObject CAPTCHpop1, CAPTCHpop2, CAPTCHpop3;
    public GameObject pos;
    public static bool plus = false;
    public AudioSource CaptchaSound;

    public static int suppC = 0;
    void Start()
    {
        rangeC = 0;
        suppC = 1;
        ok = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (ScriptMain.StepGame == 3 && ok == false)
        {
            randomSpawnF();
            suppC = 0;
            ok = true;
        }
        if (rangeC == suppC && ok == true)
        {
            StartCoroutine(waitForSpawn());
            suppC = 0;
        }
        if (ScriptMain.StepGame == -1)
        {
            ok = false;
        }
    }
    void randomSpawnF()
    {
        rangeC = 1;
        rangeSpawn = Random.Range(1,4);
        delay = Random.Range(1f, 2.5f);


        if(rangeSpawn == 1)
        {
            for (int i = 0; i < rangeC; i++)
            {
                Vector2 position = pos.transform.position;
                Instantiate(CAPTCHpop1, position, pos.transform.rotation, pos.transform);
                CaptchaSound.Play();
                plus = true;

            }
        }
        else if(rangeSpawn == 2)
        {
            for (int i = 0; i < rangeC; i++)
            {
                Vector2 position = pos.transform.position;
                Instantiate(CAPTCHpop2, position, pos.transform.rotation, pos.transform);
                CaptchaSound.Play();
                plus = true;

            }
        }
        else if (rangeSpawn == 3)
        {
            for (int i = 0; i < rangeC; i++)
            {
                Vector2 position = pos.transform.position;
                Instantiate(CAPTCHpop3, position, pos.transform.rotation, pos.transform);
                CaptchaSound.Play();
                plus = true;

            }
        }
        

    }
    IEnumerator waitForSpawn()
    {
        yield return new WaitForSeconds(delay);
        if (ok == true)
        {
            suppC = 0;
            randomSpawnF();
        }

    }
}
