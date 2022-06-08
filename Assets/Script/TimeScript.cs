using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeScript : MonoBehaviour {
	public static TimeScript timeIstance;
	public static float currentTime = 0.000f;
	public static bool isPaused;
	
    void Start() {
		timeIstance = this;
		isPaused = false;
        DontDestroyOnLoad(gameObject);
    }

    void Update() {
		if(!isPaused) {
       		currentTime += Time.deltaTime;
		}
    }
	
	public void Reset(){
		currentTime = 0.000f;
	}
	
	public void setPaused(bool pause){
		isPaused = pause;
	}
	
	public float getTime() {
		return currentTime;
	}

	public string getTimeFormatted() {
		int minutes = (int) currentTime / 60;
		float seconds = currentTime - 60 * minutes;
		string timeFormatted = minutes.ToString() + ":" + seconds.ToString("F2");
		return timeFormatted;
	}
}
