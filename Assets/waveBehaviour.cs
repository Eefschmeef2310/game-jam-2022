using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waveBehaviour : MonoBehaviour
{
    public float speed = 5f;
    Vector3 endPos;

    private void Start()
    {
        endPos = new Vector3(-transform.position.x - 2f, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x != endPos.x)
        {
            transform.position = Vector3.MoveTowards(transform.position, endPos, speed * Time.deltaTime);
        }
        else
        {
            Destroy(gameObject);
        }
    }   
}
