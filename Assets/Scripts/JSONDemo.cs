using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class JSONDemo : MonoBehaviour
{
    public TextMeshProUGUI playerName;
    public TextMeshProUGUI playerLevel;
    public TextMeshProUGUI playerGold;
    public ListPlayer listPlayer;
    private string json;

    void Start()
    {
        PlayerData playerData = new PlayerData
        {
            Name = "Cat",
            Level = 1,
            Gold = 100
        };
        //json = JsonUtility.ToJson(playerData);
        json = JsonUtility.ToJson(listPlayer);
        Debug.Log(json);
    }

    public void LoadPlayerData()
    {
        string loadJSON = File.ReadAllText(Application.dataPath + "/Data/saveFile.json");
        if(loadJSON != null)
        {
            //PlayerData loadedPlayerData = JsonUtility.FromJson<PlayerData>(loadJSON);
            //playerName.text = "Player Name: " + loadedPlayerData.Name;
            //playerLevel.text = "Player Level: " + loadedPlayerData.Level;
            //playerGold.text = "Player Gold: " + loadedPlayerData.Gold;
            ListPlayer loadedPlayerData = JsonUtility.FromJson<ListPlayer>(loadJSON);
            playerName.text = "Player Name: " + loadedPlayerData.playerDatas[1].Name;
            playerLevel.text = "Player Level: " + loadedPlayerData.playerDatas[1].Level;
            playerGold.text = "Player Gold: " + loadedPlayerData.playerDatas[1].Gold;
        } 
    }

    public void SaveJsonFile()
    {
        File.WriteAllText(Application.dataPath + "/Data/saveFile.json", json);
    }

    public void UpdateData()
    {
        PlayerData updateData = new PlayerData
        {
            Name = "Dog",
            Level = 2,
            Gold = 1000
        };
        playerName.text = "Player Name: " + updateData.Name;
        playerLevel.text = "Player Level: " + updateData.Level;
        playerGold.text = "Player Gold: " + updateData.Gold;
        json = JsonUtility.ToJson(updateData);
        SaveJsonFile();
    }

}
