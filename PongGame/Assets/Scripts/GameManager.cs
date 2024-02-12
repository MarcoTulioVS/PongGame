using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public Transform playerPaddle;
    public Transform enemyPaddle;

    public BallController ballController;

    public int playerScore;
    public int enemyScore;

    public TextMeshProUGUI textPointsPlayer;
    public TextMeshProUGUI textPointsEnemy;


    public int winPoints;

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

        playerScore = 0;
        enemyScore = 0;

        textPointsEnemy.text = enemyScore.ToString();
        textPointsPlayer.text = playerScore.ToString();
    }

    public void ScorePlayer()
    {
        playerScore++;
        textPointsPlayer.text = playerScore.ToString();
        CheckWin();
    }

    public void ScoreEnemy()
    {
        enemyScore++;
        textPointsEnemy.text = enemyScore.ToString();
        CheckWin();
    }

    public void CheckWin()
    {
        if(enemyScore>=winPoints || playerScore >= winPoints)
        {
            ResetGame();
        }
    }

}
