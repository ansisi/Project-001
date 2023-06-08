using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainOption : MonoBehaviour
{
    public GameObject PanelMainOption;
    public GameObject ButtonBack;

    void Start()
    {
        PanelMainOption.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PanelMainOption.SetActive(false);
        }
    }

    public void ButtonMainOption_Clicked()
    {
        PanelMainOption.SetActive(true);
    }

    public void ButtonBack_Clicked()
    {
        PanelMainOption.SetActive(false);
    }
}

