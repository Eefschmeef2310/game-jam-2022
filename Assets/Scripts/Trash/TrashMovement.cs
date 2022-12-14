using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashMovement : MonoBehaviour
{
    public float speed = 3f;
    public List<Sprite> spriteList;
    public SpriteRenderer spriteRenderer;
    Vector3 endPos;

    private void Start()
    {
        spriteRenderer.sprite = spriteList[Random.Range(0, spriteList.Count)];
        endPos = new Vector3(-transform.position.x - 2f, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, endPos) >= 0.1f)
        {
            transform.position = Vector3.MoveTowards(transform.position, endPos, speed * Time.deltaTime);
        }
        else
        {
            Destroy(gameObject);
        }
    }   
}
