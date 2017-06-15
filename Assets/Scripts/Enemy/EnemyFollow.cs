using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyFollow : MonoBehaviour {

    Transform playerTransform;

    void GetPlayerTransform() {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null) {
            playerTransform = player.transform;
        } else {
            Debug.Log("Player not found");
        }
    }

    public float speed;

    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, GameObject.FindGameObjectWithTag("Player").transform.position, step);

        transform.LookAt(playerTransform);
    }

    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag == "Player") {
            Debug.Log("Enemy hit");
            PlayerHealth.playerHealth -= 20;
        }
    }
}
