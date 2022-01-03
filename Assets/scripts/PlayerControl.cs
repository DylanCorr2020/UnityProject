using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    //create moveSpeed for player 
    public float moveSpeed;

    //create rigidbody for player 
    public Rigidbody2D rb;

    //ceate vector 2d moveDirection
    private Vector2 moveDirection;

    public GameObject dust;


    void Update()
    {
        ProcessInputs();
    }

    void FixedUpdate()
    {
        //Physics Calculations
        Move();
    }

    void ProcessInputs()
    {   

        //set varibles to keyboard controls 
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        //create new Vector2 movement for thesee two variables to move up and down 
        moveDirection = new Vector2(moveX, moveY);

        
    }

    void Move()
    {
        
     
    //add velocity to move the player in directions x and y
    rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }


    //if player touches Lazer tag then destroy itself 
    //and call the GameOver method in the gameOver Script 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Lazer")
        {
            Destroy(gameObject);

            Instantiate(dust, transform.position, Quaternion.identity);
           
            GameManager.instance.GameOver();
           
            
        }
    }

}
