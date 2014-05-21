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

    void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "Ball")
        {
            col.collider.transform.rotation = Quaternion.Euler(0, 0, 180f / 8f * segmentNum * (int)side);
            col.collider.particleSystem.Emit(200);
            if (side == LeftOrRight.left)
                col.collider.particleSystem.startColor = Color.red;
            if (side == LeftOrRight.right)
                col.collider.particleSystem.startColor = Color.magenta;
        }
    }
}
