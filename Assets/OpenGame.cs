using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenGame : MonoBehaviour
{
    public GameObject menu;
    public Camera menuCamera;
    public void openGame()
    {
        menu.SetActive(false);
        Destroy(GameObject.Find("EventSystem"));
        SceneManager.LoadSceneAsync(1, LoadSceneMode.Additive);
    }
}
