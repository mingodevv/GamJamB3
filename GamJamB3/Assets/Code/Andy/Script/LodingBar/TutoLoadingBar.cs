using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutoLoadingBar : MonoBehaviour
{
    int stepTutoNb = 0;
    float ValueBar = 0f;
    bool EndStep = false;
    bool Click = true;
    public  float SliderValue = 0f;

    public Slider slider;


    void Start()
    {
        StartCoroutine(BeginProgressE());
    }

    //Update
    void Update()
    {
        
        if(stepTutoNb == 0)
        {
            slider.value = ValueBar;
        }
        if(stepTutoNb == 2 && EndStep == false )
        {
            ValueBar = slider.value;
            EndStep = true;
            StartCoroutine(FinTutoE());
        }


        ClickMouseF();
        StopProgressBar();
        Step2Begin();

    }

    void Step2Begin()
    {
        if(slider.value >= 0.98)
        {
            StartCoroutine(WaitEndTutoE());
            Click = false;

        }
    }
    void StopProgressBar()
    {
        if (ValueBar >= 0.5)
        {
            ValueBar = 0.51f;
            stepTutoNb = 1;
            

        }
    }
    void ClickMouseF()
    {
        if (stepTutoNb == 1 && Click == true)
        {
            if (Input.GetMouseButtonDown(0))
            {

                slider.value += 0.01f;

            }

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
        yield return new WaitForSeconds(2f);
        stepTutoNb = 2;
    }
    IEnumerator FinTutoE()
    {
        yield return new WaitForSeconds(0.05f);
        if(slider.value >= 0)
        {
            slider.value -= 0.01f;
            StartCoroutine(FinTutoE());
        }
    }
}
