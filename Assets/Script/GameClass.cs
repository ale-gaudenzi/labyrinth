using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameClass : MonoBehaviour {
	public static int highscore ;
	public static int currentScore = 0;
	public static int currentLevel = 0;
	private static bool youWin = false;
	private static bool youDied = false;

	void Start(){
		DontDestroyOnLoad (gameObject);
	}

	public static void CompleteLevel(){
		currentLevel += 1;
		print ("You win!!");

		youWin = true;

		//Application.LoadLevel (1);
	}

    public static void WeDied()
    {
        currentScore -= 1;
		print("You died!");

		
    }


    void OnGUI()
	{
		if(youWin)
		{
			GUI.Label(new Rect (200, 200, 500, 600), "You WIN!!");
             //GUI.Button();
		}
		
		if(youDied){
			GUI.Label(new Rect (200, 200, 500, 600), "You DIED!!");
		}
	}

}
