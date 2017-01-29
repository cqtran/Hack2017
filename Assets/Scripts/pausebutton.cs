using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Followed tutorial to create this pause script https://www.youtube.com/watch?v=7dCtacifmU8
public class pausebutton : MonoBehaviour {
	public bool paused;
	// Use this for initialization
	void Start () {
		paused = false;

		
	}
	
	// Update is called once per frame
	void Update () {
		

	}
	public void pause ()
	{
		paused = !paused;
		if (paused) {
			Time.timeScale = 0;
		} else if (!paused) {
			Time.timeScale = 1;
		}
	}
}
