using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : BaseManager<UIManager>
{
    [SerializeField]
    private GameObject menuPanel;
    [SerializeField]
    private GameObject settingPanel;
    [SerializeField]
    private GameObject gamePanel;

    public void ActiveMenuPanel(bool active)
    {
        menuPanel.SetActive(active);
    }

    public void ActiveSettingPanel(bool active)
    {
        settingPanel.SetActive(active);
    }

    public void ActiveGamePanel(bool active)
    {
        gamePanel.SetActive(active);
    }
}
