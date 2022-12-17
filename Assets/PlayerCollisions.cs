using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Trash")
        {
            Debug.Log("Trash Touched");
        }
        if(col.tag == "Enemy")
        {
            Debug.Log("Enemy Touched");
        }
    }
}
