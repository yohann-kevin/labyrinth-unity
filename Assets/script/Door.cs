using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {
    public bool CanOpen = false;
    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player" && CanOpen) {
            GetComponent<Animator>().enabled = true;
        }
    }
}
