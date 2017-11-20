using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniversalGravitational : MonoBehaviour {

    private const float bigG = 6.673e-11f;

    private PhysicsEngine[] physicsEngineArray;

    // Use this for initialization
    void Start () {
        physicsEngineArray = GameObject.FindObjectsOfType<PhysicsEngine>();

    }

    // Update is called once per frame
    void FixedUpdate () {
        CalculateGravity();
	}

    void CalculateGravity()
    {
        foreach (PhysicsEngine physicsEngineA in physicsEngineArray)
        {
            foreach (PhysicsEngine physicsEngineB in physicsEngineArray)
            {
                if (physicsEngineA != physicsEngineB && physicsEngineA != this)
                {
                    Debug.Log("Calculating Force Exerted On  " + physicsEngineA.name +
                              " due to gravity of " + physicsEngineB.name);

                    // Force = Gravitational Constant * mass 1 * mass 2 / distance between them squared
                    Vector3 offset = physicsEngineA.transform.position - physicsEngineB.transform.position;
                    float rSquared = Mathf.Pow(offset.magnitude, 2.0f);
                    float gravityMagnitude = bigG * physicsEngineA.mass * physicsEngineB.mass / rSquared;
                    Vector3 gravityFeltVector = gravityMagnitude * offset.normalized;
                    physicsEngineA.AddForce(-gravityFeltVector);
                }

            }
        }
    }

}
