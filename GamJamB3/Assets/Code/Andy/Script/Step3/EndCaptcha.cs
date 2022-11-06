using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCaptcha : MonoBehaviour
{

    void Update()
    {
        if(SpawnCaptcha.plus == true && ValidCaptcha.Sucess == true)
        {
            SpawnCaptcha.plus = false;
            ValidCaptcha.Sucess = false;
            ValidCaptcha.CarChoice = false;
            StartCoroutine(DestroyThis());
            
        }
        if(ScriptMain.StepGame == 4 && SpawnCaptcha.plus == true)
        {
            Destroy(gameObject);
        }
    }

    IEnumerator DestroyThis()
    {
        yield return new WaitForSeconds(0.1f);
        Destroy(gameObject);
        SpawnCaptcha.suppC = 1;
    }
}
