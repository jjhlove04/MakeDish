using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : Singleton<UIManager>
{
    [Header("책 펼치는 효과를 위한 변수")]
    [SerializeField] private GameObject bookFront;
    [SerializeField] private GameObject bookBack;
    [SerializeField] private GameObject recipeBook; 
    
    private Sequence OpenRecipe = DOTween.Sequence(); //TODO:  시퀀스로 책 여는 연출 만들기
    
    public void OpenMenu()
    {
        //버튼이 가운데로 움직이고 커진다음 회전으로 책 넘기는 효과.
        OpenRecipe.Append(recipeBook.transform.DOMove(new Vector3(350,200,0),0.5f));
        OpenRecipe.Append(recipeBook.transform.DOScale(new Vector3(8,8,0), 0.5f));
        OpenRecipe.Append(recipeBook.transform.DOMove(new Vector3(450,200,0),1f).SetEase(Ease.OutQuart).SetDelay(0.7f));

        bookBack.transform.position = recipeBook.transform.position;
    }

    protected override void Awake() 
    {
        base.Awake();
    }

    private void Start() {
        recipeBook.GetComponent<Button>().onClick.AddListener(() =>OpenMenu());

    }

    
}
