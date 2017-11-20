using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour {

    Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        rb.angularVelocity = new Vector3(4f, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
