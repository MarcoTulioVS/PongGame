using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPaddleController : MonoBehaviour
{
    //[SerializeField]
    //private Rigidbody2D rb;

    public Vector2 limits = new Vector2(-4.5f, 4.5f);

    public float speed;

    public GameObject ball;

    void Start()
    {
        
    }

    
    void Update()
    {
        if(ball != null)
        {
            float targetY = Mathf.Clamp(ball.transform.position.y,limits.x,limits.y);
            Vector2 targetPosition = new Vector2(transform.position.x, targetY);
            transform.position = Vector2.MoveTowards(transform.position,targetPosition, Time.deltaTime * speed);
        }
    }
}
