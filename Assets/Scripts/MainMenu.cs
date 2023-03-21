using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void OnStartButtonClick()
    {
        if (GameManager.HasInstance)
        {
            GameManager.Instance.StartGame();
        }
    }
}
