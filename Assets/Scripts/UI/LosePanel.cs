using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LosePanel : MonoBehaviour
{

    public void OnClickedMenuButton()
    {
        if (GameManager.HasInstance)
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
