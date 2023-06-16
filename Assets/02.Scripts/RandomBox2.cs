using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RandomBox2 : MonoBehaviour
{

    public GameObject ButtonShop;
    //public Vector3 
    protected GameManager GameManager => GameManager.Instance;

    public GameObject[] Animal = new GameObject[30];

   



    public void OnClick()
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
                    //cat
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
                    GameObject temp2 = Instantiate(Animal[1]);
                    temp2.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
                }
                else if (Cspawn == 8)
                {
                    GameObject temp3 = Instantiate(Animal[2]);
                    temp3.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
                }
                else if (Cspawn == 9)
                {
                    GameObject temp4 = Instantiate(Animal[3]);
                    temp4.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
                }
                else if (Cspawn == 10)
                {
                    GameObject temp5 = Instantiate(Animal[7]);
                    temp5.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
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
                int Rspawn = UnityEngine.Random.Range(1, 12);
                if (Rspawn == 1)
                {
                    //기린
                }
                else if (Rspawn == 2)
                {
                    //판다
                }
                else if (Rspawn == 3)
                {
                    GameObject temp7 = Instantiate(Animal[5]);
                    temp7.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
                }
                else if (Rspawn == 4)
                {
                    GameObject temp11 = Instantiate(Animal[10]);
                    temp11.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
                }
                else if (Rspawn == 5)
                {
                    //악어
                }
                else if (Rspawn == 6)
                {
                    //나무늘보
                }
                else if (Rspawn == 7)
                {
                    //거미
                }
                else if (Rspawn == 8)
                {
                    GameObject temp6 = Instantiate(Animal[4]);
                    temp6.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
                }
                else if (Rspawn == 9)
                {
                    //독수리
                }
                else if (Rspawn == 10)
                {
                    //고래
                }
                else if (Rspawn == 11)
                {
                    GameObject temp10 = Instantiate(Animal[9]);
                    temp10.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
                }
            }
            else if (RankRandom > 90 && RankRandom <= 96)
            {
                int Espawn = UnityEngine.Random.Range(1, 8);
                if (Espawn == 1)
                {
                    //코뿔소
                }
                else if (Espawn == 2)
                {
                    GameObject temp8 = Instantiate(Animal[6]);
                    temp8.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
                }
                else if (Espawn == 3)
                {
                    //멍게
                }
                else if (Espawn == 4)
                {
                    //인간
                }
                else if (Espawn == 5)
                {
                    //모기
                }
                else if (Espawn == 6)
                {
                    //카멜레온
                }
                else if (Espawn == 7)
                {
                    GameObject temp9 = Instantiate(Animal[8]);
                    temp9.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
                }

            }
            else
            {
                int Lspawn = UnityEngine.Random.Range(1, 5);
                if (Lspawn == 1)
                {
                    //청룡
                }
                else if (Lspawn == 2)
                {
                    //불사조

                }
                else if (Lspawn == 3)
                {
                    //에일리언
                }
                else if (Lspawn == 4)
                {
                    GameObject temp = Instantiate(Animal[0]);
                    temp.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
                }
        
            }
        }
    }
}
