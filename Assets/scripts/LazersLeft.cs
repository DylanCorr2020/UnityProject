using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazersLeft : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField]
    float moveLeftSpeed;

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
        
    }

    private void FixedUpdate()
    {
        rb.velocity = Vector2.right * moveLeftSpeed;
       
    }


   
}
