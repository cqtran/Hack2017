using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

	public void restartLevel()
	{
		Application.LoadLevel ("main_screen_with_grass");

}
	public void quitMenu(){
		Application.LoadLevel ("Menu");
	}
}