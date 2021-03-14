using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartLevelX : MonoBehaviour
{
    public Scene currentScene;
    public void StartEndlessRunner()
    {
        SceneManager.LoadScene("EndlessRunner");
    }
    public void ResetLevel()
    {
        currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.buildIndex);
    }
    public void StartLevel(int level)
    {
        SceneManager.LoadScene(level+3);
    }
}
