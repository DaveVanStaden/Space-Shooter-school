using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorMovement : MonoBehaviour {
    public Vector2 velocity;
    public Rigidbody2D rb2D;
    void Start() {
        rb2D = GetComponent<Rigidbody2D>();
        
    }
    void FixedUpdate() {
        rb2D.MovePosition(rb2D.position + velocity * Time.fixedDeltaTime);
    }
}
