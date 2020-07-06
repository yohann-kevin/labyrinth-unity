using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {
    private void OnCollisionEnter(Collision collision) {
        if (collision.collider.tag == "Player") {
            GameObject.Find("DoorExit").GetComponent<Door>().CanOpen = true;
            GetComponent<AudioSource>().Play();
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<BoxCollider>().enabled = false;
            Destroy(transform.parent.gameObject,0.5f);
        }
    }
}
