using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Rotatecube : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 Rotateit;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Rotateit * Time.deltaTime);
    }
}
