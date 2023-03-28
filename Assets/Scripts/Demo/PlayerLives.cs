using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerLives : MonoBehaviour
{
    public TextMeshProUGUI playerLivesText;

    void Start()
    {
        if(SingletonDemo.Instance != null)
        {
            playerLivesText.text = "Player Lives: " + SingletonDemo.Instance.PlayerLives;
        }
        
    }

    public void AttackPlayer()
    {
        if (SingletonDemo.Instance != null)
        {
            SingletonDemo.Instance.UpdatePlayerLives(1);
        }
        playerLivesText.text = "Player Lives: " + SingletonDemo.Instance.PlayerLives;
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene("SingletonDemo2");
    }
}
