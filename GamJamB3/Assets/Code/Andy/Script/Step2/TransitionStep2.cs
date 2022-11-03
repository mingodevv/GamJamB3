using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionStep2 : MonoBehaviour
{
    Animator animator;
    bool ok = false;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(ScriptMain.StepGame == 2 && ok == false)
        {
            animator.SetBool("True", true);
            ok = true;
        }
    }
}
