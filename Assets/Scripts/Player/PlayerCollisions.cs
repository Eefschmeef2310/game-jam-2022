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
            Destroy(col.gameObject);
            scoreManager.addScore();
        }
        if (col.tag == "Enemy" || col.tag == "EnemyAir")
        {
            Destroy(col.gameObject);
            lifeManager.minusLife();
        }
    }
}
