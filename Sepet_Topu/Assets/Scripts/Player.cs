using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public GameObject Ball;
    public Ball ball;
    Rigidbody ballrb;
    public GameObject PlayerCamera;
    public float BallDistance = 1f;
    public float ThrowPowerStrong = 550f;
    public float ThrowPowerWeak = 350f;
    public bool HoldingBall = true;

    void Start()
    {
        ballrb = Ball.GetComponent<Rigidbody>();
        ballrb.useGravity = false;
    }

    void Update()
    {
        if (HoldingBall)
        {
            Ball.transform.position = PlayerCamera.transform.position + PlayerCamera.transform.forward * BallDistance;

			if (Input.GetMouseButtonDown(0))
			{
                HoldingBall = false;
                ballrb.useGravity = true;
                ballrb.AddForce(PlayerCamera.transform.forward * ThrowPowerStrong);
                ball.trailParticle.SetActive(true);
            }

            if (Input.GetMouseButtonDown(1))
            {
                HoldingBall = false;
                ballrb.useGravity = true;
                ballrb.AddForce(PlayerCamera.transform.forward * ThrowPowerWeak);
                ball.trailParticle2.SetActive(true);
            }
        }
    }
}
