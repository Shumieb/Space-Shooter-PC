using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUFODestroy : MonoBehaviour
{

    private EnemyUFOHealth enemyUFOHealthScript;

    private void Start()
    {
        enemyUFOHealthScript = GetComponent<EnemyUFOHealth>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ItemCollector")
        {
            // destroy enemy UFO
            Destroy(gameObject);

        }
        else if (collision.tag == "PlayerBullet")
        {
            // destroy player bullet
            Destroy(collision.gameObject);

            // reduce enemy UFO health
            if (enemyUFOHealthScript.getEnemyUFOHealth() > 0)
            {
                enemyUFOHealthScript.reduceEnemyUFOHealth(1);
            }

            // destroy enemy UFO when health if 0
            if (enemyUFOHealthScript.getEnemyUFOHealth() <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
