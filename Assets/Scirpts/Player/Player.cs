using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;

    [Header("Movement")]
    [SerializeField] public float movingSpeed;
    [SerializeField] public float jumpForce;

    [Header("Collision info")]
    [SerializeField] private float groundCheckDistnace;
    [SerializeField] private LayerMask whatIsGround;
    private bool isGround;
    private float xInput;

    void Init()
    {

        rb = GetComponent<Rigidbody2D>();
        anim = GetComponentInChildren<Animator>();
    }
    // Start is called before the first frame update

    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {

        HandleColision();
        HandleInput();
        HandleAnimation();
        HandleMove();

    }

    private void HandleInput()
    {
        xInput = Input.GetAxisRaw("Horizontal");
        if (Input.GetKeyDown(KeyCode.K) && isGround)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }

    private void HandleColision()
    {
        isGround = Physics2D.Raycast(transform.position, Vector2.down, groundCheckDistnace, whatIsGround);
    }

    private void HandleAnimation()
    {
        anim.SetFloat("xVelocity", rb.velocity.x);
    }

    private void HandleMove()
    {
        rb.velocity = new Vector2(xInput * movingSpeed, rb.velocity.y);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.position, new Vector2(transform.position.x, transform.position.y - groundCheckDistnace));
    }
}
