using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {

	public void QuitGame (){
		Application.Quit ();
		Debug.Log ("Quit Game");
	}
	public void ChooseGameMode (){
		SceneManager.LoadScene ("GameMode1");
	}
	public void ReturntoMenu (){
		SceneManager.LoadScene ("Start Menu");
	}
}
