using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour {


    public TextMesh player1Score;
    public TextMesh player2Score;
	// Update is called once per frame
	void Update () {
        player1Score.text = ""+GlobalBallSpeed.score.x;
        player2Score.text = "" + GlobalBallSpeed.score.y;
	}
}
