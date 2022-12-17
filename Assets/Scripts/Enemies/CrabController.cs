using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrabController : MonoBehaviour
{
    public float speed = 20f;
    Vector3 endPos;

    public float windup = 1f;
    public GameObject warningPrefab;
    private GameObject warningObject;

    void Start()
    {
        Vector3 position = Vector3.zero;
        switch (Random.Range(0, 2)) //randomly pick a side, then spawn a cherry at a random spot along that axis
        {
            case 0: //left
                position = new Vector3(-Camera.main.orthographicSize * Camera.main.aspect - 1, Random.Range(-(Camera.main.orthographicSize * Camera.main.aspect) / 2, (Camera.main.orthographicSize * Camera.main.aspect) / 2));
                break;
            case 1: //right
                position = new Vector3(Camera.main.orthographicSize * Camera.main.aspect + 1, Random.Range(-(Camera.main.orthographicSize * Camera.main.aspect) / 2, (Camera.main.orthographicSize * Camera.main.aspect) / 2));
                break;
        }
        transform.position = position;
        endPos = new Vector3(-position.x, position.y);

        // Spawn warning
        warningObject = Instantiate(warningPrefab, new Vector3(transform.position.x - (Mathf.Sign(transform.position.x) * 2), transform.position.y), Quaternion.identity, transform);

    }
    void Update()
    {
        if (windup > 0f)
        {
            windup -= Time.deltaTime;
        }
        else
        {
            if (warningObject != null)
            {
                Destroy(warningObject);
            }

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
}
