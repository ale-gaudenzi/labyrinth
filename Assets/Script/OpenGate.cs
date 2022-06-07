using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGate : MonoBehaviour
{   
    public GameObject piston1;
    public GameObject piston2;
    public GameObject key;
    public Transform position1;
    public Transform position2;
   // public Transform arrivalPosition1;
   // public Transform arrivalPosition2;

    public float speed;

    public static bool keyTaken;
    public static bool isClosed;
    
    void Start() {
        keyTaken = false;
        isClosed = true;
        position1 = piston1.GetComponent<Transform>();
        position2 = piston2.GetComponent<Transform>();
    }

    void Update() {
        if(keyTaken == true) {
            Renderer rend = key.GetComponent<Renderer>();
            rend.enabled = false;
            Open();
        }
    }

    void Open() {
        if(isClosed) {
            position1.Translate(-0.9f, 0.0f, 0.0f);
            position2.Translate(-0.9f, 0.0f, 0.0f);  
        }

        isClosed = false;
    }

    public static void KeyTaken() {
        keyTaken = true;
        print("KEY TAKEN!!!");
    }
}
