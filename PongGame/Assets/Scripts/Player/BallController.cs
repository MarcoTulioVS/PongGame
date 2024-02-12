using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rb;


    [SerializeField]
    private Vector2 startingVelocity = new Vector2(5f, 5f);

    public GameManager gameManager;

    public float speedUp;
    public void ResetBall()
    {
        transform.position = Vector3.zero;
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
            rb.velocity *= speedUp;
        }

        if (collision.gameObject.tag == "WallEnemy")
        {
            gameManager.ScorePlayer();
            ResetBall();
        }

        if (collision.gameObject.tag == "WallPlayer")
        {
            gameManager.ScoreEnemy();
            ResetBall();
        }
    }
}
