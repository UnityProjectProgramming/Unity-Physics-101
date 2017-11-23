using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torque : MonoBehaviour {


    public Vector3 torqueToAdd = new Vector3();
    public float torqueTime;
    private Rigidbody rb;
     
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate ()
    {
        if(torqueTime >= 0)
        {
            rb.AddTorque(torqueToAdd);
            torqueTime -= Time.deltaTime;
        }
    }
}
