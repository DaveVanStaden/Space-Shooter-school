using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart3 : MonoBehaviour
{
    
    void Update()
    {
        if (PlayerHealth.playerHealth < 60)
        {
            Destroy(gameObject);
        }
    }
}