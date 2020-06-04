using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;

    public float playerSpeed = 5;
    public float playerJump = 5;
    //private float hDir;
    //private float vDir;

    private bool jump = false;
    private bool ground = false;

    private void Start()
    {      

        rb = GetComponent<Rigidbody2D>();       

        
    }

    private void Update()
    {

        transform.position += new Vector3(1, 0, 0) * Time.deltaTime * playerSpeed;
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && ground)
        {
            jump = true;
            
        }
    }

    private void FixedUpdate()
    {
        
        if (jump)
        {
            rb.AddForce(new Vector2(0f, playerJump), ForceMode2D.Impulse);
            jump = false;
            ground = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            ground = true;
        }
    }

}
