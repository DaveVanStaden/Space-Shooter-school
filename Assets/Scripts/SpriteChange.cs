using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChange : MonoBehaviour {

    public Sprite player;
    public Sprite speedPlayer;
    public Sprite attackPlayer;
    public Sprite healthPlayer;

    private SpriteRenderer spriteRenderer;

    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    
        if (spriteRenderer.sprite == null) {
            spriteRenderer.sprite = player;
        }
    }

    void OnTriggerEnter2D(Collider2D coll) {
        
        if (coll.gameObject.tag == "SpeedBoost") {
            spriteRenderer.sprite = speedPlayer;
        }

        if (coll.gameObject.tag == "AttackBoost") {
            spriteRenderer.sprite = attackPlayer;
        }

        if (coll.gameObject.tag == "HealthBoost") {
            spriteRenderer.sprite = healthPlayer;
        }

    }
}