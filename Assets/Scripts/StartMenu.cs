using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour 
{
	
	public void loadGame()
	{
		
		SceneManager.LoadScene ("Main");
	}

	public void exitGame()
	{
		Application.Quit ();

	}
}
