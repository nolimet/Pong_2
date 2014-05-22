using UnityEngine;
using System.Collections;

public class Segment : MonoBehaviour {

    public int segmentNum = 0;
    public enum LeftOrRight
    {
        left = 1,
        right = -1
    };

    public LeftOrRight side;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "Ball")
        {
            
            
            if (side == LeftOrRight.left)
                col.collider.gameObject.particleSystem.startColor = Color.red;
            col.collider.transform.rotation = Quaternion.Euler(0, 0, -180f / 8f * segmentNum * (int)side);
            if (side == LeftOrRight.right)
                col.collider.gameObject.particleSystem.startColor = Color.magenta;
            col.collider.transform.rotation = Quaternion.Euler(0, 0, 180f / 8f * segmentNum * (int)side);

            //col.collider.gameObject.particleSystem.Emit(250);
            if (GlobalBallSpeed.ballSpeed < 30f)
                GlobalBallSpeed.ballSpeed += 0.5f; ;
            col.collider.gameObject.rigidbody2D.velocity = GlobalBallSpeed.GetBallSpeed(col.collider.transform.rotation.eulerAngles.z);
        }
    }
}
