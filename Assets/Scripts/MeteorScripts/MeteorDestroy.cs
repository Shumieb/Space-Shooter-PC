using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorDestroy : MonoBehaviour
{

    private MeteorHealth meteorHealthscript;

    private void Start()
    {
        meteorHealthscript = GetComponent<MeteorHealth>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ItemCollector")
        {
            // destroy meteor
            Destroy(gameObject);

        }
        else if (collision.tag == "PlayerBullet")
        {
            // destroy player bullet
            Destroy(collision.gameObject);

            // reduce meteor health
            if (meteorHealthscript.getMeteorHealth() > 0)
            {
                meteorHealthscript.reduceMeteorHealth(1);
            }

            // destroy meteor when health if 0
            if (meteorHealthscript.getMeteorHealth() <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
