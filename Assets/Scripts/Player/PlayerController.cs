using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator introAnimator;
    public Animator shadow;
    public GameObject sea;
    public ParticleSystem particles;
    public float maxSpeed = 2f;

    public float acceleration = 50f;
    public float friction = 1f;

    private Vector2 movementDirection;
    private Vector2 inputDirection;

    public bool inAir = false;
    private float airTimer = 0f;
    private float airTimerMax = 1.5f;
    
    GameObject wave;

    [SerializeField] private Animator animator;

    void Start()
    {
        introAnimator.enabled = false;
    }

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

        if(inputDirection.y >= 0) //going up
        {
            particles.transform.position = new Vector3(particles.transform.position.x, particles.transform.position.y, -0.65f);
        }
        else //going down
        {
            particles.transform.position = new Vector3(particles.transform.position.x, particles.transform.position.y, 0.65f);
        }

        // Rotations
        if (!inAir)
        {
            particles.Play();
            Quaternion targetRotation = Quaternion.Euler(0f, 0f, 10f);
            if (inputDirection.x > 0f) //Right
            {
                targetRotation = Quaternion.Euler(0f, 0f, 30f);
            }
            else if (inputDirection.x < 0f) //Left
            {
                targetRotation = Quaternion.Euler(0f, 0f, 5f);

            }
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, acceleration * 0.5f * Time.deltaTime);
        }



        // Clamp position
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -Camera.main.orthographicSize * Camera.main.aspect, Camera.main.orthographicSize * Camera.main.aspect),
                                         Mathf.Clamp(transform.position.y, -Camera.main.orthographicSize, sea.transform.position.y + 2.2f));


        // Jumping
        if (Input.GetKeyDown(KeyCode.Space) && !inAir && wave != null)
        {
            // Jump
            Destroy(wave);
            animator.SetTrigger("Jump");
            shadow.Play("Shadow");
            airTimer = airTimerMax;
            inAir = true;
        }

        if (inAir)
        {
            particles.Stop(true, ParticleSystemStopBehavior.StopEmitting);
            airTimer -= Time.deltaTime;
            if (airTimer <= 0f)
            {
                inAir = false;
            }
        }

        // Tilting
        animator.SetFloat("VelocityY", inputDirection.y);
        
    }
    void FixedUpdate()
    {
        rb.velocity = movementDirection * maxSpeed;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Wave")
        {
            wave = col.gameObject;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if(col.tag == "Wave")
        {
            wave = null;
        }
    }

}
