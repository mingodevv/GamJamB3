using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonChoice : MonoBehaviour
{
    public bool ThisB = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void choiceB()
    {
        if (ThisB == true && SpawnCaptcha.plus == true)
        {
            ValidCaptcha.CarChoice = true;
        }
        else if (ThisB == false && SpawnCaptcha.plus == true)
        {
            ValidCaptcha.CarChoice = false;
        }
    }
}
