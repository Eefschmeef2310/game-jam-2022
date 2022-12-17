using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeManager : MonoBehaviour
{
    public int lives = 3;
    public List<Image> lifeImages;
    public GameObject GameOver;
    public void minusLife()
    {
        lives--;
        updateImages();
        if(lives <= 0)
        {
            gameOver();
        }
    }
    public void updateImages()
    {
        switch(lives)
        {
            case 3:
                foreach(Image image in lifeImages)
                {
                    image.enabled = true;
                }
                break;
            case 2:
                lifeImages[2].enabled = false;
                lifeImages[1].enabled = true;
                lifeImages[0].enabled = true;
                break;
            case 1:
                lifeImages[1].enabled = false;
                lifeImages[0].enabled = true;
                break;
            case 0:
                lifeImages[0].enabled = false;
                break;
        }
    }
    public void gameOver()
    {
        Time.timeScale = 0f;
        GameOver.SetActive(true);
    }
}
