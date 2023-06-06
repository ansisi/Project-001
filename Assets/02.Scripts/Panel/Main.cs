using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public GameObject PanelQuit;
    public GameObject PanelOption;
    public GameObject ButtonBack;

    void Start()
    {
        PanelQuit.SetActive(false);
    }

    public void ButtonOption_Clicked()
    { 
        PanelOption.SetActive(true); 
    }

    public void ButtonBack_Clicked() 
    { 
         ButtonBack.SetActive(false);
    }
    public void PanelQuit_Clicked()
    { 
        PanelQuit.SetActive(true);
    }

    public void PanelQuit_N_Clicked()
    { 
        PanelQuit.SetActive(false);
    }

    public void PanelQuit_Y_Clicked() 
    {
        Application.Quit();
    }

}
