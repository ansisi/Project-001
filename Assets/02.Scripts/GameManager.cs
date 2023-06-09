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
    public float raycastDistance = 10f;  // ����ĳ��Ʈ�� ����
    private Camera mainCamera;  // ī�޶�

    public GameManager() { }
    public static GameManager Instance { get; private set; }    //�̱���ȭ

    // protected GameManager GameManager => GameManager.Instance;           //�̱��� �ҷ�����

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
        mainCamera = Camera.main;  // ���� ī�޶� ����
    }

    // Update is called once per frame
    void Update()
    {
        ShowInfo();
        MoneyIncrease();
    }

    //������ ����
    void MoneyIncrease()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (EventSystem.current.IsPointerOverGameObject() == false) // UI ���� ���� ���� ��
            {
                Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
                RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, raycastDistance);

                // ������ �������� ������ ����� �������� ǥ��
                Debug.DrawRay(ray.origin, ray.direction * raycastDistance, Color.red, 0.5f);

                if (hit.collider != null && hit.collider.CompareTag("MoneyObject"))
                {
                    money += moneyIncreaseAmount;   // '������'�� '������ ������'��ŭ ������Ŵ
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
