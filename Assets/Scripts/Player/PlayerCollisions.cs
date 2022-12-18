using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    public PlayerController controller;
    public ScoreManager scoreManager;
    public LifeManager lifeManager;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Trash")
        {
            col.GetComponent<PlaySound>().playSound();
            Destroy(col.gameObject);
            scoreManager.addScore();
        }
        if (col.tag == "Enemy" || col.tag == "EnemyAir")
        {
            col.GetComponent<PlaySound>().playSound();
            Destroy(col.gameObject);
            lifeManager.minusLife();
        }
    }
}
