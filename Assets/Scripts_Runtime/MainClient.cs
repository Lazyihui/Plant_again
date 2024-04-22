using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainClient : MonoBehaviour {
    MainContext ctx;

    void Start() {
        // === Instantiation ====
        ctx = new MainContext();

        // ==== Injection ====

        // ==== Load ====
        AssetsCore.Load(ctx.assetsContext);
        // ==== Binding ====
        Binding();

        // ==== Init ====

        // ==== Enter ====
        UIApp.Panel_Login_Open(ctx.uiContext);



        Debug.Log("Hello World");
    }


    void Binding() {

        var uiContext = ctx.uiContext.uiEvents;

        uiContext.Login_StartGameHanedle = () => {

            Debug.Log("hhh");
        };

    }

    void Update() {

    }

    void OnApplicationQuit() {
        TearDown();
    }

    void OnDestroy() {
        TearDown();
    }

    void TearDown() {
        AssetsCore.ReleaseAll(ctx.assetsContext);
    }
}
