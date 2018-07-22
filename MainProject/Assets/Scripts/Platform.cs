using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour {

    // Use this for initialization
    public float jumpForce = 10f;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
            

            if ((rb != null)&(gameObject.tag == "Platform"))
            {
                Vector2 velocity = rb.velocity;
                velocity.y = jumpForce;
                rb.velocity = velocity;
            }
            if (gameObject.tag == "DangPlatform")
            {
                Vector2 velocity = rb.velocity;

                Player pl = collision.gameObject.GetComponent<Player>();
                pl.movementSpeed = 0f;
                velocity.y = 5f;
                rb.velocity = velocity;
                collision.collider.enabled = false;
                
                
            }
        }

    }
}
