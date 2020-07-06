using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {
    public bool CanOpen = false;
    [SerializeField]
    AudioClip sndOpen, sndDenied;
    private AudioSource myAudioSource;
    
    private void Awake() {
        myAudioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player" && CanOpen) {
            GetComponent<Animator>().enabled = true;
            myAudioSource.PlayOneShot(sndOpen);
        } else if (!CanOpen) {
            myAudioSource.PlayOneShot(sndDenied);
        }
    }
}
