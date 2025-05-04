using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuGraphics : MonoBehaviour
{
    public float rotateSpeed = 0f;

    void Start ()
    {
        
    }

    void Update()
    {
        transform.Rotate(0f, 0f, rotateSpeed * Time.deltaTime);
    }
}
