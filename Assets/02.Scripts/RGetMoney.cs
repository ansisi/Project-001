using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RGetMoney : MonoBehaviour
{
    protected GameManager GameManager => GameManager.Instance;
    // Start is called before the first frame update
    private void Start()
    {
        InvokeRepeating("IncreaseMoney", 5f, 5f);
    }

    void IncreaseMoney()
    {
        GameManager.money += 5;
    }
}
