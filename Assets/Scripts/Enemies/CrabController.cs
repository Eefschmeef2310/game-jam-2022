using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrabController : MonoBehaviour
{
    public float windup = 0.7f;
    public float speed = 20f;
    Vector3 endPos;
    GameObject sea;

    void Start()
    {
        sea = GameObject.FindGameObjectWithTag("Sea");

        Vector3 position = Vector3.zero;
        switch (Random.Range(0, 2)) //randomly pick a side, then spawn a crab at a random spot along that axis
        {
            case 0: //left
                position = new Vector3(-Camera.main.orthographicSize * Camera.main.aspect, Random.Range(-Camera.main.orthographicSize, sea.transform.position.y));
                break;
            case 1: //right
                position = new Vector3(Camera.main.orthographicSize * Camera.main.aspect, Random.Range(-Camera.main.orthographicSize, sea.transform.position.y));
                break;
        }
        transform.position = position;
        endPos = new Vector3(-position.x, position.y);
    }
    void Update()
    {
        if (transform.position.Equals(endPos))
        {
            Destroy(gameObject);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, endPos, speed * Time.deltaTime);
        }
    }
}
