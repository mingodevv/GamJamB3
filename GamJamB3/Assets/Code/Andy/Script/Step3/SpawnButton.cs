using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.PlayerSettings;

public class SpawnButton : MonoBehaviour
{
    public GameObject SP1, SP2, SP3, SP4;
    public GameObject ButtonG1, ButtonG2, ButtonG3, ButtonG4;

    int nb1, nb2, nb3, nb4;
    bool ok = false;







    void Update()
    {
        if(ScriptMain.StepGame == 3 && SpawnCaptcha.plus == true && ok == false)
        {

            ok = true;
            nb1 = Random.Range(1, 5);


            if (nb1 == 1)
            {
                for (int i = 0; i < 1; i++)
                {
                    Vector2 position = SP1.transform.position;
                    Instantiate(ButtonG1, position, SP1.transform.rotation, SP1.transform);

                }

                nb2 = 2;
                StartCoroutine(nb2E());
            }
            else if (nb1 == 2)
            {
                for (int i = 0; i < 1; i++)
                {
                    Vector2 position = SP2.transform.position;
                    Instantiate(ButtonG1, position, SP2.transform.rotation, SP2.transform);

                }
                nb2 = 1;
                StartCoroutine(nb2E());
            }
            else if (nb1 == 3)
            {
                for (int i = 0; i < 1; i++)
                {
                    Vector2 position = SP3.transform.position;
                    Instantiate(ButtonG1, position, SP3.transform.rotation, SP3.transform);

                }
                nb2 = 4;
                StartCoroutine(nb2E());
            }
            else if(nb1 == 4)  
            {
                for (int i = 0; i < 1; i++)
                {
                    Vector2 position = SP4.transform.position;
                    Instantiate(ButtonG1, position, SP4.transform.rotation, SP4.transform);

                }
                nb2 = 3;
                StartCoroutine(nb2E());
            }
            


        }
    }

    IEnumerator nb2E()
    {

        if (nb2 == 1)
        {
            for (int i = 0; i < 1; i++)
            {
                Vector2 position = SP1.transform.position;
                Instantiate(ButtonG2, position, SP1.transform.rotation, SP1.transform);

            }

            nb3 = 3;
            StartCoroutine(nb3E());
        }
        else if (nb2 == 2)
        {
            for (int i = 0; i < 1; i++)
            {
                Vector2 position = SP2.transform.position;
                Instantiate(ButtonG2, position, SP2.transform.rotation, SP2.transform);

            }
            nb3 = 4;
            StartCoroutine(nb3E());
        }
        else if (nb2 == 3)
        {
            for (int i = 0; i < 1; i++)
            {
                Vector2 position = SP3.transform.position;
                Instantiate(ButtonG2, position, SP3.transform.rotation, SP3.transform);

            }
            nb3 = 2;
            StartCoroutine(nb3E());
        }
        else if (nb2 == 4)
        {
            for (int i = 0; i < 1; i++)
            {
                Vector2 position = SP4.transform.position;
                Instantiate(ButtonG2, position, SP4.transform.rotation, SP4.transform);

            }
            nb3 = 1;
            StartCoroutine(nb3E());
        }

        yield return new WaitForSeconds(0.1f);
    }

    IEnumerator nb3E()
    {
        if (nb3 == 1)
        {
            for (int i = 0; i < 1; i++)
            {
                Vector2 position = SP1.transform.position;
                Instantiate(ButtonG3, position, SP1.transform.rotation, SP1.transform);

            }

            nb4 = 2;
            StartCoroutine(nb4E());
        }
        else if (nb3 == 2)
        {
            for (int i = 0; i < 1; i++)
            {
                Vector2 position = SP2.transform.position;
                Instantiate(ButtonG3, position, SP2.transform.rotation, SP2.transform);

            }
            nb4 = 1;
            StartCoroutine(nb4E());
        }
        else if (nb3 == 3)
        {
            for (int i = 0; i < 1; i++)
            {
                Vector2 position = SP3.transform.position;
                Instantiate(ButtonG3, position, SP3.transform.rotation, SP3.transform);

            }
            nb4 = 4;
            StartCoroutine(nb4E());
        }
        else if (nb3 == 4)
        {
            for (int i = 0; i < 1; i++)
            {
                Vector2 position = SP4.transform.position;
                Instantiate(ButtonG3, position, SP4.transform.rotation, SP4.transform);

            }
            nb4 = 3;
            StartCoroutine(nb4E());
        }

        yield return new WaitForSeconds(0.1f);
    }

    IEnumerator nb4E()
    {
        if (nb4 == 1)
        {
            for (int i = 0; i < 1; i++)
            {
                Vector2 position = SP1.transform.position;
                Instantiate(ButtonG4, position, SP1.transform.rotation, SP1.transform);

            }


        }
        else if (nb4 == 2)
        {
            for (int i = 0; i < 1; i++)
            {
                Vector2 position = SP2.transform.position;
                Instantiate(ButtonG4, position, SP2.transform.rotation, SP2.transform);

            }

        }
        else if (nb4 == 3)
        {
            for (int i = 0; i < 1; i++)
            {
                Vector2 position = SP3.transform.position;
                Instantiate(ButtonG4, position, SP3.transform.rotation, SP3.transform);

            }

        }
        else if (nb4 == 4)
        {
            for (int i = 0; i < 1; i++)
            {
                Vector2 position = SP4.transform.position;
                Instantiate(ButtonG4, position, SP4.transform.rotation, SP4.transform);

            }

        }

        yield return new WaitForSeconds(0.1f);
    }
}
