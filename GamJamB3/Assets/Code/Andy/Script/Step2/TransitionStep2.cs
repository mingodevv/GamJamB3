using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionStep2 : MonoBehaviour
{
    Animator animator;
    public GameObject obj1, obj2, obj3, obj4, obj5;
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
            obj1.SetActive(false);
            obj2.SetActive(false);
            obj3.SetActive(false);
            obj5.SetActive(false);
            obj4.SetActive(true);
            ok = true;
        }
    }
}
