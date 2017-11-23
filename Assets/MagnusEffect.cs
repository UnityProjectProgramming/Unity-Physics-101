using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnusEffect : MonoBehaviour {

    public float magnusConstant = 1.0f;

    private InitialVelocity initial;

    private Rigidbody rb;
	
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
        initial = GetComponent<InitialVelocity>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        rb.AddForce(magnusConstant * Vector3.Cross(rb.angularVelocity, rb.velocity));
       
	}
}
