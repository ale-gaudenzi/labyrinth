using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextDeath : MonoBehaviour
{
	public TMP_Text text;
	
    void Start() {	
        text.text = "Death " + GameClass.deathNumber.ToString();
    }

    void Update() {
        text.text = "Death " + GameClass.deathNumber.ToString();
    }
}
