using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour
{
    public GameObject PanelBook;
    public GameObject ButtonBack;

    void Start()
    {
        PanelBook.SetActive(false);
    }

    public void ButtonBook_Clicked()
    {
        PanelBook.SetActive(true);
    }

    public void ButtonBack_Clicked()
    {
        PanelBook.SetActive(false);
    }
}
