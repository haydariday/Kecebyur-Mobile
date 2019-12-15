using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TampilkanScore : MonoBehaviour
{
    public static int skor = 0;
    [SerializeField] public Text Score;

    public void Start()
    {
        Score = GetComponent<Text>();
        Score.text = skor.ToString();
    }
    
}
