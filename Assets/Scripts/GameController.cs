using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour 
{
	public GameObject player, clone, hazard1, hazard2, spawn1, spawn2, spawn3, spawn4, spawn5, spawn6, spawn7, spawn8;
	public GameObject[] spawns;
	private GameObject useHazard;
	private int maxRoids, lives, score;
	private float startWait, spawnWait;
	public Text scoreText, livesText;


	// Use this for initialization
	void Start() 
	{
		
		
		maxRoids = lives = 3;
		startWait = spawnWait = 2.0f;
		score = 0;
		player = Instantiate (clone);
		newPlayer ();
		if (spawn1 == null)
		{
			spawn1 = Instantiate (spawns [0]);
			spawn2 = Instantiate (spawns [1]);
			spawn3 = Instantiate (spawns [2]);
			spawn4 = Instantiate (spawns [3]);
			spawn5 = Instantiate (spawns [4]);
			spawn6 = Instantiate (spawns [5]);
			spawn7 = Instantiate (spawns [6]);
			spawn8 = Instantiate (spawns [7]);
		}
		UpdateScore ();
		UpdateLivesText ();
		StartCoroutine(SpawnWaves ());


	}

	void Update()
	{
		if (Input.GetKey (KeyCode.Space))
		{
			newPlayer ();
		}




	}

	
	// Display score
	void UpdateScore () 
	{
		scoreText.text = "Score: " + score;
	}

	//updateScore with new value
	public void AddScore(int newScoreValue)
	{
		score += newScoreValue;
		UpdateScore ();
	}

	void UpdateLivesText ()
	{
		livesText.text = "Lives: " + lives;
	}

	public void GameOver()
	{
				
		SceneManager.LoadScene ("Start");

	}

	public void UpdateLives()
	{
		lives--;
		UpdateLivesText ();
		if (lives == 0)
		{
			GameOver ();
		
		}

	}

	void newPlayer()
	{
		if (player == null)
		{
			player = Instantiate (clone);
		}

	}


	IEnumerator SpawnWaves()
	{
		//wait for 2 seconds before spawning anything
		yield return new WaitForSeconds (startWait);
		//game runs as long as there are lives left
		while (lives > 0)
		{
			for (int i = 0; i < maxRoids; i++)
			{
				int num = Random.Range (1, 9); //random number for spawnpoint
				int num1 = Random.Range (1, 3); //random number for asteroid

				//pick which asteroid is going to be used
				if (num1 == 1)
				{
					useHazard = hazard1;
				} else
				{
					useHazard = hazard2;
				}
				
				//determin which spawnpoint to use
				switch (num)
				{
				case 1:
					useHazard.GetComponent <Mover>().vel = new Vector2 (0, -5);
					Instantiate (useHazard, spawn1.transform.position, Quaternion.identity);
					break;
				case 2:
					useHazard.GetComponent <Mover>().vel = new Vector2 (-5, 0);
					Instantiate (useHazard, spawn2.transform.position, Quaternion.identity);
					break;
				case 3:
					useHazard.GetComponent <Mover>().vel = new Vector2 (0, 5);
					Instantiate (useHazard, spawn3.transform.position, Quaternion.identity);
					break;
				case 4:
					useHazard.GetComponent <Mover>().vel = new Vector2 (5, 0);
					Instantiate (useHazard, spawn4.transform.position, Quaternion.identity);
					break;
				case 5:
					useHazard.GetComponent <Mover>().vel = new Vector2 (5, -5);
					Instantiate (useHazard, spawn5.transform.position, Quaternion.identity);
					break;
				case 6:
					useHazard.GetComponent <Mover>().vel = new Vector2 (-5, -5);
					Instantiate (useHazard, spawn6.transform.position, Quaternion.identity);
					break;
				case 7:
					useHazard.GetComponent <Mover>().vel = new Vector2 (-5, 5);
					Instantiate (useHazard, spawn7.transform.position, Quaternion.identity);
					break;
				case 8:
					useHazard.GetComponent <Mover>().vel = new Vector2 (5, 5);
					Instantiate (useHazard, spawn8.transform.position, Quaternion.identity);
					break;


				}
				//wait for 2 seconds before spawning a new asteroid
				yield return new WaitForSeconds (spawnWait);
				//newPlayer ();

			}

			yield return new WaitForSeconds (4);
								
		}


		

	}
}
