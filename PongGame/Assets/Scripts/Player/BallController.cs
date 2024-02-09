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
}
