using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;

    public float playerSpeed = 5;
    public float playerJump = 7;
    
    //private bool jump = false;
    private bool ground = false;
    private bool doubleJump = false;
    

    private void Start()
    {      

        rb = GetComponent<Rigidbody2D>();       

        
    }

    private void Update()
    {

        transform.position += new Vector3(1, 0, 0) * Time.deltaTime * playerSpeed;
        /* if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && ground)
        {

            jump = true;
                      
        } */

        if (rb.velocity.y == 0)
            ground = true;
        else
            ground = false;

        if (ground)
            doubleJump = true;

        if (ground && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Jump();
        }
        else if (doubleJump && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Jump();
            doubleJump = false;
        }
    }

  

   /*  private void FixedUpdate()
    {
        if(jump)
        {
            
                rb.AddForce(new Vector2(0f, playerJump), ForceMode2D.Impulse);
                jump = false;
                ground = false;
                           
        }
        
        
    } */

   /* private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            
            ground = true;
        }
    } */

    void Jump()
    {
        rb.AddForce(new Vector2(0f, playerJump), ForceMode2D.Impulse);
    }

}
