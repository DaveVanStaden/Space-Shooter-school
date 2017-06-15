using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    public float bulletDamage = 20f;

    [SerializeField]
    private float _speed;

    private Rigidbody2D _rigidbody;

    public float timer;

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
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


        //TIMER
        timer += 1.0F * Time.deltaTime;

        if (timer >= 2)
        {
            GameObject.Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag == "Meteor") {
            Debug.Log(bulletDamage);
            coll.gameObject.GetComponent<MeteorHealth>().meteorHealth -= bulletDamage;
            GameObject.Destroy(gameObject);
        }

        if (coll.gameObject.tag == "Enemy") {
            Destroy(coll.gameObject);
            GameObject.Destroy(gameObject);
        }

    }

}
