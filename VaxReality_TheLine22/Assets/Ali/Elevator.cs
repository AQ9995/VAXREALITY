using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    [SerializeField]
    private Vector3[] Target;
    int Index = 0;
   [SerializeField] float Speed;
    bool IsTransformRequest;
    int prevfloor = 0;
    public AudioSource aud;
    public AudioClip clip;

    public void getfloore(int floornumber)
    {
        if (!IsTransformRequest)
        {
            Speed = floornumber > prevfloor ? Speed : 1;
            Index = floornumber;
            IsTransformRequest = true;
            prevfloor = floornumber;
        }
    }
    private void FixedUpdate()
    {
        if (IsTransformRequest)
        {
            transform.position = Vector3.MoveTowards(transform.position, Target[Index], Speed * Time.deltaTime);
            if (Vector3.Distance(transform.position, Target[Index]) < 0.1f)
            {
                transform.position = Target[Index];
                IsTransformRequest = false;
                aud.PlayOneShot(clip);

            }
        }
    }


}
