using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartChange : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("Start");
    }
}
