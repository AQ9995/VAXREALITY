using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeDoor : MonoBehaviour
{


    public Animator anim;
    int current = 0;


    public void OpenDoor()
    {
        if (current == 0)
        {
            anim.SetTrigger("open");
            current = 1;
        }
    }


    public void CloseDoor()
    {
        if (current == 1)
        {
            anim.SetTrigger("close");
            current = 0;
        }
    }
}
