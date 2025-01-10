using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShipDestroy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ItemCollector")
        {
            Destroy(gameObject);
        }
    }
}
