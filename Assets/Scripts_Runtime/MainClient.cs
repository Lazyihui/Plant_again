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

        // ==== Init ====

        // ==== Enter ====


        Debug.Log("Hello World");
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
