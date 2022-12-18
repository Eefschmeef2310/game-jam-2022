using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckScore : MonoBehaviour
{
    public GameObject newScore;
    public ScoreManager scoreManager;
    void Start()
    {
        if(PlayerPrefs.GetInt("Score") < scoreManager.score)
        {
            newScore.SetActive(true);
        }
    }
}
