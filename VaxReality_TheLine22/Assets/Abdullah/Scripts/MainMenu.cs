using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
   public void OnClick_ID()
    {
        MenuManager.OpenMenu(Menu.ID, gameObject);
    }

    
    public void OnClick_Weather()
    {
        MenuManager.OpenMenu(Menu.WEATHER, gameObject);
    }

    public void OnClick_Account()
    {
        MenuManager.OpenMenu(Menu.ACCOUNT, gameObject);
    }

}
