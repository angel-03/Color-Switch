using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    void Awake()
    {
        // Make sure this is the only instance of this GameObject
        if (FindObjectsOfType<MusicManager>().Length > 1)
        {
            Destroy(gameObject);
            return;
        }

        // Prevent the GameObject from being destroyed on scene load
        DontDestroyOnLoad(gameObject);
    }
}
