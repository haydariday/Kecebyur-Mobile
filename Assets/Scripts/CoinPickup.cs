using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CoinPickup : MonoBehaviour
{
    [SerializeField] AudioClip pickUp;
    [SerializeField] int pointsForCoins;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<GameSession>().AddToScore(pointsForCoins);
        SoundManager.instance.PlaySingle(pickUp);
        Destroy(gameObject);
    }
}
