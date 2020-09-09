using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Return : MonoBehaviour {

    [SerializeField]
    Transform myTarget;

    [SerializeField]
    Enemy2 enemy2;

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Ball") {
            enemy2.target = myTarget;
        }
    }
}
