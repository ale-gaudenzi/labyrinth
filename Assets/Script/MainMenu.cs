using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
	
	public bool inLeaderboard;
	public GameObject leaderboard;
	public GameObject mainmenu;

    void Start() {
    	inLeaderboard = false; 
		leaderboard.SetActive(false);
    }

    void Update() {
        if(inLeaderboard = true) {
			if(Input.anyKey) {
				inLeaderboard = false; 
				leaderboard.SetActive(false);
				mainmenu.SetActive(true);

			}
		}
    }
	
	public void NewGame(){
		SceneManager.LoadScene("Livello1");
		GameClass.currentLevel = 1;
		GameClass.deathNumber = 0;
		OverlayManager.isPaused = false;
		OverlayManager.omIstance.setGui();
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
