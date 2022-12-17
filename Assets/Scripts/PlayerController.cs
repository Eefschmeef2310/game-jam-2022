using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 2f;
    public Rigidbody2D rb;
    Vector2 movementDirection;
    void Update()
    {
        movementDirection = Vector3.ClampMagnitude(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")),1);
    }
    void FixedUpdate()
    {
        rb.velocity = movementDirection * movementSpeed;
    }
}
