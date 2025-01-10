using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShipDestroy : MonoBehaviour
{

    private EnemyShipHealth enemyShipHealthScripts;

    private void Start()
    {
        enemyShipHealthScripts = GetComponent<EnemyShipHealth>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ItemCollector")
        {
            // destroy enemy ship
            Destroy(gameObject);

        }else if (collision.tag == "PlayerBullet")
        {
            // destroy player bullet
            Destroy(collision.gameObject);

            // reduce enemy ship health
            if(enemyShipHealthScripts.getEnemyShipHealth() > 0)
            {
                enemyShipHealthScripts.reduceEnemyShipHealth(1);
            }

            // destroy enemy ship when health if 0
            if(enemyShipHealthScripts.getEnemyShipHealth() <=0)
            {
                Destroy(gameObject);
            }
        }
    }
}
