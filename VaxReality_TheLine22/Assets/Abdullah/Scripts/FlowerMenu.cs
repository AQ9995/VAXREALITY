using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerMenu : MonoBehaviour
{
    public void OnClick_Flower1()
    {
        MenuManager.OpenMenu(Menu.FLOWER1, gameObject);
    }

    public void OnClick_Flower2()
    {
        MenuManager.OpenMenu(Menu.FLOWER2, gameObject);
    }
    public void OnClick_Flower3()
    {
        MenuManager.OpenMenu(Menu.FLOWER3, gameObject);
    }

    public void OnClick_Flower4()
    {
        MenuManager.OpenMenu(Menu.FLOWER4, gameObject);
    }
    public void OnClick_Flower5()
    {
        MenuManager.OpenMenu(Menu.FLOWER5, gameObject);
    }

    public void OnClick_Flower6()
    {
        MenuManager.OpenMenu(Menu.FLOWER6, gameObject);
    }
}
