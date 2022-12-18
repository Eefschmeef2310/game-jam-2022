using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void startGame()
    {   
        GameObject.Find("Game Manager").GetComponent<ActivateScripts>().enabled = true;
        GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>().enabled = true;
        SceneManager.UnloadSceneAsync(0);
    }
}
