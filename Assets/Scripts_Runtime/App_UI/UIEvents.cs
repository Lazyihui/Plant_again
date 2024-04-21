using System;

public class UIEvents {

    public Action Login_StartGameHanedle;
    public void Login_StartGame() {
        if (Login_StartGameHanedle != null) {
            Login_StartGameHanedle.Invoke();
        }
    }
}