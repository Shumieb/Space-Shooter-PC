using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShipShooting : MonoBehaviour
{

    [SerializeField]
    private GameObject bulletPrefab;

    [SerializeField]
    private GameObject shootingPoint;

    [SerializeField]
    private float waitTime = 5f;
    [SerializeField]
    private float timeSinceLastShot = 0f;

   void Update()
    {
        timeSinceLastShot ++;

        if (timeSinceLastShot == waitTime)
        {
            Instantiate(bulletPrefab, shootingPoint.transform.position, Quaternion.identity);
            timeSinceLastShot = 0f;
        }
        
    }
}
