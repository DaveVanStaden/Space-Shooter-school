using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorHealth : MonoBehaviour {
    public float meteorHealth = 40f;
    private float timer;

    private void OnTriggerStay(Collider col)
    {

    }




    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag == "Player") {
            Debug.Log("Hit");
            //Destroy(coll.gameObject);
          
        }
    }

    void Update(){
        if (meteorHealth < 1f) {
            GameObject.Destroy(gameObject);
        }
     }

    void FixedUpdate() {
        timer += 1.0F * Time.deltaTime;

        if (timer >= 20) {
            GameObject.Destroy(gameObject);
        }
    }
    
}
