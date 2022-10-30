using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(TitleAnimator());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator TitleAnimator()
    {
        yield return new WaitForSeconds(2f);
        animator.SetBool("True",true);
    }
}
