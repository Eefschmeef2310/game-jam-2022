using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unpause : MonoBehaviour
{
    public GameObject pause;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            unpause();
        }
    }
    public void unpause()
    {
        pause.SetActive(false);
        Time.timeScale = 1.0f;
    }
}
