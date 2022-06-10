using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextTime : MonoBehaviour {
	public TMP_Text text;
	
    void Start() {
        text.text = "Time " + TimeScript.timeIstance.getTimeFormatted();
    }

    void Update() {
	    text.text = "Time " + TimeScript.timeIstance.getTimeFormatted();
    }
}
