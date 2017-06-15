using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

    private int i = 9;

    public float projectileDamage;
    public Rigidbody2D Projectile;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            i += 1;
            if(i > 10)
            {
                Shoot();
                i = 0;
            }
        }
    }

    public void Shoot()
    {
        Rigidbody2D projectileClone = (Rigidbody2D)Instantiate(Projectile, transform.position, transform.rotation);
        projectileClone.GetComponent<Projectile>().bulletDamage = projectileDamage;
    }

}
