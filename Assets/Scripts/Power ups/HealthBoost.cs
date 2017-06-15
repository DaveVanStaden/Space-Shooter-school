using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBoost : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D coll) {
        if (coll.gameObject.tag == "Player") {
            Debug.Log("HealthBoost");
            PlayerHealth.playerHealth = 9999f;
            GameObject.Destroy(gameObject);
        }
    }
}
