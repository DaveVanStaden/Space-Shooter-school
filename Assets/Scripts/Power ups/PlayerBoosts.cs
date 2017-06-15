using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBoosts : MonoBehaviour {
    public Sprite player;

    private SpriteRenderer spriteRenderer;

    //Floats
    float speedTimer;
    float attackTimer;
    float healthTimer;
    //Booleans
    bool speedTimerOn;
    bool attackTimerOn;
    bool healthTimerOn;

    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();

        if (spriteRenderer.sprite == null) {
            spriteRenderer.sprite = player;
        }
    }

    void OnTriggerEnter2D(Collider2D coll) {
        if (coll.gameObject.tag == "SpeedBoost") {
            speedTimerOn = true;
           
        }

        if (coll.gameObject.tag == "AttackBoost") {
            attackTimerOn = true;
            
        }

        if(coll.gameObject.tag == "HealthBoost") {
            healthTimerOn = true;
        }
    }
    void Update() {
        //Speed boost
        if (speedTimerOn == true) {
            speedTimer += 1.0F * Time.deltaTime;

            if (speedTimer >= 6f) {
                gameObject.GetComponent<PlayerMovementV2>().maxSpeed = 3.5f;
                speedTimerOn = false;
                speedTimer = 0f;

                if(attackTimer == 0f && healthTimer == 0f) {
                    spriteRenderer.sprite = player;

                }
            }
        }
        //Attack boost
        if (attackTimerOn == true) {
            attackTimer += 1.0F * Time.deltaTime;

            if (attackTimer >= 6f) {
                gameObject.GetComponent<PlayerShoot>().projectileDamage = 20f;
                attackTimerOn = false;
                attackTimer = 0f;

                if (healthTimer == 0f && speedTimer == 0) {
                    spriteRenderer.sprite = player;
                }
            }
        }
        //Health boost
        if(healthTimerOn == true) {
            healthTimer += 1.0f * Time.deltaTime;

            if (healthTimer >= 6f && healthTimer <= 6.5f) {
                PlayerHealth.playerHealth = 60f;
                healthTimerOn = false;
                healthTimer = 0f;

                if (speedTimer == 0f && attackTimer == 0f) {
                    spriteRenderer.sprite = player;

                }
            }
        }
    }
}

