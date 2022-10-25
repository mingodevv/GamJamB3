using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBarScript : MonoBehaviour
{
    public static bool okTuto = false;
    private Image ButtonBar;
    void Start()
    {
        ButtonBar = GetComponent<Image>();
        ButtonBar.enabled = false;


    }

    // Update is called once per frame
    void Update()
    {
        if (okTuto == true)
        {
            ButtonBar.enabled = true;
            okTuto = false;
        }
    }

    public void ClickBarF()
    {
        TutoLoadingBar.addFloat += 0.01f;

    }



}
