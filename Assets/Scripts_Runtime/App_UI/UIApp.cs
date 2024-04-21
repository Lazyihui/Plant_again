using System;
using System.Collections.Generic;
using UnityEngine;

public static class UIApp {


    public static void Panel_Login_Open(UIContext ctx) {
        Panel_Login panel = ctx.panel_Login;

        if (panel == null) {

            bool has = ctx.assetsContext.Entity_TryGetPrefab("Panel_Login", out GameObject Prefab);
            if (!has) {
                Debug.Log("Panel_Login is null");
                return;
            }
            panel = GameObject.Instantiate(Prefab, ctx.canvas.transform).GetComponent<Panel_Login>();
            panel.Ctor();
            panel.OnStartClickHandle = () => {

            };
            ctx.panel_Login = panel;
        }
        ctx.panel_Login.Show();
    }
}