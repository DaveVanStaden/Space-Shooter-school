using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {

    public static float playerHealth = 60f;
    public Animator anim;
    bool startTimer;
    int i;
    int defaulti;

    void Start()
    {
        playerHealth = 60f;
        anim = GetComponent<Animator>();
        startTimer = false;
        defaulti = 100;
        i = defaulti;
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Meteor")
        {
            Debug.Log("Hit");
            playerHealth -= 20f;
        }
    }

    void Update() {
        //HEALTH LOWER THEN 0
        if (playerHealth <= 0)
        {
            anim.SetTrigger("Health");
            startTimer = true;
            PlayerMovementV2.movement = false;
            gameObject.GetComponent<PlayerParticle>().play = true;
            
        }

        //START TIMER
        if(startTimer == true)
        {
            i = i - 1;
        }

        //IF TIMER COMPLETE
        if (i <= 0)
        {
            SceneManager.LoadScene("DeadScreen");
        }
    }
}


