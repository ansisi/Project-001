using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Option : MonoBehaviour
{
    public GameObject PanelOption;
    public GameObject ButtonBack;
    public GameObject ButtonMain;

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

    public void ButtonMain_Clicked()
    {
        SceneManager.LoadScene("Main");
    }

    public void ButtonBack_Clicked()
    { 
        PanelOption.SetActive(false);  
    }
}
