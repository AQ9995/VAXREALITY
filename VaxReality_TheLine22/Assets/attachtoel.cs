using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attachtoel : MonoBehaviour
{
    [SerializeField] Transform el;
   

    // Update is called once per frame
    void Start()
    {
        transform.SetParent(el.transform);   
    }
}
