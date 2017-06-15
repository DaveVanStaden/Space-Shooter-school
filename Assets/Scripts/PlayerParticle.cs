using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerParticle : MonoBehaviour {
    public ParticleSystem blue;
    public bool play;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (play) {
            blue.enableEmission = true;
        }else if (!play) {
            blue.enableEmission = false;
        }
	}
}
