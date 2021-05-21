using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Transform GroundedLeft;
    public Transform GroundedRight;

    public Rigidbody2D rb;
    private Vector3 velocity = Vector3.zero;

    public float jumpForce;
    public bool isJumping;
    public bool isGrounded;

    void Update()
    {
        isGrounded = Physics2D.OverlapArea(GroundedLeft.position, GroundedRight.position);

        if(Input.GetButtonDown("Jump") && isGrounded == true)
        {
            isJumping = true;
        }
    }

    public float moveSpeed;

    void FixedUpdate()
    {
        float horizontalMovement = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        MovePlayer(horizontalMovement);
    }

    void MovePlayer(float _horizontalMovement)
    {
        Vector3 targetVelocity = new Vector2(_horizontalMovement, rb.velocity.y);
        rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref velocity, .05f);

        if (isJumping == true)
        {
            rb.AddForce(new Vector2(0f, jumpForce));
        }
    }
}