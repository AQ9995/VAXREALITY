using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MenuManager
{
    public static bool IsInitalised { get; private set; }
    public static GameObject mainMenu, idMenu, weatherMenu, accountMenu;
    public static GameObject flower1, flower2, flower3, flower4, flower5, flower6;
    public static void Init()
    {
        GameObject canvas = GameObject.Find("HandMenuCanvas");
        mainMenu = canvas.transform.Find("MainMenu").gameObject;
        idMenu = canvas.transform.Find("IDMenu").gameObject;
        weatherMenu = canvas.transform.Find("WeatherMenu").gameObject;
        accountMenu = canvas.transform.Find("AcountMenu").gameObject;


        IsInitalised = true;
    }

    public static void OpenMenu(Menu menu, GameObject callingMenu)
    {

        if (!IsInitalised)
            Init();

        switch (menu)
        {
            case Menu.MAIN_MENU:
                mainMenu.SetActive(true);
                break;
            case Menu.ID:
                idMenu.SetActive(true);
                break;
            case Menu.WEATHER:
                weatherMenu.SetActive(true);
                break;
            case Menu.ACCOUNT:
                accountMenu.SetActive(true);
                break;

        }

        callingMenu.SetActive(false);
    }

    //public static void Flowers()
    //{
    //    GameObject gameObject = GameObject.Find("flowers");
    //    flower1 = gameObject.transform.Find("Flower1").gameObject;
    //    flower1 = gameObject.transform.Find("Flower2").gameObject;
    //    flower1 = gameObject.transform.Find("Flower3").gameObject;
    //    flower1 = gameObject.transform.Find("Flower4").gameObject;
    //    flower1 = gameObject.transform.Find("Flower5").gameObject;
    //    flower1 = gameObject.transform.Find("Flower6").gameObject;
    //}

    //public static void OpenFlower(Menu menu, GameObject callingFlower)
    //{

    //    if (!IsInitalised)
    //        Flowers();

    //    switch (menu)
    //    {
    //        case Menu.FLOWER1:
    //            flower1.SetActive(true);
    //            break;
    //        case Menu.FLOWER2:
    //            flower2.SetActive(true);
    //            break;
    //        case Menu.FLOWER3:
    //            flower3.SetActive(true);
    //            break;
    //        case Menu.FLOWER4:
    //            flower4.SetActive(true);
    //            break;
    //        case Menu.FLOWER5:
    //            flower5.SetActive(true);
    //            break;
    //        case Menu.FLOWER6:
    //            flower6.SetActive(true);
    //            break;

    //    }

    //    callingFlower.SetActive(false);
    //}
}
