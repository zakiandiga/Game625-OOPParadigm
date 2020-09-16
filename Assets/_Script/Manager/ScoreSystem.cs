using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    GameObject scoreBoard;
    Text txt;
    private int score;
    private int scoreAdd = 10;
    // Start is called before the first frame update
    void Start()
    {
        scoreBoard = GameObject.Find("ScoreBoard");
        txt = scoreBoard.GetComponent<Text>();
        Enemy.OnEnemyKill += AddScore;
    }

    private void AddScore(Enemy enemy)
    {
        score += 10;
        txt.text = "Score " + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
