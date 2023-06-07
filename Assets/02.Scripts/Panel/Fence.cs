using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fence : MonoBehaviour
{
    public GameObject PanelFence;
    public GameObject ButtonFence;
    public GameObject ButtonFence1;
    public GameObject ButtonFence2;
    public GameObject ButtonFence3;
    public GameObject ButtonBack;
    void Start()
    {
        PanelFence.SetActive(false);
    }

    public void ButtonFence_Clicked()
    {
        PanelFence.SetActive(true);
    }

    public void ButtonFence1_Clicked()
    {
        SceneManager.LoadScene("Fence1");
    }

    public void ButtonFence2_Clicked()
    {
        SceneManager.LoadScene("Fence2");
    }

    public void ButtonFence3_Clicked()
    {
        SceneManager.LoadScene("Fence3");
    }

    public void ButtonBack_Clicked()
    {
        PanelFence.SetActive(false);
    }
}
