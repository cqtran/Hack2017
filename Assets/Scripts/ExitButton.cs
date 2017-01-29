using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : MonoBehaviour {
	public Transform singlePlayer, mainMenu;
	public void Exit() {
		Application.Quit();
	}

	public void SinglePlayer(bool clicked){
		if (clicked == true) {
			singlePlayer.gameObject.SetActive (clicked);
			mainMenu.gameObject.SetActive (false);
		} else {
			singlePlayer.gameObject.SetActive (clicked);
			mainMenu.gameObject.SetActive (true);
		}

	}
}
