using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    public Rigidbody2D rb;
    public float movespeed;
    public bool moveright;
    public bool moveleft;
    public bool jump;
    public float jumpheight;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool onGround;
    public int treats;

    void FixedUpdate(){
        onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
	}

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();     
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)){
            rb.velocity = new Vector2(-movespeed, rb.velocity.y);  
		}
        if (Input.GetKey(KeyCode.RightArrow)){
            rb.velocity = new Vector2(movespeed, rb.velocity.y);  
		}
        if (Input.GetKey(KeyCode.Space)){
            rb.velocity = new Vector2(rb.velocity.x, jumpheight);  
		}
        if (jump){
            rb.velocity = new Vector2(rb.velocity.x, jumpheight);
            jump = false;
		} 
        if (moveright){
            rb.velocity = new Vector2(movespeed, rb.velocity.y);
		}
        if (moveleft){
            rb.velocity = new Vector2(-movespeed, rb.velocity.y);  
		}
        
    }
}
