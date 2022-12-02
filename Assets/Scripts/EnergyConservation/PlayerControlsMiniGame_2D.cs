using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlsMiniGame_2D : MonoBehaviour
{
    public float moveSpeed_2D;
    public float jumpForce_2D;
    private Rigidbody2D rb_2D;
    public Transform ceilingCheck_2D;
    public Transform groundCheck_2D;
    public LayerMask groundObject_2D;
    public float checkRadius_2D;

    private bool facingRight_2D = true;
    private float moveDirection_2D;
    private bool isJumping_2D = false;
    private bool isGrounded_2D;

    private void Awake()
    {
        rb_2D = GetComponent<Rigidbody2D>();

    }
    void Update()
    {
        Inputs();
        Animate();

        // get inputs

    }
    private void FixedUpdate()
    {
        // check if grounded
        isGrounded_2D = Physics2D.OverlapCircle(groundCheck_2D.position, checkRadius_2D, groundObject_2D);

        Move();

    }
    private void Move() {
        rb_2D.velocity = new Vector2(moveDirection_2D * moveSpeed_2D, rb_2D.velocity.y);
        if (isJumping_2D)
        {
            rb_2D.AddForce(new Vector2(0f, jumpForce_2D));

        }
        isJumping_2D = false;

    }
    private void Animate()
    {
        if (moveDirection_2D > 0 && !facingRight_2D)
        {
            FlipCharacter();
        }
        else if (moveDirection_2D < 0 && facingRight_2D)
        {
            FlipCharacter();
        }
    }
    private void Inputs()
    {
        moveDirection_2D = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump") && isGrounded_2D)
        {
            isJumping_2D = true;
        }

    }    
    private void FlipCharacter()
    {
        facingRight_2D = !facingRight_2D;
        transform.Rotate(0f, 180f, 0f);
    }

}
