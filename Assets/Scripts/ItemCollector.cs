using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemCollector : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI numberOfCherries;
    private int cherries = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry"))
        {
            Destroy(collision.gameObject);
            cherries++;
            numberOfCherries.SetText(cherries.ToString());
            Debug.Log(cherries);
        }
    }
}
