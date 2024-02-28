using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flowers : MonoBehaviour
{
    
    public GameObject flower1, flower2, flower3, flower4, flower5, flower6;
    public GameObject text1,text2,text3,text4,text5,text6;

    public void OnClick_Flower1()
    {
        //objects
        flower1.gameObject.SetActive(true);
        flower2.gameObject.SetActive(false);
        flower3.gameObject.SetActive(false);
        flower4.gameObject.SetActive(false);
        flower5.gameObject.SetActive(false);
        flower6.gameObject.SetActive(false);

        //texts
        text1.gameObject.SetActive(true);
        text2.gameObject.SetActive(false);
        text3.gameObject.SetActive(false);
        text4.gameObject.SetActive(false);
        text5.gameObject.SetActive(false);
        text6.gameObject.SetActive(false);

    }

    public void OnClick_Flower2()
    {

        //objects
        flower1.gameObject.SetActive(false);
        flower2.gameObject.SetActive(true);
        flower3.gameObject.SetActive(false);
        flower4.gameObject.SetActive(false);
        flower5.gameObject.SetActive(false);
        flower6.gameObject.SetActive(false);

        //texts
        text1.gameObject.SetActive(false);
        text2.gameObject.SetActive(true);
        text3.gameObject.SetActive(false);
        text4.gameObject.SetActive(false);
        text5.gameObject.SetActive(false);
        text6.gameObject.SetActive(false);
    }
    public void OnClick_Flower3()
    {
        flower1.gameObject.SetActive(false);
        flower2.gameObject.SetActive(false);
        flower3.gameObject.SetActive(true);
        flower4.gameObject.SetActive(false);
        flower5.gameObject.SetActive(false);
        flower6.gameObject.SetActive(false);

        //texts
        text1.gameObject.SetActive(false);
        text2.gameObject.SetActive(false);
        text3.gameObject.SetActive(true);
        text4.gameObject.SetActive(false);
        text5.gameObject.SetActive(false);
        text6.gameObject.SetActive(false);
    }

    public void OnClick_Flower4()
    {

        //objects
        flower1.gameObject.SetActive(false);
        flower2.gameObject.SetActive(false);
        flower3.gameObject.SetActive(false);
        flower4.gameObject.SetActive(true);
        flower5.gameObject.SetActive(false);
        flower6.gameObject.SetActive(false);

        //texts
        text1.gameObject.SetActive(false);
        text2.gameObject.SetActive(false);
        text3.gameObject.SetActive(false);
        text4.gameObject.SetActive(true);
        text5.gameObject.SetActive(false);
        text6.gameObject.SetActive(false);
    }
    public void OnClick_Flower5()
    {

        //objects
        flower1.gameObject.SetActive(false);
        flower2.gameObject.SetActive(false);
        flower3.gameObject.SetActive(false);
        flower4.gameObject.SetActive(false);
        flower5.gameObject.SetActive(true);
        flower6.gameObject.SetActive(false);

        //texts
        text1.gameObject.SetActive(false);
        text2.gameObject.SetActive(false);
        text3.gameObject.SetActive(false);
        text4.gameObject.SetActive(false);
        text5.gameObject.SetActive(true);
        text6.gameObject.SetActive(false);
    }

    public void OnClick_Flower6()
    {

        //objects
        flower1.gameObject.SetActive(false);
        flower2.gameObject.SetActive(false);
        flower3.gameObject.SetActive(false);
        flower4.gameObject.SetActive(false);
        flower5.gameObject.SetActive(false);
        flower6.gameObject.SetActive(true);

        //texts
        text1.gameObject.SetActive(false);
        text2.gameObject.SetActive(false);
        text3.gameObject.SetActive(false);
        text4.gameObject.SetActive(false);
        text5.gameObject.SetActive(false);
        text6.gameObject.SetActive(true);
    }
}
