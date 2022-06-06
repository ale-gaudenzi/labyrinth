using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameClass : MonoBehaviour {
	
	public static int currentScore = 0;
	public static int currentLevel = 1;
	public static int deathNumber = 0;
	public static string playername;

	private static int TOTAL_LEVEL = 2;
		
	void Start() {
		DontDestroyOnLoad(gameObject);
	}
	
	public static void CompleteLevel() {
		if(currentLevel == TOTAL_LEVEL) {
			WeWin();
		}
		else {
			currentLevel += 1;
			SceneManager.LoadScene(currentLevel);
			OverlayManager.omIstance.NewLevel();
			SoundEffectPlayer.seIstance.NextLevelSound();
		}
	}

    public static void WeDied() {
        currentScore -= 1;
		OverlayManager.omIstance.Death();
		deathNumber++;
		SoundEffectPlayer.seIstance.DeathSound();
    }
	
	public static void WeWin() {
		OverlayManager.omIstance.Win();
		LeaderboardTable.AddEntry(playername, TimeScript.currentTime, deathNumber);
		SoundEffectPlayer.seIstance.WinSound();

	}
	

    void OnGUI() {

	}
}
