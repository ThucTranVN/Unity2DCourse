using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : BaseManager<GameManager>
{
    private int cherries = 0;
    public int Cherries => cherries;

    public void UpdateCherries(int v)
    {
        cherries = v;
    }

    public void StartGame()
    {
        ChangeScene("Level1");
    }

    public void PauseGame()
    {

    }

    public void EndGame()
    {
        Application.Quit();
    }

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
