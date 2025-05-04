using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public Color color0, color1, color2, color3, currentColor;
    public GameObject player;
    public Player playerScript;
    private SpriteRenderer ren;
    private float rotateSpeed = -30f;

    void Awake()
    {
        player = GameObject.FindWithTag("Player");  
        playerScript = player.GetComponent<Player>();  
    }
    void Start()
    {
        ren = player.gameObject.GetComponent<SpriteRenderer>();
        SetPlayerColor();
    }

   
    void Update()
    {
        transform.Rotate(0f, 0f, rotateSpeed * Time.deltaTime);
    }

    public void SetPlayerColor()
    {
        int colorInt = Random.Range(0, 4);

        switch(colorInt)
        {
            case 0:
                currentColor = color0;            
                playerScript.playerColor = "Blue";
                break;
            case 1:
                currentColor = color1;            
                playerScript.playerColor = "Yellow";            
                break;
            case 2:
                currentColor = color2;            
                playerScript.playerColor = "Purple";
                break;
            case 3:
                currentColor = color3;            
                playerScript.playerColor = "Pink";
                break;
        }
        ren.color = currentColor;
    }
}
