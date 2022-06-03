using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {
	
	public bool isQuit;
	public bool isStart;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	void OnMouseUp(){
		if(isStart)
		{
			Application.LoadLevel(1);
		}
		if (isQuit)
		{
			Application.Quit();
		}
} 
}
