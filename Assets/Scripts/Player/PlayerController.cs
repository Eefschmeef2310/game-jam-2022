using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject sea;
    public float maxSpeed = 2f;

    public float acceleration = 50f;
    public float friction = 1f;

    private Vector2 movementDirection;
    private Vector2 inputDirection;

    void Update()
    {
        // Input direction will always be a maximum value
        inputDirection = Vector3.ClampMagnitude(new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")), 1);

        // We control actual direction from here
        if (inputDirection.Equals(Vector2.zero))
        {
            // Not moving; slow down to 0
            movementDirection = Vector2.Lerp(movementDirection, Vector2.zero, friction * Time.deltaTime);
        }
        else
        {
            // Moving; speed up to input direction
            movementDirection = Vector2.Lerp(movementDirection, inputDirection, acceleration * Time.deltaTime);
        }
        
    }
    void FixedUpdate()
    {
        rb.velocity = movementDirection * maxSpeed;
    }

}
