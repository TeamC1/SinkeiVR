using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flick : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Rigidbody rigidBody = gameObject.GetComponent<Rigidbody> ();
		rigidBody.velocity = new Vector3 (-3, 0, 0);
		Destroy (gameObject, 0.5f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
