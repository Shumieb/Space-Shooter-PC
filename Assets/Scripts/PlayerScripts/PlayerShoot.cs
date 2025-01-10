using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletPrefab;

    [SerializeField]
    private GameObject shootingPoint;

    [SerializeField]
    private bool canShoot = true;

    [SerializeField]
    private float waitTime = 5f;

    [SerializeField]
    private float timeSinceLastShot = 0f;

    void Update()
    {
        timeSinceLastShot++;

       if (timeSinceLastShot == waitTime)
        {
            canShoot = true;            
            timeSinceLastShot = 0f;
        }

        if (canShoot)
        {
            if (Input.GetKey(KeyCode.Space)){
                canShoot = false;
                Instantiate(bulletPrefab, shootingPoint.transform.position, Quaternion.identity);
            }
        }
    }
}
