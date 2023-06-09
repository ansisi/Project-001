using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class GameManager : MonoBehaviour
{
    public long money;
    public long moneyIncreaseAmount;
    public TMP_Text textMoney;
    public float raycastDistance = 10f;  // 레이캐스트의 길이
    private Camera mainCamera;  // 카메라

    public GameManager() { }
    public static GameManager Instance { get; private set; }    //싱글톤화

    // protected GameManager GameManager => GameManager.Instance;           //싱글톤 불러오기

    private void Awake()
    {
        if (Instance)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            transform.parent = null;
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        mainCamera = Camera.main;  // 메인 카메라 참조
    }

    // Update is called once per frame
    void Update()
    {
        ShowInfo();
        MoneyIncrease();
    }

    //소지금 증가
    void MoneyIncrease()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (EventSystem.current.IsPointerOverGameObject() == false) // UI 위에 있지 않을 때
            {
                Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
                RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, raycastDistance);

                // 레이의 시작점과 방향을 디버그 라인으로 표시
                Debug.DrawRay(ray.origin, ray.direction * raycastDistance, Color.red, 0.5f);

                if (hit.collider != null && hit.collider.CompareTag("MoneyObject"))
                {
                    money += moneyIncreaseAmount;   // '소지금'을 '소지금 증가량'만큼 증가시킴
                }
            }
        }
    }

    void ShowInfo()
    {
        if (money == 0)
            textMoney.text = "0";
        else
            textMoney.text = money.ToString("###,###");
    }
}
