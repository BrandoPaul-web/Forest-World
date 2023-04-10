using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 10f;
    // Start is called before the first frame update
    
    private Rigidbody2D rb;
    private SpriteRenderer sr; 
    private Animator Animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        Animator = GetComponent<Animator>();
    }

    // Update is called once per frame

    void Update()
    {
        Animator.SetBool("running", rb);
        rb.velocity = new Vector2(0, rb.velocity.y);
        if(Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(7, rb.velocity.y);
            sr.flipX = false;
        }
            
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-7, rb.velocity.y);
            sr.flipX = true;
        }
            
        if(Input.GetKeyUp(KeyCode.Space))
            rb.AddForce(transform.up * jumpForce);
    }
}