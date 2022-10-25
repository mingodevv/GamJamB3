using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarDiminuScript : MonoBehaviour
{
    bool ok = false;
    private Slider slider;
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if(ScriptMain.StepGame == 1)
        {
            if (slider.value >= 0.50 && ok == false)
            {
                ok = true;
                StartCoroutine(no100E());
            }
            if(slider.value <= 0)
            {
                ScriptMain.StepGame = -1;
            }
        }
        
    }
    IEnumerator no100E()
    {
        if(slider.value > 0 && ScriptMain.StepGame == 1)
        {
            yield return new WaitForSeconds(0.2f);
            slider.value -= 0.01f;
            StartCoroutine(no100E());
        }

    }
}
