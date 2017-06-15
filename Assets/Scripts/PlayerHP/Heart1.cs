using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart1 : MonoBehaviour {

	void Update () {
		if (PlayerHealth.playerHealth < 20)
        {
            Destroy(gameObject);
        }
	}
}
