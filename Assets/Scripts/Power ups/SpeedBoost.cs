using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D coll) {
        if (coll.gameObject.tag == "Player") {
            Debug.Log("SpeedBoost");
            coll.gameObject.GetComponent<PlayerMovementV2>().maxSpeed = 10f;
            GameObject.Destroy(gameObject);
        }
    }
}
