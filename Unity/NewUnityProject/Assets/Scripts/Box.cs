using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour {
	int updates = 0;
	Rigidbody myRigidBody;


	// Use this for initialization
	void Awake () {
		Debug.Log("in start");
		myRigidBody = GetComponent<Rigidbody>();
		Invoke("DeleteMe", 10);
	}
	
	// extra functions 
	public void AddForceToMe(Vector3 force){
	myRigidBody.AddForce(force);
	}


	// Update is called once per frame
	void Update () {
		Debug.Log("update: " + updates);
		updates++;
	}

	voide DeleteMe(){
		Destroy(gameObject);
	}
}
