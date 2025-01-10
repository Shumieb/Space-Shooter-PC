using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDestroy : MonoBehaviour
{

    private PlayerHealth playerHealthScript;

    void Start()
    {
        playerHealthScript = GetComponent<PlayerHealth>();        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.tag == "EnemyBullet")
        {
            // destroy enemy bullet
            Destroy(collision.gameObject);

            // reduce player health
            if (playerHealthScript.getPlayerHealth() > 0)
            {
                playerHealthScript.reducePlayerHealth(1);
            }

            // destroy player when health if 0
            if (playerHealthScript.getPlayerHealth() <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
