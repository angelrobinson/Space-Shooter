using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMover : MonoBehaviour {

	public float tumble;
	private Rigidbody2D rbody;


	// Use this for initialization
	void Start () 
	{
		rbody = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void FixedUpdate () 
	{
		//add some movement to the asteroid
		rbody.MoveRotation (Random.value * tumble);
	}
}
