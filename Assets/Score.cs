using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score;
    public int score_points;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    public void update_score()
    {
        score_points += 1;
        score.text = "Score: " + score_points;

    }

    // Update is called once per frame
    void Update()
    {

        var scoreGo = (GameObject)GameObject.FindWithTag("score: ");
        var scoreComp = scoreGo.GetComponent<Scoring>();
        scoreComp.update_score();
     
    }

   
}
