using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryPanel : MonoBehaviour
{
    public void OnClickedMenuButton()
    {
        if(GameManager.HasInstance)
        {
            GameManager.Instance.RestarGame();
        }
    }

    public void OnClickedExitButton()
    {
        if (GameManager.HasInstance)
        {
            GameManager.Instance.EndGame();
        }
    }
}
