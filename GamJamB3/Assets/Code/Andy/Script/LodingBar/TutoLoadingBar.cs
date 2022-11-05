using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor.PackageManager;


public class TutoLoadingBar : MonoBehaviour
{
    int stepTutoNb = 0;
    float ValueBar = 0f;
    public static float addFloat = 0.51f;
    bool EndStep = false;
    bool Click = true;
    public  float SliderValue = 0f;
    public GameObject pos;

    public Slider slider;
    public GameObject error;


    void Start()
    {
        StartCoroutine(BeginProgressE());
        ScriptMain.StepGame = 0;
        stepTutoNb = 0;
        ValueBar = 0f;
        EndStep = false;
        Click = true;
        SliderValue = 0f;
        addFloat = 0.51f;
    }

    //Update
    void Update()
    {
        if(ScriptMain.StepGame == 0)
        {
            if (stepTutoNb == 0)
            {
                slider.value = ValueBar;
            }
            if (stepTutoNb == 2 && EndStep == false)
            {
                ValueBar = slider.value;
                EndStep = true;
                StartCoroutine(FinTutoE());
            }
            if (ErrorScript.close == true && Click == false)
            {
                StartCoroutine(WaitEndTutoE());
            }


            ClickMouseF();
            StopProgressBar();
            Step2Begin();
        }
       

    }

    void Step2Begin()
    {
        if(slider.value >= 0.98 && Click == true)
        {
            for (int i = 0; i < 1; i++)
            {
                Vector2 position = pos.transform.position;
                Instantiate(error, position, pos.transform.rotation, pos.transform );
                
            }
            ButtonBarScript.okTuto = false;
            Click = false;

        }
    }
    void StopProgressBar()
    {
        bool ok = false;

        if (ValueBar >= 0.5 && ok == false)
        {
            ValueBar = 0.51f;
            stepTutoNb = 1;
            ok = true;
            
        }
        else
        {
            ok = false; 
        }
    }

    void ClickMouseF()
    {
        if (stepTutoNb == 1 && Click == true)
        {
            slider.value = addFloat;
            ButtonBarScript.okTuto = true;

        }
    }
    IEnumerator BeginProgressE()
    {
        yield return new WaitForSeconds(0.2f);
        if (ValueBar <= 0.5)
        {
            ValueBar += 0.01f;
            StartCoroutine(BeginProgressE());
        }
    }
    IEnumerator WaitEndTutoE()
    {
        if(stepTutoNb >= 1)
        {
            yield return new WaitForSeconds(1f);
            stepTutoNb = 2;
        }
        else
        {
            StopCoroutine(WaitEndTutoE());
        }
        
        
    }
    IEnumerator FinTutoE()
    {
        yield return new WaitForSeconds(0.05f);
        if(slider.value >= 0.02f)
        {
            slider.value -= 0.01f;
            StartCoroutine(FinTutoE());
        }
        if(slider.value <= 0.02f)
        {
            ErrorScript.close = false;
            stepTutoNb = 0;
            ScriptMain.StepGame = 1;
            StopCoroutine(FinTutoE());
        }

    }
}
