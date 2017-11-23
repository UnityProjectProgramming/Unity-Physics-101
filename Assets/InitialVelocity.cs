using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialVelocity : MonoBehaviour {

    public Vector3 initialVelocity;
    public Vector3 initialW;

    private Rigidbody rb;

	void Start ()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = initialVelocity;
        rb.angularVelocity = initialW;
	}

}
