using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollTrou : MonoBehaviour
{
    public Animator animFin;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "CollMouse")
        {
            Destroy(collision.gameObject);
            animFin.SetBool("True", true);
            StartCoroutine(MenuMain());
        }
    }

    IEnumerator MenuMain()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("MenuMap");
    }

}
