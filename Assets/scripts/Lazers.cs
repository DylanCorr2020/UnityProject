using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazers : MonoBehaviour
{
    //create rigid body for for lazer
    Rigidbody2D rb;


    //create the speed variable
    //make it show on script component in unity engine
    [SerializeField]
    float moveSpeed;


    //starts before unity game  begins 
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //if the it goes of the screen then destroy the game object
        if(transform.position.x < -10f)
        {
            Destroy(gameObject);
        }
        
    }


    //used for physics of moving the lazer
    private void FixedUpdate()
    {
        rb.velocity = Vector2.left * moveSpeed;
        IncreaseSpeed();

    }

    //if the score is equal to 5 then inscrease speed of the game object
    public void IncreaseSpeed()
    {
        if (GameManager.instance.score == 5)
        {
            moveSpeed = 1.8f;
        }
    }
}
