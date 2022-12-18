using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    public ScoreManager scoreManager;
    public void Menu()
    {
        if(PlayerPrefs.GetInt("Score") <= scoreManager.score)
        {
            PlayerPrefs.SetInt("Score", scoreManager.score);
        }
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(0);
    }
}
