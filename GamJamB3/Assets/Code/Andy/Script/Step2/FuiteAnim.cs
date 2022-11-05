using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class FuiteAnim : MonoBehaviour
{
    Slider Slider;
    bool ok = false;
    void Start()
    {
        Slider = GetComponent<Slider>();
        Slider.value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (ScriptMain.StepGame == 2 && ok == false)
        {
            StartCoroutine(StartAnimFuite());
            ok = true;
        }
    }
    
    IEnumerator StartAnimFuite()
    {
        yield return new WaitForSeconds(3f);
        StartCoroutine(AnimFuite());

    }
    IEnumerator AnimFuite()
    {
        yield return new WaitForSeconds(0.01f);
        if(Slider.value < 1)
        {
            Slider.value += 0.01f;
            StartCoroutine(AnimFuite());
        }
        else if(Slider.value == 1)
        {
            StopCoroutine(AnimFuite());
            StopCoroutine(StartAnimFuite());
        }
        
    }
}
