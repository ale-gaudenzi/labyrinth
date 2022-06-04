using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OverlayManager : MonoBehaviour
{
	public static OverlayManager omIstance;
	
	public GameObject deathOverlay;
	public GameObject winOverlay;
	public GameObject pauseMenu;
	public GameObject levelOverlay;
	public GameObject guiOverlay;


	public static bool isPaused; 
	public static bool isOverlay; 

	void Start()
    {
		omIstance = this;
		
		DontDestroyOnLoad(gameObject);
		DontDestroyOnLoad(deathOverlay);
		DontDestroyOnLoad(winOverlay);
		DontDestroyOnLoad(pauseMenu);
		DontDestroyOnLoad(levelOverlay);
		DontDestroyOnLoad(guiOverlay);

		deathOverlay.SetActive(false);
		winOverlay.SetActive(false);		
		levelOverlay.SetActive(false);
		pauseMenu.SetActive(false);
    }


	void Update()
    {
	
        if(Input.GetKeyDown(KeyCode.Escape)) {
			if(isPaused || isOverlay) {
				ResumeGame();
			}
			else {
				PauseGame();
			}
		}
		if(isOverlay) {
			if(Input.anyKey) {
				ResumeGame();
			}
		}
    }
	
		
	public void PauseGame()
    {
        pauseMenu.SetActive(true);
		Time.timeScale = 0f;
		isPaused = true;
		TimeScript.timeIstance.setPaused(true);
    }
	
	public void ResumeGame()
    {
		RemoveOverlay();
		Time.timeScale = 1f;
		isPaused = false;
		isOverlay = false;
		TimeScript.timeIstance.setPaused(false);
    }
	
	public void GoToMainMenu(){
		RemoveOverlay();
		Time.timeScale = 1f;
		TimeScript.timeIstance.setPaused(true);
		TimeScript.timeIstance.Reset();
		guiOverlay.SetActive(false);
		SceneManager.LoadScene("MainMenu");
	}
	
	public void QuitGame(){
		Application.Quit();
	}
	
	public void Death() {
        deathOverlay.SetActive(true);
		Time.timeScale = 0f;
		isOverlay = true;
    }
	
	public void Win() {
        winOverlay.SetActive(true);
		Time.timeScale = 0f;
		isOverlay = true;
    }
	
	public void NewLevel() {
        levelOverlay.SetActive(true);
		Time.timeScale = 0f;
		isOverlay = true;
    }
	
	
	public void RemoveOverlay() {
		deathOverlay.SetActive(false);
		winOverlay.SetActive(false);
		pauseMenu.SetActive(false);
		levelOverlay.SetActive(false);
	}
	
	public void setGui(){
		this.guiOverlay.SetActive(true);

	}
	
}
