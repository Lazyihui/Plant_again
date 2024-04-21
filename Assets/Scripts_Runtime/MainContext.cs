public class MainContext {

    public UIContext uiContext;

    public AssetsContext assetsContext;

    public MainContext() {

        uiContext = new UIContext();
        assetsContext = new AssetsContext();
    }


}