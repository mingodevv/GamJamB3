using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    bool end = false;
    void Start()
    {
        end = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(ScriptMain.StepGame == -1 && end == false)
        {
            
            StartCoroutine(EndGame());
            end = true;
        }
    }

    IEnumerator EndGame()
    {
        
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("MenuMap");
        

    }
}
