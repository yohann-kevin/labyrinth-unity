using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {
    public bool CanOpen = false;

    [SerializeField]
    AudioClip sndOpen, sndDenied;
    private AudioSource myAudioSource;

    [SerializeField]
    Animator myAnimator;

    [SerializeField]
    GameObject endPoint;
    
    private void Awake() {
        myAudioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player" && CanOpen) {
            myAnimator.enabled = true;
            myAudioSource.PlayOneShot(sndOpen);
            endPoint.SetActive(true);
        } else if (!CanOpen) {
            myAudioSource.PlayOneShot(sndDenied);
        }
    }
}
