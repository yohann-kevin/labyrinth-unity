using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AfterBurner : MonoBehaviour {

    [SerializeField]
    int LevelToLoad;

    [SerializeField]
    bool AutoIndex = true;

    private void Start() {
        if (AutoIndex) {
            LevelToLoad = SceneManager.GetActiveScene().buildIndex + 1; 
        }
        
    }
    private void OnCollisionEnter(Collision collision) {
        SceneManager.LoadScene(LevelToLoad);
    }
}
