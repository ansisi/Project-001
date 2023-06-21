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
    public Camera mainCamera;  // ī�޶�

    public List<int> myAnimal = new List<int>();

    public RandomBox2 randomBox2;

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
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    private void OnDestroy()    //�� ������Ʈ�� �ı��� ���
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;  //�̺�Ʈ�� �����Ѵ�. 
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "Fence1" || scene.name == "Fence2" || scene.name == "Farm")
        {
            GameObject temp = GameObject.FindGameObjectWithTag("SetSceneUI");
            textMoney = temp.GetComponent<SetSceneUI>().uimoney.GetComponent<TMP_Text>();

            textMoney.text = money.ToString();
            mainCamera = Camera.main;  // ���� ī�޶� ����

            randomBox2 = GetComponent<RandomBox2>();
            for (int i = 0; i < myAnimal.Count; i++)
            {
                GameObject tempObject = Instantiate(randomBox2.Animal[myAnimal[i]]);
                tempObject.transform.position = new Vector3(0.0f, 2.0f, 0.0f);
            }
        }

        if (scene.name == "Farm")
        {

            randomBox2.ButtonShop = GameObject.Find("Button_Shop");
            randomBox2.button = randomBox2.ButtonShop.GetComponent<Button>();
            randomBox2.button.onClick.AddListener(randomBox2.OnClick);

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
