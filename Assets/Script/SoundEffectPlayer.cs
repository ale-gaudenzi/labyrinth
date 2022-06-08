using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectPlayer : MonoBehaviour
{
    public static SoundEffectPlayer seIstance;
    [SerializeField] private AudioClip death, nextlevel, win;

    void Awake() {
        if(seIstance == null) {
            seIstance = this;
            DontDestroyOnLoad(gameObject);
        }
        else {
            Destroy(gameObject);
        }
    }

    public void DeathSound() {
        SoundManager.smIstance.PlaySound(death, true);
    }
 
    public void NextLevelSound() {
        SoundManager.smIstance.PlaySound(nextlevel, false);
    }

    public void WinSound() {
        SoundManager.smIstance.PlaySound(win, false);
    }
}
