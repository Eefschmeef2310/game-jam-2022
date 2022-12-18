using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseGame : MonoBehaviour
{
    public void closeGame()
    {
        Application.Quit();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
