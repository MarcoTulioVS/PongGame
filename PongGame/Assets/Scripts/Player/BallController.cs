using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rb;

    private Vector2 startingVelocity = new Vector2(5f, 5f);

    public void ResetBall()
    {
        rb.velocity = startingVelocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            Vector2 newVelocity = rb.velocity;
            newVelocity.y = -newVelocity.y;
            rb.velocity = newVelocity;
        }

        if(collision.gameObject.tag=="Player" || collision.gameObject.tag == "Enemy")
        {
            rb.velocity = new Vector2(-rb.velocity.x, rb.velocity.y);
        }
    }
}
