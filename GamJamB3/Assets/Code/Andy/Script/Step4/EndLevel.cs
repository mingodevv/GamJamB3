using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    bool ok = false;
    public GameObject StopValve, Txt;
    public Slider slider;
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
            Txt.SetActive(true);
            StartCoroutine(EndGame());

        }
    }

    IEnumerator EndGame()
    {
        yield return new WaitForSeconds(0.2f);
        slider.value = 1f;
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("EndGame");
    }
}
