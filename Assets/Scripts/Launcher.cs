using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour {

    public float maxLaunchSpeed;
    public PhysicsEngine ballToLaunch;

    public float launchSpeed;
    private float extraSpeedPerFrame;
	void Start ()
    {
        extraSpeedPerFrame = (maxLaunchSpeed * Time.fixedDeltaTime) / 2;
	}
	
	void Update ()
    {
		
	}

    private void OnMouseDown()
    {
        // Increase ball speed to max over few seconds.
        launchSpeed = 0;
        // Consider InvokeRepeating
        InvokeRepeating("IncreaseLaunchSpeed", 0.5f, Time.fixedDeltaTime);
    }

    private void OnMouseUp()
    {
        // Launch the ball
        CancelInvoke();
        PhysicsEngine newBall = Instantiate(ballToLaunch);
        newBall.transform.parent = GameObject.Find("Launched Balls").transform;
        newBall.gameObject.AddComponent<UniversalGravitational>();
        Vector3 velocityVector = new Vector3(1, 1, 0).normalized * launchSpeed;
        newBall.velocityVector = velocityVector;

    }

    void IncreaseLaunchSpeed()
    {
        if(launchSpeed <= maxLaunchSpeed)
        {
            launchSpeed += extraSpeedPerFrame;
        }
    }
}
