using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBar2Script : MonoBehaviour
{
    public Slider sliderBar;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ClickBar2()
    {
        if(ScriptMain.StepGame == 1)
        {
            sliderBar.value += 0.02f;
        }
       
    }
}
