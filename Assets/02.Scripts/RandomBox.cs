using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RandomBox : MonoBehaviour
{
    public long Test = 500;
    protected GameManager GameManager => GameManager.Instance;

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

            if (GameManager.money < 50)
            {
                Debug.Log("돈이 부족합니다.");
            }
            else
            {
                GameManager.money = GameManager.money - 50;
                if (RankRandom <= 60)
                {
                    int Cspawn = UnityEngine.Random.Range(1, 13);

                    if (Cspawn == 1)
                    {
                        Debug.Log("Cat");
                    }
                    else if (Cspawn == 2)
                    {
                        Debug.Log("Ant");
                    }
                    else if (Cspawn == 3)
                    {
                        Debug.Log("Chick");
                    }
                    else if (Cspawn == 4)
                    {
                        Debug.Log("Chicken");
                    }
                    else if (Cspawn == 5)
                    {
                        Debug.Log("Cochineal");
                    }
                    else if (Cspawn == 6)
                    {
                        Debug.Log("Cow");
                    }
                    else if (Cspawn == 7)
                    {
                        Debug.Log("Dog");
                    }
                    else if (Cspawn == 8)
                    {
                        Debug.Log("Fox");
                    }
                    else if (Cspawn == 9)
                    {
                        Debug.Log("GuineaPig");
                    }
                    else if (Cspawn == 10)
                    {
                        Debug.Log("Pig");
                    }
                    else if (Cspawn == 11)
                    {
                        Debug.Log("Sheep");
                    }
                    else if (Cspawn == 12)
                    {
                        Debug.Log("Worm");
                    }

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
                    int Lspawn = UnityEngine.Random.Range(1, 5);
                }
            }
        }

    }
}
