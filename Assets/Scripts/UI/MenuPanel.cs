using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPanel : MonoBehaviour
{
    [SerializeField]
    GameObject howToPlayBtn;

    [SerializeField]
    GameObject howToPlayImage;

    public void OnStartButtonClick()
    {
        if (UIManager.HasInstance)
        {
            UIManager.Instance.ActiveMenuPanel(false);
            UIManager.Instance.ActiveLoadingPanel(true);
        }

        if (AudioManager.HasInstance)
        {
            AudioManager.Instance.PlayBGM(AUDIO.BGM_BGM_02, 0.5f);
        }
    }

    public void OnSettingButtonClick()
    {
        if (UIManager.HasInstance)
        {
            UIManager.Instance.ActiveSettingPanel(true);
        }
    }

    public void OnHowToPlayButtonClick()
    {
        howToPlayImage.SetActive(true);
        howToPlayBtn.SetActive(false);
    }

    public void OnHowToPlayButtonImgClick()
    {
        howToPlayImage.SetActive(false);
        howToPlayBtn.SetActive(true);
    }
}
