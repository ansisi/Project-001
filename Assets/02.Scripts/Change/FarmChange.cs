using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FarmChange : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("Farm");
    }
}
