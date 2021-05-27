using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpDouble : MonoBehaviour
{

    public Rigidbody2D rb;
    private Vector3 velocity = Vector3.zero;

    public float jumpForce;
    public bool isJumping;
    //public bool isHitting;

    void Start()
    {

    }

    /*void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Solides")
        {
            isHitting = true;
        }

        Debug.Log("Collisions avec " + collision.gameObject.name);
    }
    */

    void Update()
    {

        if (Input.GetButtonDown("Jump") /*&& isHitting == true*/) ;
        {
            isJumping = true;
        }

        if (isJumping == true)
        {
            rb.AddForce(new Vector2(0f, jumpForce));
            /*isJumping = false;*/
        }

    }
}
