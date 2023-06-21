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
    public Camera mainCamera;  // 카메라

    public List<int> myAnimal = new List<int>();

    public RandomBox2 randomBox2;

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
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    private void OnDestroy()    //이 오브젝트가 파괴될 경우
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;  //이벤트를 삭제한다. 
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "Fence1" || scene.name == "Fence2" || scene.name == "Farm")
        {
            GameObject temp = GameObject.FindGameObjectWithTag("SetSceneUI");
            textMoney = temp.GetComponent<SetSceneUI>().uimoney.GetComponent<TMP_Text>();

            textMoney.text = money.ToString();
            mainCamera = Camera.main;  // 메인 카메라 참조

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
