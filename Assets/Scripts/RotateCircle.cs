using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCircle : MonoBehaviour
{
    public float rotateSpeed = 0f;
    public bool rotNeg;

    void Start ()
    {
        ChangeSpeed();
    }

    void Update()
    {
        if(rotNeg)
           transform.Rotate(0f, 0f, rotateSpeed * -1f * Time.deltaTime);
        else 
            transform.Rotate(0f, 0f, rotateSpeed * Time.deltaTime);
    }

    void ChangeSpeed()
    {
        rotateSpeed = Random.Range(50f, 151f);
    }
}
