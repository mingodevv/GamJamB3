using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    bool ok = false;
    public GameObject StopValve;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ScriptMain.StepGame == 4 && ok == false)
        {
            ok = true;
            StopValve.SetActive(true);
            StartCoroutine(EndGame());

        }
    }

    IEnumerator EndGame()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("EndGame");
    }
}
