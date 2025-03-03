using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnStart : MonoBehaviour
{
    [SerializeField] private AudioClip clip;

    void Awake() {
        SoundManager.smIstance.PlaySound(clip, true);
    }

    void OnDestroy() {
        SoundManager.smIstance.StopSound();
    }

}
