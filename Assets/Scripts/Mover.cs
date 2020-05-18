using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour 
{
	public float speed;
	private Rigidbody2D rbody;
	public Vector2 vel;

	// Use this for initialization
	void Start () 
	{
		rbody = GetComponent<Rigidbody2D> ();



	}
	
	// Update is called once per frame
	void Update () 
	{
		if (gameObject.tag == "Fire")
		{
			rbody.velocity = transform.right * speed;
		}


	}
	void FixedUpdate()
	{
		
		
		if (gameObject.tag == "roid1" || gameObject.tag == "roid2")
		{
			
			rbody.MovePosition (rbody.position + vel *Time.fixedDeltaTime);

		}



	}

}
