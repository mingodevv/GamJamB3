using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidCaptcha : MonoBehaviour
{
    static public bool CarChoice = false;
    static public bool Sucess = false;

    Image image;
    public Sprite BadChoice, GoodChoice, NeutralChoice;
    void Start()
    {
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void ValidB()
   {
        if(CarChoice == false && SpawnCaptcha.plus == true)
        {
            image.sprite = BadChoice;
            StartCoroutine(NeutralDelay());
        }
        else if(CarChoice == true && SpawnCaptcha.plus == true)
        {
            image.sprite = GoodChoice;
            Sucess = true;
        }
      
   }

    IEnumerator NeutralDelay()
    {
        yield return new WaitForSeconds(0.5f);
        image.sprite = NeutralChoice;
    }
}
