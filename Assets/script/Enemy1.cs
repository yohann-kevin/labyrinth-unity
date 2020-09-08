using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour {

    private void OnCollisionEnter(Collision collision) {
        if (collision.collider.tag == "Player") {
            GameObject.Find("Player").GetComponent<PlayerController>().GameOver();
        }
    }
}
