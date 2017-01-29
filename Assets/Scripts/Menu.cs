//Followed tutorial for assets and basic layout creation. https://www.youtube.com/watch?v=OWtQnZsSdEU
//Followed tutorial to create menu functionality for going forward and back with buttons https://www.youtube.com/watch?v=9hPYXi5aXzw&t=450s

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Menu : MonoBehaviour {
	public Canvas MainMenu;
	public Canvas InstructionsCanvas;

	void Awake()
	{

		InstructionsCanvas.enabled = false; 
	}
	public void InstructionsCn(){
		InstructionsCanvas.enabled = true;
		MainMenu.enabled = false;
	}

	public void BackOn()
	{
		InstructionsCanvas.enabled = false;
		MainMenu.enabled = true; 
	}
	public void LoadOn()
	{
		Application.LoadLevel (1);
		
	}
	public void playButton()
	{
		Application.LoadLevel ("main_screen_with_grass");
	}
	public void ClickQuit()
	{
		Application.Quit ();
	}

}
