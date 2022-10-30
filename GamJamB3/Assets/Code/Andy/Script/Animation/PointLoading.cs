using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointLoading : MonoBehaviour
{
    Animator animator;
    public static bool StopAnimP = false;
    public float delay = 0f;
    public float delayFin = 0f;
    public float delayMiddle = 0.5f;
    void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(JumpP());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator JumpP()
    {
        yield return new WaitForSeconds(delay);
        animator.SetBool("True", true);
        yield return new WaitForSeconds(delayMiddle);
        animator.SetBool("True", false);
        yield return new WaitForSeconds(delayFin);
        StartCoroutine(JumpP());

    }
}
