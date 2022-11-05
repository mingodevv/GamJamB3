using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeBar : MonoBehaviour
{
    public Sprite changeImage;
    Image OwnImage;
    bool ok = false;

    void Start()
    {
        OwnImage = GetComponent<Image>();
        ok = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(ScriptMain.StepGame == 2 && ok == false)
        {
            StartCoroutine(ChangeImage());
            ok = true;
        }
    }
    IEnumerator ChangeImage()
    {
        yield return new WaitForSeconds(3f);
        OwnImage.sprite = changeImage;

    }
}
