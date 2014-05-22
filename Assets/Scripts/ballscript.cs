using UnityEngine;
using System.Collections;

public class ballscript : MonoBehaviour {

    bool gameStarted = false;
    enum direction
    {
        left,
        right
    }
    direction direct;

    void Update()
    {
        //Debug.Log(Input.GetAxis("PlayBall"));
        if (rigidbody2D.velocity.x < 0)
        {
            direct = direction.left;
        }
        if (rigidbody2D.velocity.x > 0)
        {
            direct = direction.right;
        }
        if (!gameStarted && Input.GetAxis("PlayBall") > 0.1f)
        {
            float ran = Random.Range(0, 2);
            if (ran > 1f)
                transform.rotation = Quaternion.Euler(0, 0, 180);
            else
                transform.rotation = Quaternion.Euler(0, 0, 0);
            gameStarted = true;
            rigidbody2D.velocity = GlobalBallSpeed.GetBallSpeed(transform.rotation.eulerAngles.z);
        }
        else if(gameStarted)
        {
            if (transform.position.x > 15f)
            {
                GlobalBallSpeed.score.x++;
                restartGame();
            }
            else if (transform.position.x < -15f)
            {
                GlobalBallSpeed.score.y++;
                restartGame();
            }
        }
    }

    void restartGame()
    {
        GlobalBallSpeed.ballSpeed = 8f;
        transform.position = Vector3.zero;
        gameStarted = false;
        rigidbody2D.velocity = Vector2.zero;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        particleSystem.Emit(250);
    }
}
