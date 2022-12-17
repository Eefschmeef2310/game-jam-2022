using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrabBehaviour : MonoBehaviour
{
    Vector3 startPos;
    void Start()
    {
        startPos = transform.position;
    }
    void Update()
    {
        if(transform.position != startPos)
        {
            transform.position = Vector3.MoveTowards(transform.position, Vector3.zero, 3);
        }
    }
}
