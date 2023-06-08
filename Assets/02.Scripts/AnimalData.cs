using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Animal Data", menuName = "Scriptable Object/Animal Data", order = int.MaxValue)]
public class AnimalData : ScriptableObject
{
    [Header("잠금 해제 되었는지 확인하는 변수")]
    public bool isOpen;
    [Header("잠금 이미지")]
    public Sprite lockImage;
    [Header("잠금 해제 이미지")]
    public Sprite openImage;
    [Header("동물 이미지")]
    public Sprite animalImage;

    [Header("동물 이름")]
    public string animalName;
    

    
    
}

