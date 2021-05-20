using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketBallLetGo : MonoBehaviour
{
    public void BallLetgo()
    {
        print("LetGo Called");

        GameObject ball = GameObject.Find("Dribble Collider");
        MovePlayerOnCollision otherScript = ball.GetComponent<MovePlayerOnCollision>();
        if (otherScript.letGo == false)
        {
            otherScript.LetGo();
        }
    }
    public void BallGrabbed()
    {

        print("Grab Called");
        GameObject ball = GameObject.Find("Dribble Collider");
        MovePlayerOnCollision otherScript = ball.GetComponent<MovePlayerOnCollision>();
        if (otherScript.letGo == true)
        {
            otherScript.Grab();
        }
    }
}
