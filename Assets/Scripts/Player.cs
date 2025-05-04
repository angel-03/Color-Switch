using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool once;
    public Rigidbody2D rb;
     public GameManager gm;
    public float jumpForce = 5f;
    public string colorName, playerColor;

    void Start()
    {
        jumpForce = 0f;
        rb.gravityScale = 0;
    }
    
    void Update()
    {
        if(Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            if(!once)
            {
                rb.gravityScale = 1;
                jumpForce = 5f;
                once = true;
            }
            rb.velocity = Vector2.up * jumpForce;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "ColorChanger")
        {
            other.gameObject.GetComponent<ColorChanger>().SetPlayerColor();
            gm.PlayCollectSound();
            gm.UpdateScore();
            gm.spawnColor = true;
            Destroy(other.gameObject);
        }

        if(!(other.tag == "ColorChanger"))
        {
            colorName = other.tag.ToString();
            if(!(playerColor == colorName))
            {
                Debug.Log("GameOver");
                gm.GameOver();
            }
            else
            {
                gm.spawnCircle = true;
            }
        }
        
        if(other.tag == "GameOver")
        {
            gm.GameOver();
        }

    }
}
