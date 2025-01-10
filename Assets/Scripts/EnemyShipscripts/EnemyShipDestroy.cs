using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShipDestroy : MonoBehaviour
{
    [SerializeField]
    private EnemyShipHealth enemyHealthScripts;

    private void Start()
    {
        enemyHealthScripts = GetComponent<EnemyShipHealth>();
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
            if(enemyHealthScripts.getEnemyShipHealth() > 0)
            {
                enemyHealthScripts.reduceEnemyShipHealth(1);
            }

            // destroy enemy ship when health if 0
            if(enemyHealthScripts.getEnemyShipHealth() <=0)
            {
                Destroy(gameObject);
            }
        }
    }
}
