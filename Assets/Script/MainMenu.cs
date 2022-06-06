using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour {
	
	public bool inLeaderboard;
	public GameObject leaderboard;
	public GameObject mainmenu;
	public GameObject insertname;
	public GameObject insertField;

    void Start() {
    	inLeaderboard = false; 
		leaderboard.SetActive(false);
		insertname.SetActive(false);

    }

    void Update() {
        if(inLeaderboard == true) {
			if(Input.anyKey) {
				inLeaderboard = false; 
				leaderboard.SetActive(false);
				mainmenu.SetActive(true);
			}
		}
    }
	
	public void GoToInsertName() {
		insertname.SetActive(true);
	}

	public void NewGame() {
		SceneManager.LoadScene("Livello1");
		GameClass.currentLevel = 1;
		GameClass.deathNumber = 0;
		GameClass.playername = insertField.GetComponent<TMP_InputField>().text;;

		OverlayManager.isPaused = false;
		OverlayManager.isMain = false;
	}
	
	public void LeaderBoard() {
		inLeaderboard = true; 
		leaderboard.SetActive(true);
		mainmenu.SetActive(false);

	}

	public void QuitGame(){
		Application.Quit();
	}
}
