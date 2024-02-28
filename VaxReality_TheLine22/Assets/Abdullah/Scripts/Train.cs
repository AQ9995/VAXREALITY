using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Train : MonoBehaviour
{
    public GameObject xr;
    public Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        xr.transform.parent = transform;
        StartCoroutine(TrainMove());
    }

   private void OnTriggerExit (Collider other)
    {
        xr.transform.parent = null;
    }


    IEnumerator TrainMove()
    {
        yield return new WaitForSeconds(3);
        anim.SetTrigger("close");
        yield return new WaitForSeconds(5);
        anim.SetTrigger("move");
        yield return new WaitForSeconds(7);
        anim.SetTrigger("open");
    }
}
