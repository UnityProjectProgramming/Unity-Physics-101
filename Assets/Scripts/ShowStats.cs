using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class ShowStats : MonoBehaviour {

    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(name + "Intertia : " + rb.inertiaTensor);
        Debug.Log(name + "Centre of Mass " + rb.centerOfMass);
	}
}
