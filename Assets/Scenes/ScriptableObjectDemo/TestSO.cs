using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TestSO : MonoBehaviour
{
    public TextMeshProUGUI health;
    public TextMeshProUGUI damage;
    public TextMeshProUGUI strength;
    public TextMeshProUGUI ability;
    public TextMeshProUGUI inteligence;

    void Start()
    {
        DataManager.Instance.Init();
        LoadData();
    }

    public void UpdatePlayerData(int amount)
    {
        var dataSO = DataManager.Instance.PlayerData;
        dataSO.playerData.Health += amount;
        dataSO.playerData.Damage += amount;
        dataSO.playerData.Strength += amount;
        dataSO.playerData.Ability += amount;
        dataSO.playerData.Inteligence += amount;
        DataManager.Instance.SavePlayerData();
        LoadData();
    }

    public void ChangeScence(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    private void LoadData()
    {
        var dataSO = DataManager.Instance.PlayerData;
        health.SetText($"Health {dataSO.playerData.Health}");
        damage.SetText($"Damage {dataSO.playerData.Damage}");
        strength.SetText($"Strength {dataSO.playerData.Strength}");
        ability.SetText($"Ability {dataSO.playerData.Ability}");
        inteligence.SetText($"Inteligence {dataSO.playerData.Inteligence}");
    }
}

