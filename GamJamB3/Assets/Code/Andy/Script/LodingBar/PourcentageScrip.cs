using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PourcentageScrip : MonoBehaviour
{
    float pourcentageTxt = 0f;
    public TMP_Text pourcentTxt, pourcentTxt2;
    public Slider slider;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pourcentageTxt = slider.value;
        pourcentTxt.text = Mathf.Round(pourcentageTxt * 100f) + "%";

        pourcentageTxt = slider.value;
        pourcentTxt2.text = Mathf.Round(pourcentageTxt * 100f) + "%";

    }
}
