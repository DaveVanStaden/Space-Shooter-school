using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRotate : MonoBehaviour {

    [SerializeField]
    private float _speed;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        //Rotate ship
        Quaternion rot = transform.rotation;
        float z = rot.eulerAngles.z;
        rot = Quaternion.Euler(0, 0, z);
        transform.rotation = rot;

        Vector3 pos = transform.position;
        Vector3 velocity = new Vector3(0, 1 * _speed * Time.deltaTime);

        // Vector3 test = new Vector3(x, y);
        pos += rot * velocity;
        transform.position = pos;
    }
}
