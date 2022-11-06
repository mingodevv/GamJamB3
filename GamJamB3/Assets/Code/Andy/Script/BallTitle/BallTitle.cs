using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTitle : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(AnimBall());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator AnimBall()
    {
        yield return new WaitForSeconds(4f);

        animator.SetBool("True", true);

        yield return new WaitForSeconds(2.2f);

        animator.SetBool("True", false);

        yield return new WaitForSeconds(0.2f);

        StartCoroutine(AnimBall());
    }
}
