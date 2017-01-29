using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggeryo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnColliderEnter2D (Collider2D collider)
	{
		if(collider.tag == "Player")
			Application.LoadLevel("gameover");
	}
}
