using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fence3Change : MonoBehaviour
{   
    public void SceneChange()
    {
        SceneManager.LoadScene("Fence3");
    }
}
