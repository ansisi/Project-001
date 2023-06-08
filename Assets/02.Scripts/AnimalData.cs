using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Animal Data", menuName = "Scriptable Object/Animal Data", order = int.MaxValue)]
public class AnimalData : ScriptableObject
{
    [Header("��� ���� �Ǿ����� Ȯ���ϴ� ����")]
    public bool isOpen;
    [Header("��� �̹���")]
    public Sprite lockImage;
    [Header("��� ���� �̹���")]
    public Sprite openImage;
    [Header("���� �̹���")]
    public Sprite animalImage;

    [Header("���� �̸�")]
    public string animalName;
    

    
    
}

