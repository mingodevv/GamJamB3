using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopValveS : MonoBehaviour
{
    public GameObject stopValve;
    bool ok = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ScriptMain.StepGame < 4)
        {
            if (SpawnCaptcha.plus == true && ok == false)
            {
                ok = true;
                stopValve.SetActive(true);
            }
            else if (SpawnCaptcha.plus == false && ok == true)
            {
                ok = false;
                stopValve.SetActive(false);
            }
        }
        
    }
}
