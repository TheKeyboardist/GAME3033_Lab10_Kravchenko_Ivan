using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuWidget : MenuWidget
{
   public void OpenStartMenu()
    {
        MenuController.EnableMenu("LoadMenu");
    }

    public void OpenOptionsMenu()
    {
        MenuController.EnableMenu("OptionsMenu");
    }

    public void QuitApplication()
    {
        Application.Quit();
    }
}
