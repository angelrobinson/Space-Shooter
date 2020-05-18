using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAsteroid : MonoBehaviour 
{
	public GameObject explosion;
	public GameObject playerExplode;
	public int scoreValue;
	private GameController controller;


	void Start()
	{
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
		if (gameControllerObject != null)
		{
			controller = gameControllerObject.GetComponent <GameController> ();

		}
	}

	void Update()
	{
		
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		//ignore the boundary collider so that it doesn't immediately destroy all objects within the boundary
		if (other.tag == "Boundary")
		{
			return;
		}

		//if Asteroid collides into Playership
		if (other.tag == "Player")
		{
			Instantiate (playerExplode, other.transform.position, other.transform.rotation);
			controller.UpdateLives ();
		}

		Instantiate (explosion, other.transform.position, other.transform.rotation);
		controller.AddScore (scoreValue);
		Destroy (other.gameObject);
		Destroy (gameObject);

	}


}
