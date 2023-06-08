using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RandomBox : MonoBehaviour
{
    public long Test = 500;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int RankRandom = UnityEngine.Random.Range(1, 101);

            if (Test < 50)
            {
                Debug.Log("돈이 부족합니다.");
            }
            else
            {
                Test = Test - 50;
                if (RankRandom <= 60)
                {
                    Debug.Log("Common");
                }
                else if (RankRandom > 60 && RankRandom <= 90)
                {
                    Debug.Log("Rare");
                }
                else if (RankRandom > 90 && RankRandom <= 96)
                {
                    Debug.Log("Epic");
                }
                else
                {
                    Debug.Log("Legendary");
                }
            }
        }

    }
}
