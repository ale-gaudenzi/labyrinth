using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
	
    void Start()
    {
        
    }

    void Update()
    {
        
    }
	
	public void NewGame(){
		SceneManager.LoadScene("Livello1");
		GameClass.currentLevel = 1;
		GameClass.deathNumber = 0;
		OverlayManager.isPaused = false;
		OverlayManager.omIstance.setGui();
	}
	
	public void QuitGame(){
		Application.Quit();
	}
}
