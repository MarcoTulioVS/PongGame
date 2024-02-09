using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform playerPaddle;
    public Transform enemyPaddle;

    public BallController ballController;
    void Start()
    {
        ResetGame();
    }

    
    void Update()
    {
        
    }

    public void ResetGame()
    {
        //Define as posições iniciais das raquetes
        playerPaddle.position = new Vector3(-7f, 0, 0);
        enemyPaddle.position = new Vector3(7f, 0, 0);

        ballController.ResetBall();
    }
}
