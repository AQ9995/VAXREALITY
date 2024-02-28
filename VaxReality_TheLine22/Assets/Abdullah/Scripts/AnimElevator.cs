using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class AnimElevator : MonoBehaviour
{
    public Animator anim;
    public int currentFloor = 0;

    public GameObject xr;
    public GameObject image;


    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    //Elevator Up Methods

    public void GroundUpToFirstFloor()
    {
        if (currentFloor == 0)
        {
            image.SetActive(true);
            anim.SetTrigger("0up1");
            currentFloor = 1;
        }


    }
    public void GroundUpToSecondFloor()
    {
        if ( currentFloor == 0)
        {
            anim.SetTrigger("0up2");
            currentFloor = 2;
        }
    }

    public void FirstUpToSecondFloor()
    {
        if (currentFloor == 1)
        {
            anim.SetTrigger("1up2");
            currentFloor = 2;
        }
    }

    //Elevator Down Methods
    public void FirstDownToGroundFloor()
    {
        if (currentFloor == 1)
        {
            anim.SetTrigger("1down0");
            currentFloor = 0;
        }
    }

    public void SecondDownToFirstFloor()
    {
        if (currentFloor == 2)
        {
            anim.SetTrigger("2down1");
            currentFloor = 1;
        }
    }

    public void SecondDownToGroundFloor()
    {
        if (currentFloor == 2)
        {
            anim.SetTrigger("2down0");
            currentFloor = 0;
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == xr)
        {
            xr.transform.parent = transform;
        }

       
    }

    private void OnTriggerExit(Collider other)
    {
        xr.transform.parent = null;
    }
}
