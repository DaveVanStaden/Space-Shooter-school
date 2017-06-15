using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerTimer : MonoBehaviour {

    int playerTimer;
    int defaultTimer = 4500;

    private Text timerText;

    private void Awake()
    {
        timerText = GameObject.Find("Text").GetComponent<Text>();
    }

    // Use this for initialization
    void Start () {
        playerTimer = defaultTimer;
    }
	
	// Update is called once per frame
	void Update () {

        playerTimer = playerTimer - 1;

        //TIME LEFT
        timerText.text = "Time Left: " + playerTimer;

        if (playerTimer <= 0)
        {
            SceneManager.LoadScene("winScreen");
            Debug.Log("TIMER 0");
        }
	}
}
