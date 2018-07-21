using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    Rigidbody2D rb;
    public float movementSpeed ;

    float movement = 0f;

	void Start () {
        rb = GetComponent<Rigidbody2D>();
        movementSpeed = 10f;

    }
	
	// Update is called once per frame
	void Update () {
        movement = Input.GetAxis("Horizontal")*movementSpeed;
	}

    private void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = movement;
        rb.velocity = velocity;
    }
}
