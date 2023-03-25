using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GamePanel : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI numberOfCherries;

    private void OnEnable()
    {
        ItemCollector.collectCherryDelegate += OnPlayerCollect;
    }

    private void OnDisable()
    {
        ItemCollector.collectCherryDelegate -= OnPlayerCollect;
    }

    private void OnPlayerCollect(int value)
    {
        numberOfCherries.SetText(value.ToString());
    }
}
