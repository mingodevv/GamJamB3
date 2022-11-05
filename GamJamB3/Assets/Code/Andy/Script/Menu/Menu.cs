using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    private void Start()
    {
        ScriptMain.StepGame = 0;
    }
    public void PlayButton()
    {
        SceneManager.LoadScene("MainLoadingMap");
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}
