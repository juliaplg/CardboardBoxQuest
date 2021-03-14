using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void PlayMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void PlayLevel()
    {
        SceneManager.LoadScene("LevelSelection");
    }
    public void PlaySkins()
    {
        SceneManager.LoadScene("Skins");
    }
    public void PlayCredits()
    {
        SceneManager.LoadScene("Credits");
    }
    public void StorePlayerPrefs()
    {
        PlayerPrefs.SetFloat("rectX", GameObject.Find("Icons").GetComponent<ScrollBG>().rectX);
    }
}
