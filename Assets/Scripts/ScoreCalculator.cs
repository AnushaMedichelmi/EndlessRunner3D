using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCalculator : MonoBehaviour
{
    // Start is called before the first frame update
    public int score;
    public GameObject winPage;
    public void Score(int scoreValue)
    {
        score = score + scoreValue;
        if (score > 30)
        {
            winPage.SetActive(true);

        }
        Debug.Log(score);
    }
}