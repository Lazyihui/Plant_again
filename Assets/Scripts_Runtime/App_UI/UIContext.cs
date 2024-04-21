using UnityEngine;
using UnityEngine.UI;

public class UIContext {

    public Panel_Login panel_Login;
    
    public AssetsContext assetsContext;

    public Canvas canvas;
    public UIContext() {

        
    }

    public void Inject(AssetsContext assetsContext,Canvas canvas){
        this.assetsContext = assetsContext;
        this.canvas = canvas;
    }
}