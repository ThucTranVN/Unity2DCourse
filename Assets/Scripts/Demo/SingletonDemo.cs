using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonDemo : MonoBehaviour
{
    public static SingletonDemo Instance;

    private int playerLives = 3;
    public int PlayerLives => playerLives;

    private void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
    }

    public void UpdatePlayerLives(int amount)
    {
        playerLives -= amount;
    }
}
