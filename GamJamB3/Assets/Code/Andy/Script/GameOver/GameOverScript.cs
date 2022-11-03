using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEditor.PlayerSettings;

public class GameOverScript : MonoBehaviour
{
    bool end = false;
    public GameObject errorpop1;
    public GameObject pos2;
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
            for (int i = 0; i < 1; i++)
            {
                Vector2 position = pos2.transform.position;
                Instantiate(errorpop1, position, pos2.transform.rotation, pos2.transform);

            }
        }
    }

    IEnumerator EndGame()
    {
        
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("MenuMap");
        

    }
}
