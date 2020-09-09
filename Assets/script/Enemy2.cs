using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour {

    [SerializeField]
    float speed = 3f;

    public Transform target;

    void Update() {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.collider.tag == "Player") {
            GameObject.Find("Player").GetComponent<PlayerController>().GameOver();
        }
    }
}
