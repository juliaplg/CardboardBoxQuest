using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GM : MonoBehaviour
{
    public bool isCat = true;

    public float speed;
    public int highscore;
    public int levelScore;
    public int lives;
    public bool gameIsOver;

    public GameObject scoreGO, scoreGameOverGO, highscoreGO;
    public string score;

    public GameObject gameOverPanel;
    public GameObject controls;

    public GameObject livesGO;

    public GameObject playerGO;
    public SpriteRenderer playerSprite;
    public Sprite[] catSkins;
    public Sprite[] bunnySkins;
    public int skinIndex;

    private void Start()
    {
        skinIndex = PlayerPrefs.GetInt("skinIndex");
    }

    private void Update()
    {
        scoreGO.GetComponent<TextMeshProUGUI>().text = "Score: " + levelScore.ToString();
        scoreGameOverGO.GetComponent<TextMeshProUGUI>().text = "Score: " + levelScore.ToString();
        highscoreGO.GetComponent<TextMeshProUGUI>().text = "Highscore: " + PlayerPrefs.GetInt("highscore").ToString();
        livesGO.GetComponent<TextMeshProUGUI>().text = "Lives: " + lives.ToString();

        if (PlayerPrefs.GetInt("highscore") <= levelScore)
        {
            PlayerPrefs.SetInt("highscore", levelScore);
        }

        if (isCat)
        {
            playerSprite.sprite = catSkins[skinIndex];
        }
        else
        {
            playerSprite.sprite = bunnySkins[skinIndex];
        }
        if (lives <= 0)
        {
            GameOver();
        }
    }
    public void SwitchCatBunny()
    {
        if (isCat)
        {
            isCat = false;
        }
        else
        {
            isCat = true;
        }
    }
    public void GameOver()
    {
        playerGO.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        gameIsOver = true;
        gameOverPanel.SetActive(true);
        controls.SetActive(false);
    }
}
