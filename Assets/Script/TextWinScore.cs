using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextWinScore : MonoBehaviour
{
	public TMP_Text text;
	
    void Start()
    {		
        text.text = "Time:" + TimeScript.timeIstance.getTime().ToString("F2") + "  Death:" + GameClass.deathNumber.ToString();
    }

    void Update()
    {

        text.text = "Time: " + TimeScript.timeIstance.getTime().ToString("F2") + "s Death: " + GameClass.deathNumber.ToString();


    }

}
