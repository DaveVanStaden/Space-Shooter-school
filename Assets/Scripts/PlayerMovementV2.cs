using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementV2 : MonoBehaviour {

    public Transform player;
    public float maxSpeed = 3.5f;
    float rotSpeed = 180f;
    public static bool movement = true;
	
    void Start ()
    {
        movement = true;
    }

	// Update is called once per frame
	void Update () {

        //Rotate ship
        Quaternion rot = transform.rotation;
        float z = rot.eulerAngles.z;
        z -= Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        rot = Quaternion.Euler( 0, 0, z);
        transform.rotation = rot;


        //Move Ship
        if (movement == true)
        {
            Vector3 pos = transform.position;
            Vector3 velocity = new Vector3(0, Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime);

            pos += rot * velocity;

            transform.position = pos;
        }
	}
}
