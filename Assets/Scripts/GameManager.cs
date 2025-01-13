using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int scorePlayer1, scorePlayer2;
    public ScoreText scoreTextLeft, scoreTextRight;

    public void OnScoreZoneReached(int id)
    {
        if (id == 1)
        {
            scorePlayer1++;
        }

        if (id == 2)
        {
            scorePlayer2++;
        }

        UpdateScores();
        HighLightScore(id);
    }

    private void UpdateScores()
    {
        scoreTextLeft.SetScore(scorePlayer1);
        scoreTextRight.SetScore(scorePlayer2);
    }

    public void HighLightScore(int id)
    {
        if (id == 1)
        {
            scoreTextLeft.HighLight();
        }
        else
        {
            scoreTextRight.HighLight();
        }
    }
}
