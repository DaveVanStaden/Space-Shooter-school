using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerOutWorld : MonoBehaviour {

    
    public GameObject menu;
    private bool timedDead = false;
    private int i = 0;
    
	void Start ()
    {
        Debug.Log(menu);
    }

	// Update is called once per frame
	void Update () {

        Vector3 pos = transform.position;

        transform.position = pos;


        if (pos.y >= 9 || pos.y <= -9 || pos.x >= 16 || pos.x <= -16)
        {
            menu.SetActive(true);
            timedDead = true;
        }
        else if (pos.y < 9 || pos.y > -9 || pos.x < 16 || pos.x > -16)
        {
            menu.SetActive(false);
            timedDead = false;
        }

        Debug.Log(pos);

        //Timer TO DEAD
        if(timedDead == true)
        {
            i += 1;
        }
        if(i == 300)
        {
            timedDead = false;
            i = 0;
            PlayerHealth.playerHealth = 0f;
        }

    }
}
