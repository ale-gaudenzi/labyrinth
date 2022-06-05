using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnEnable : MonoBehaviour
{
    [SerializeField] private AudioClip clip;

    public void OnEnable() { 
        SoundManager.smIstance.PlaySound(clip);
    }
}
