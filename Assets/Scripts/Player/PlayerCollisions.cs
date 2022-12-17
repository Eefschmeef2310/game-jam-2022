using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    public PlayerController controller;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (controller.inAir)
        {
            if (col.tag == "EnemyAir")
            {
                Debug.Log("Enemy Touched");
            }
        }
        else
        {
            if (col.tag == "Trash")
            {
                Debug.Log("Trash Touched");
            }
            if (col.tag == "Enemy" || col.tag == "EnemyAir")
            {
                Debug.Log("Enemy Touched");
            }
        }
    }
}
