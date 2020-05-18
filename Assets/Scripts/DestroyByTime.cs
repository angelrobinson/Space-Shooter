using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByTime : MonoBehaviour {

	private float lifetime;

	// Use this for initialization
	void Start () 
	{
		lifetime = 1.5f;
		Destroy (gameObject,lifetime);
	}
	

}
