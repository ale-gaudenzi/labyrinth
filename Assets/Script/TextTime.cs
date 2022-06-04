using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextTime : MonoBehaviour
{
	public TMP_Text text;
	
    void Start()
    {
		//text = this.gameObject.GetComponent<TextMeshPro>();
		
        text.text = "Time: " + TimeScript.timeIstance.getTime().ToString("F2");
    }

    void Update()
    {
	    text.text = "Time: " + TimeScript.timeIstance.getTime().ToString("F2");

        

    }
}
