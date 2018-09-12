using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    //public GameObject Playerr;
    
    Rigidbody2D rb;
    public float movementSpeed ;

    float movement = 0f;
    //Vector2 startpos = new Vector2(0,4);
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        movementSpeed = 10f;
        //Instantiate(this.gameObject, startpos, Quaternion.identity);
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
