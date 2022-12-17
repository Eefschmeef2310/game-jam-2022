using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuoyDepth : MonoBehaviour
{
    Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        playerTransform = FindObjectOfType<PlayerController>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTransform.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, playerTransform.position.z - 0.4f);
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, playerTransform.position.z + 0.4f);
        }
    }
}
