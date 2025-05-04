using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private float rotateSpeed = 30f;

    void Start ()
    {
        transform.rotation = new Quaternion(90f, 0f, 0f, 1);
    }
    
    void Update()
    {
        transform.Rotate(0f, 0f, rotateSpeed * Time.deltaTime);
    }
}
