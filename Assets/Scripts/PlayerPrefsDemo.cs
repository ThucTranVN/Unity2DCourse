using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerPrefsDemo : MonoBehaviour
{
    private const string goldKey= "GoldAmount";
    private int goldValue = 0;
    public TextMeshProUGUI goldText;

    void Start()
    {
        LoadGold();
    }

    private void LoadGold()
    {
        if (PlayerPrefs.HasKey(goldKey))
        {
            goldValue = PlayerPrefs.GetInt(goldKey);
            goldText.text = "Gold: " + goldValue;
            Debug.Log("Current Gold is: " + goldValue);
        }
    }

    private void SaveGold()
    {
        PlayerPrefs.SetInt(goldKey, goldValue);
    }

    public void UpdateGoldAmount()
    {
        goldValue++;
        goldText.text = "Gold: " + goldValue;
    }

    private void OnApplicationQuit()
    {
        SaveGold();
    }

}
