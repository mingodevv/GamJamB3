using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarDiminuScript : MonoBehaviour
{
    bool ok = false;
    private Slider slider;
    public GameObject valve;
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
            if(slider.value >= 0.98)
            {
                StopAllCoroutines();
                ScriptMain.StepGame = 2;
                SpawnPopUp.ok = false;
                StartCoroutine(finStep1());
            }
        }
        
    }
    IEnumerator no100E()
    {
        if(slider.value > 0 && ScriptMain.StepGame == 1)
        {
            yield return new WaitForSeconds(0.3f);
            slider.value -= 0.01f;
            StartCoroutine(no100E());
        }

    }
    IEnumerator finStep1()
    {
        yield return new WaitForSeconds(0.05f);
        if (slider.value >= 0.2f)
        {
            slider.value -= 0.01f;
            StartCoroutine(finStep1());
        }
        if (slider.value <= 0.2f)
        {
            valve.SetActive(true);
            StopCoroutine(finStep1());
        }
    }
}
