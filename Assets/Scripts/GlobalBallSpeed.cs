using UnityEngine;
using System.Collections;

public class GlobalBallSpeed : MonoBehaviour {
    static public float ballSpeed = 8f;

    static public Vector2 score = new Vector2();
    static public Vector2 GetBallSpeed(float angle)
    {
        float x = Mathf.Cos(angle) * ballSpeed;
        float y = Mathf.Sin(angle) * ballSpeed;

        return new Vector2(x, y);
    }
}
