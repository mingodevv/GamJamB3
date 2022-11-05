using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonRajouterEau : MonoBehaviour
{
    public Slider slider;
    Animator animButton;
    bool mouseDown = false;
    void Start()
    {
        animButton = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mouseDown = true;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            mouseDown = false;
        }
    }
    public void HoldValve()
    {
        if(ScriptMain.StepGame == 3 && mouseDown == true)
        {
            slider.value += 0.01f;
            animButton.SetBool("True", true);
        }
        
        
    }

}
