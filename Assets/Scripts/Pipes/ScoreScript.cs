using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        playerScore = 0;
    }
    
    // Update is called once per frame
    void Update()
    {
        scoreText.text = (playerScore.ToString());
    }

    public void UpdateScore(Component sender, object data)
    {
        if(data is int)
        {
            playerScore = (int) data;
        }
    }
}
