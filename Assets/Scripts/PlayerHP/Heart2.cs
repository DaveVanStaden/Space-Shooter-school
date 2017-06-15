using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart2 : MonoBehaviour
{
    void Update()
    {
        if (PlayerHealth.playerHealth < 40)
        {
            Destroy(gameObject);
        }
    }
}