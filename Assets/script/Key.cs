using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {
    private void OnCollisionEnter(Collision collision) {
        if (collision.collider.tag == "Player") {
            GameObject.Find("DoorExit").GetComponent<Door>().CanOpen = true;
            Destroy(transform.parent.gameObject);
        }
    }
}
