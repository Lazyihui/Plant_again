using System;
using UnityEngine;
using UnityEngine.UI;

public class Panel_Login : MonoBehaviour{
    [SerializeField] Button btn_Start;

    public Action OnStartClickHandle;
    public Panel_Login (){}

    public void Ctor(){

        btn_Start.onClick.AddListener(()=>{
            OnStartClickHandle.Invoke();
        });
    }

    public void Show(){
        gameObject.SetActive(true);
    }
    public void Close(){
        gameObject.SetActive(false);
    }


}