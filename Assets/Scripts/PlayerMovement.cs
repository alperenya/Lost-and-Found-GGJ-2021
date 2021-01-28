using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() // used for input
    {
        movement.x=Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate() // update default in 50 frame per sec for movement
    {
        rb.MovePosition(rb.position + movement * speed*Time.fixedDeltaTime);
    }
}
