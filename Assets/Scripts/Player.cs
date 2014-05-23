using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public enum player
    {
        player1=1,
        player2=2,
        AI=3
    };

    public Transform ball;
    public player Playertype;
	void Update () {
        if (transform.position.y < 7 && transform.position.y > -7)
        {
            switch (Playertype)
            {
                case player.player1:
                   rigidbody.AddForce(new Vector3(0, Input.GetAxis("Player1")*10,0));
                   if (Input.GetAxis("Player1") == 0)
                       rigidbody.velocity = Vector3.zero;
                    break;

                case player.player2:
                    rigidbody.AddForce(new Vector3(0, Input.GetAxis("Player2")*10, 0));
                    if (Input.GetAxis("Player2") == 0)
                        rigidbody.velocity = Vector3.zero;
                    break;

                case player.AI:
                    break;
            }
        }
        else
        {
            if (transform.position.y >= 7)
                transform.position = new Vector3(transform.position.x, 6.9999f, 0);
            if (transform.position.y <= -7)
                transform.position = new Vector3(transform.position.x, -6.9999f, 0);
            rigidbody.velocity = Vector3.zero;
        }
	}
}
