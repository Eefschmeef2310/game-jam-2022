using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashMovement : MonoBehaviour
{
    public float speed = 3f;
    public List<Sprite> spriteList;

    private void Start()
    {
        GetComponent<SpriteRenderer>().sprite = spriteList[Random.Range(0, spriteList.Count)];
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
