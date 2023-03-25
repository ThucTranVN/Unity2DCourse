using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    public delegate void CollectCherry(int cherry); //Dinh nghia ham delegate 
    public static CollectCherry collectCherryDelegate; //Khai bao ham delegate
    private int cherries = 0;

    private void Start()
    {
        if (GameManager.HasInstance)
        {
            cherries = GameManager.Instance.Cherries;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry"))
        {
            if (AudioManager.HasInstance)
            {
                AudioManager.Instance.PlaySE(AUDIO.SE_COLLECT);
            }
            Destroy(collision.gameObject);
            cherries++;
            GameManager.Instance.UpdateCherries(cherries);
            collectCherryDelegate(cherries); //Broadcast event
        }
    }
}
