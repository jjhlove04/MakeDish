using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : Singleton<UIManager>
{
    [Header("책 펼치는 효과를 위한 변수")]
    [SerializeField] private GameObject bookETC;
    [SerializeField] private GameObject recipeBook;
    private Sequence bookOpen;
    public void OpenMenu()
    {
        
    }

    protected override void Awake() 
    {
        base.Awake();
    }

    
}
