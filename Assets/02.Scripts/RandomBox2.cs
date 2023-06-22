using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class RandomBox2 : MonoBehaviour
{

    public GameObject ButtonShop;
    public Button button;
    //public Vector3 
    protected GameManager GameManager => GameManager.Instance;

    public GameObject[] Animal = new GameObject[35];

    public void Start()
    {
        ButtonShop = GameObject.Find("Button_Shop");
        button = ButtonShop.GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }


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
                    GameObject temp10 = Instantiate(Animal[14]);
                    temp10.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
                    GameManager.myAnimal.Add(14);
                    Debug.Log("고양이");
                }
                else if (Cspawn == 2)
                {
                    GameObject temp10 = Instantiate(Animal[13]);
                    temp10.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
                    GameManager.myAnimal.Add(13);
                    Debug.Log("개미");

                }
                else if (Cspawn == 3)
                {
                    Debug.Log("Chick");
                    
                }
                else if (Cspawn == 4)
                {
                    GameObject temp10 = Instantiate(Animal[15]);
                    temp10.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
                    GameManager.myAnimal.Add(15);
                    Debug.Log("닭");
                }
                else if (Cspawn == 5)
                {
                    GameObject temp10 = Instantiate(Animal[22]);
                    temp10.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
                    GameManager.myAnimal.Add(22);
                    Debug.Log("연지벌레");
                }
                else if (Cspawn == 6)
                {
                    GameObject temp10 = Instantiate(Animal[17]);
                    temp10.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
                    GameManager.myAnimal.Add(17);
                    Debug.Log("소");
                }
                else if (Cspawn == 7)
                {
                    GameObject temp2 = Instantiate(Animal[1]);
                    temp2.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
                    GameManager.myAnimal.Add(1);
                    Debug.Log("개");
                }
                else if (Cspawn == 8)
                {
                    GameObject temp3 = Instantiate(Animal[2]);
                    temp3.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
                    GameManager.myAnimal.Add(2);
                    Debug.Log("여우");
                }
                else if (Cspawn == 9)
                {
                    GameObject temp4 = Instantiate(Animal[3]);
                    temp4.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
                    GameManager.myAnimal.Add(3);
                    Debug.Log("기니피그");
                }
                else if (Cspawn == 10)
                {
                    GameObject temp5 = Instantiate(Animal[7]);
                    temp5.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
                    GameManager.myAnimal.Add(7);
                    Debug.Log("돼지");
                }
                else if (Cspawn == 11)
                {
                    GameObject temp5 = Instantiate(Animal[7]);
                    temp5.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
                    GameManager.myAnimal.Add(7);
                    Debug.Log("양");
                }
                else if (Cspawn == 12)
                {
                    GameObject temp25 = Instantiate(Animal[25]);
                    temp25.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
                    GameManager.myAnimal.Add(25);
                    Debug.Log("지렁이");

                }

            }
            else if (RankRandom > 60 && RankRandom <= 90)
            {
                int Rspawn = UnityEngine.Random.Range(1, 12);
                if (Rspawn == 1)
                {
                    GameObject temp10 = Instantiate(Animal[23]);
                    temp10.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
                    GameManager.myAnimal.Add(23);
                    Debug.Log("기린");
                }
                else if (Rspawn == 2)
                {
                    GameObject temp10 = Instantiate(Animal[20]);
                    temp10.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
                    GameManager.myAnimal.Add(20);
                    Debug.Log("판다");
                }
                else if (Rspawn == 3)
                {
                    GameObject temp7 = Instantiate(Animal[5]);
                    temp7.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
                    GameManager.myAnimal.Add(5);
                    Debug.Log("원숭이");
                }
                else if (Rspawn == 4)
                {
                    GameObject temp11 = Instantiate(Animal[10]);
                    temp11.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
                    GameManager.myAnimal.Add(10);
                    Debug.Log("얼룩말");
                }
                else if (Rspawn == 5)
                {
                    GameObject temp10 = Instantiate(Animal[18]);
                    temp10.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
                    GameManager.myAnimal.Add(18);
                    Debug.Log("악어");
                }
                else if (Rspawn == 6)
                {
                    GameObject temp27 = Instantiate(Animal[27]);
                    temp27.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
                    GameManager.myAnimal.Add(27);
                }
                else if (Rspawn == 7)
                {
                    GameObject temp28 = Instantiate(Animal[28]);
                    temp28.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
                    GameManager.myAnimal.Add(28);
                }
                else if (Rspawn == 8)
                {
                    GameObject temp6 = Instantiate(Animal[4]);
                    temp6.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
                    GameManager.myAnimal.Add(4);
                }
                else if (Rspawn == 9)
                {
                    GameObject temp10 = Instantiate(Animal[12]);
                    temp10.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
                    GameManager.myAnimal.Add(12);

                    Debug.Log("독수리");
                }
                else if (Rspawn == 10)
                {
                    GameObject temp10 = Instantiate(Animal[21]);
                    temp10.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
                    GameManager.myAnimal.Add(21);

                    Debug.Log("고래");
                }
                else if (Rspawn == 11)
                {
                    GameObject temp10 = Instantiate(Animal[9]);
                    temp10.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
                    GameManager.myAnimal.Add(9);

                    Debug.Log("호랑이");
                }
            }
            else if (RankRandom > 90 && RankRandom <= 96)
            {
                int Espawn = UnityEngine.Random.Range(1, 8);
                if (Espawn == 1)
                {
                    GameObject temp29 = Instantiate(Animal[29]);
                    temp29.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
                    GameManager.myAnimal.Add(29);
                }
                else if (Espawn == 2)
                {
                    GameObject temp8 = Instantiate(Animal[6]);
                    temp8.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
                    GameManager.myAnimal.Add(6);
                }
                else if (Espawn == 3)
                {
                    GameObject temp10 = Instantiate(Animal[16]);
                    temp10.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
                    GameManager.myAnimal.Add(16);

                    Debug.Log("멍게");
                }
                else if (Espawn == 4)
                {
                    GameObject temp30= Instantiate(Animal[30]);
                    temp30.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
                    GameManager.myAnimal.Add(30);
                }
                else if (Espawn == 5)
                {
                    GameObject temp26 = Instantiate(Animal[26]);
                    temp26.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
                    GameManager.myAnimal.Add(26);
                }
                else if (Espawn == 6)
                {
                    GameObject temp31 = Instantiate(Animal[31]);
                    temp31.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
                    GameManager.myAnimal.Add(31);
                }
                else if (Espawn == 7)
                {
                    GameObject temp9 = Instantiate(Animal[8]);
                    temp9.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
                    GameManager.myAnimal.Add(8);
                }

            }
            else
            {
                int Lspawn = UnityEngine.Random.Range(1, 5);
                if (Lspawn == 1)
                {
                    GameObject temp10 = Instantiate(Animal[11]);
                    temp10.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
                    GameManager.myAnimal.Add(11);

                    Debug.Log("청룡");
                }
                else if (Lspawn == 2)
                {
                    //불사조

                }
                else if (Lspawn == 3)
                {
                    GameObject temp3 = Instantiate(Animal[24]);
                    temp3.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
                    GameManager.myAnimal.Add(24);

                    Debug.Log("에일리언");
                }
                else if (Lspawn == 4)
                {

                    GameObject temp = Instantiate(Animal[0]);
                    temp.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
                    GameManager.myAnimal.Add(0);
                }
        
            }
        }
    }
}
