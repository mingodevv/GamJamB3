using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class ButtonRajouterEau : MonoBehaviour
{
    public Slider slider;
    public Slider Eau;
    bool ok = false;

    void Start()
    {
        Eau.value = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(slider.value == 1 && ScriptMain.StepGame == 3)
        {
            ScriptMain.StepGame = 4;
        }
        if (slider.value <= 1 && ScriptMain.StepGame == 3 && ok == false)
        {
            ok = true;
            StartCoroutine(waterUI());
        }

    }

    public void clickValue()
    {
        
        if (slider.value <= 1 && ScriptMain.StepGame == 3)
        {
            Eau.value += 0.02f;
            slider.value += 0.02f;
        }
        
 

    }
    IEnumerator waterUI()
    {
        yield return new WaitForSeconds(0.1f);

        if (slider.value <= 1 && ScriptMain.StepGame == 3)
        {
            Eau.value -= 0.01f;
            StartCoroutine(waterUI());
        }
    }
    
}
