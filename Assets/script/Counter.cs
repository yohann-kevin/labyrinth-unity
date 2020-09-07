using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour {
    [SerializeField]
    private int startCounter = 60;

    [SerializeField]
    Text txtCounter;

    void Start() {
        txtCounter.text = "TimeLeft : " + startCounter;
        StartCoroutine(Pause());
    }

    IEnumerator Pause() {
        while (startCounter > 0) {
            yield return new WaitForSeconds(1f);
            startCounter--;
            txtCounter.text = "TimeLeft : " + startCounter;
        }

        GameObject.Find("Player").GetComponent<PlayerController>().GameOver();
    }
}
