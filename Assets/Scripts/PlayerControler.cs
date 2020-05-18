using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour 
{
	public float rotationSpeed;
	public Rigidbody2D rbody;
	public GameObject shot;
	public Transform shotSpawn1, shotSpawn2, shotSpawn3;
	public float rate;
	private float next;
	private int num;
	private AudioSource aud;



	void Start()
	{
		rbody = GetComponent <Rigidbody2D> ();
		aud = GetComponent <AudioSource> ();

		next = 0.0f;


	}

	void FixedUpdate()
	{
		if (Input.GetKey (KeyCode.RightArrow))
		{
			rbody.transform.Rotate (Vector3.back, rotationSpeed);
		} else if (Input.GetKey (KeyCode.LeftArrow))
		{
			rbody.transform.Rotate (Vector3.forward,rotationSpeed);
		}



			

	}

	void Update()
	{
		
		num = Random.Range (1, 4);

		if (Input.GetKey (KeyCode.Space) && Time.time > next)
		{


			next = Time.time + rate;
			switch (num)
			{

			case 1:
				Instantiate (shot, shotSpawn1.position, shotSpawn1.rotation);
				break;
			case 2:
				Instantiate (shot, shotSpawn2.position, shotSpawn2.rotation);
				break;
			case 3: 
				Instantiate (shot, shotSpawn3.position, shotSpawn3.rotation);
				break;
			}
			aud.Play ();

		}

	

			


	}




	

}
