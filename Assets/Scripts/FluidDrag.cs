using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FluidDrag : MonoBehaviour {

    [Range(1.0f, 2.0f)] public float velocityExponent;  //[none]
    public float dragConstant;  // ??


    private PhysicsEngine physicEngine;
	void Start ()
    {
        physicEngine = GetComponent<PhysicsEngine>();
	}
	
	void FixedUpdate ()
    {
        Vector3 velocityVector = physicEngine.velocityVector;
        float speed = velocityVector.magnitude;
        float dragSize = CalculateDrag(speed);
        Vector3 dragVector = dragSize * -velocityVector.normalized;
        physicEngine.AddForce(dragVector);
	}

    float CalculateDrag(float spped)
    {
        return dragConstant * Mathf.Pow(spped, velocityExponent);
    }
}
