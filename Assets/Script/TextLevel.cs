using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextLevel : MonoBehaviour
{
	public TMP_Text text;
	
    void Start() {		
        text.text = "Level " + GameClass.currentLevel.ToString();
    }

    void Update() {
	    text.text = "Level " + GameClass.currentLevel.ToString();
    }
}
