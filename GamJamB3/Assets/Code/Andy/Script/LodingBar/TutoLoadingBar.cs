using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutoLoadingBar : MonoBehaviour
{
    int stepTutoNb = 0;
    int ClickNb = 0;
    float ValueBar = 0f;

    public Slider slider;


    void Start()
    {
        StartCoroutine(BeginProgressE());
    }

    
    void Update()
    {
        if(ValueBar == 0.5)
        {
            ValueBar = 0.51f;
            StopCoroutine(BeginProgressE());
            stepTutoNb = 1;
        }
        slider.value = ValueBar;

    }
    void OnMouseDown()
    {
        if(stepTutoNb == 1)
        {
            Debug.Log("OK");
            for (ClickNb = 0; ClickNb < 10; ClickNb ++)
            {
                ClickNb++;
                slider.value += 0.1f ;
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
}
