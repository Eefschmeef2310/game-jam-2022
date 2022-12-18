using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkController : MonoBehaviour
{
    public float windup = 1f;
    public GameObject warningPrefab;
    private GameObject warningObject;

    public GameObject hitboxPrefab;
    private GameObject hitboxObject;

    private float lifetimer = 0.8f;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        // Go to player coords
        Vector3 playerPos = FindObjectOfType<PlayerController>().transform.position;
        transform.position = new Vector3(playerPos.x, playerPos.y);

        // Spawn warning
        warningObject = Instantiate(warningPrefab, transform.position, Quaternion.identity, transform);
    }

    // Update is called once per frame
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
                // Attack
                Destroy(warningObject);
                hitboxObject = Instantiate(hitboxPrefab, transform.position, Quaternion.identity, transform);
                animator.SetTrigger("Bite");
            }
            else if (hitboxObject != null && lifetimer < 0.7f)
            {
                Destroy(hitboxObject);
            }

            lifetimer -= Time.deltaTime;
            if (lifetimer <= 0f)
            {
                Destroy(gameObject);
            }
        }
    }
}
