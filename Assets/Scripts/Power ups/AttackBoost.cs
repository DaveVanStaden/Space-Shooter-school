using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBoost : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D coll) {
        if (coll.gameObject.tag == "Player") {
            Debug.Log("AttackBoost");
            coll.gameObject.GetComponent<PlayerShoot>().projectileDamage = 60;
            GameObject.Destroy(gameObject);
        }
    }
}
