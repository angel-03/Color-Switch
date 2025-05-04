using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int starCount = 0;
    public GameObject player, gameOver;
    public GameObject[] obst;
    public AudioSource collectSound;
    public TextMeshProUGUI highScoreText, scoreText;
    public bool spawnColor, spawnCircle;
     public Transform ccStartPos, circleStartPos;

    public float startingYPos = 0f, circleOffset = 15f, ccOffset = 5f;
  
    void Start()
    {
        SpawnColorChanger();
        SpawnCircle();
        ShowScore();
    }

    void Update()
    {
        if(spawnColor)
        {
            SpawnColorChanger();
        }
        if(spawnCircle)
        {
            SpawnCircle();
        }
    }

    public void SpawnColorChanger()
    {
        ccStartPos.position = new Vector3(0, ccStartPos.position.y + ccOffset, 0);
        Instantiate(obst[0], ccStartPos.position, ccStartPos.rotation);
        spawnColor = false;
    }

    public void SpawnCircle()
    {
        int obstInt = Random.Range(1,4);
        circleStartPos.position = new Vector3(0, circleStartPos.position.y + circleOffset, 0);
        Instantiate(obst[obstInt], circleStartPos.position, circleStartPos.rotation);
        spawnCircle = false;
    }

    public void GameOver()
    {
        player.GetComponent<SpriteRenderer>().enabled = false;
        player.transform.GetChild(0).gameObject.SetActive(true);
        Invoke("CallGOPanel", 1.5f);
        //SceneManager.LoadScene("GameScene");
    }

    public void CallGOPanel()
    {
        Time.timeScale = 0;
        gameOver.SetActive(true);
    }

    public void UpdateScore()
    {
        starCount++;
        CheckHighScore();
    }

    void CheckHighScore()
    {
        if(starCount > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", starCount);
        }
        ShowScore();
    }

    void ShowScore()
    {
        scoreText.text = "Score: \n" + starCount;
        highScoreText.text = "HighScore: " + PlayerPrefs.GetInt("HighScore", 0);
    }

    public void PlayCollectSound()
    {
        collectSound.Play();
    }
}
