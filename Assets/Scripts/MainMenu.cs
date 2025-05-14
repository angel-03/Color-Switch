using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public TextMeshProUGUI highScoreText;
    public AudioSource buttonSound;

    void Start()
    {
        if(highScoreText != null)
            highScoreText.text = "HighScore: " +  + PlayerPrefs.GetInt("HighScore", 0);
    }

    public void OnClickStartButton()
    {
        SceneManager.LoadScene("GameScene");
    }
    
    public void OnClickRetryButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("GameScene");
    }

    public void OnClickQuitButton()
    {
        Application.Quit();
    }

    public void PlayButtonSound()
    {
        buttonSound.Play();
    }
}
