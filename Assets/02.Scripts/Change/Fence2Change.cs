using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fence2Change : MonoBehaviour
{   
    public void SceneChange()
    {
        SceneManager.LoadScene("Fence2");
    }
}
