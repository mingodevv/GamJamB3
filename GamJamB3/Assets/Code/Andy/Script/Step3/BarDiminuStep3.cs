using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarDiminuStep3 : MonoBehaviour
{
    Slider slider;
    bool ok = false;
    void Start()
    {
     slider = GetComponent<Slider>();   
    }

    // Update is called once per frame
    void Update()
    {
        if(ScriptMain.StepGame == 3 && ok == false)
        {
            StartCoroutine(DiminuEau());
            ok = true;  
        }
        if (ScriptMain.StepGame == 3 && slider.value <= 0)
        {
            ScriptMain.StepGame = -1;
        }
    }

    IEnumerator DiminuEau()
    {
        if (slider.value > 0 && ScriptMain.StepGame == 3)
        {
            yield return new WaitForSeconds(0.3f);
            slider.value -= 0.01f;
            StartCoroutine(DiminuEau());

        }
        else
        {
            StopCoroutine(DiminuEau());
        }
    }
}
