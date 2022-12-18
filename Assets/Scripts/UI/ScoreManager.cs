using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI text;
    void Start()
    {
        text.enabled = true;
    }
    public void addScore()
    {
        score++;
        text.text = score.ToString();
    }
}
