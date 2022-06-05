using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {
    public static SoundManager smIstance;
    [SerializeField] private AudioSource musicSource, effectsSource;

    void Start() {
        
    }

    void Update() {
        
    }

    void Awake() {
        if(smIstance == null) {
            smIstance = this;
            DontDestroyOnLoad(gameObject);
        }
        else {
            Destroy(gameObject);
        }
    }

    public void PlaySound(AudioClip clip) {
        musicSource.PlayOneShot(clip);
    }

    public void StopSound() {
        musicSource.Stop();
    }


}
