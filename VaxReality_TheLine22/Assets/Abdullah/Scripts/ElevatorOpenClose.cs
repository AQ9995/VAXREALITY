using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorOpenClose : MonoBehaviour
{

    public Animator animLeft;
    public Animator animRight;
    public GameObject xr;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject == xr)
        {
            animLeft.SetTrigger("open");
            animRight.SetTrigger("open");
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == xr)
        {
            animLeft.SetTrigger("close");
            animRight.SetTrigger("close");
        }
    }
}
