using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeagullController : MonoBehaviour
{
    public float speed = 4f;
    Vector3 endPos;
    private bool isTriggered = false;
    private Transform playerTransform;
    public Animator animator;

    GameObject sea;

    public float windup = 0.7f;
    public GameObject warningPrefab;
    private GameObject warningObject;

    // Start is called before the first frame update
    void Start()
    {
        sea = GameObject.FindGameObjectWithTag("Sea");
        transform.position = new Vector3(Camera.main.orthographicSize * Camera.main.aspect + 1, sea.transform.position.y + 2.5f);
        endPos = new Vector3(-transform.position.x, transform.position.y);

        playerTransform = FindObjectOfType<PlayerController>().gameObject.transform;
    }

    // Update is called once per frame
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

        if (!isTriggered)
        {
            // Not triggered yet. Check if we should be triggered.
            if (Vector2.Distance(new Vector2(transform.position.x, 0), new Vector2(playerTransform.position.x, 0)) <= 6f)
            {
                // Trigger
                isTriggered = true;

                animator.SetTrigger("Dive");
                Debug.Log("Trigger");

                // Spawn warning
                // warningObject = Instantiate(warningPrefab, new Vector3(transform.position.x, transform.position.y), Quaternion.identity, transform);
            }
        }
        else
        {
            // Triggered. Kill self when done
        }
    }
}
