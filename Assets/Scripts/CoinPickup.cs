using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CoinPickup : MonoBehaviour
{
    [SerializeField] AudioClip pickUp;
    [SerializeField] int pointsForCoins;
    [SerializeField] AudioClip hpUp;
    GameSession game;

    private void Start()
    {
        game = FindObjectOfType<GameSession>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       game.AddToScore(pointsForCoins);
        if (game.score % 10 == 0)
            SoundManager.instance.PlaySingle(hpUp);
        else
            SoundManager.instance.PlaySingle(pickUp);
        Destroy(gameObject);
    }
}
