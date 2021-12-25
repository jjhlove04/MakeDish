using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : Singleton<UIManager>
{
    [Header("책 펼치는 효과를 위한 변수")]
    public GameObject bookFront;
    public Image bookBack;
    public GameObject recipeBook;



    Sequence mySequnce;//TODO:  시퀀스로 책 여는 연출 만들기


    private void Start()
    {

        recipeBook.GetComponent<Button>().onClick.AddListener(() => OpenMenu());

    }

    public void OpenMenu()
    {
        //버튼이 가운데로 움직이고 커진다음 회전으로 책 넘기는 효과.
        mySequnce.Append(recipeBook.transform.DOMove(new Vector3(350, 200, 0), 0.5f));
        mySequnce.Append(recipeBook.transform.DOScale(new Vector3(8, 8, 0), 0.5f));
        mySequnce.Append(recipeBook.transform.DORotate(new Vector3(0, 90, 0), 0.8f).SetDelay(1f));
        
       
        


    }

    
    protected override void Awake() 
    {
        base.Awake();

        
        
    }

    
}
