using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShipBulletDestroy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ItemCollector")
        {
            Destroy(gameObject);
        }

        if (collision.tag == "PlayerBullet")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
