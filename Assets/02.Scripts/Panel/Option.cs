using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option : MonoBehaviour
{
    public GameObject PanelOption;
    public GameObject ButtonBack;

    void Start()
    {
        PanelOption.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PanelOption.SetActive(false);
        }
    }

    public void ButtonOption_Clicked()
    {
        PanelOption.SetActive(true);
    }

    public void ButtonBack_Clicked()
    { 
        PanelOption.SetActive(false);  
    }
}
