using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShipHealth : MonoBehaviour
{

    [SerializeField]
    private int health = 5;

    public void reduceEnemyShipHealth(int healthToReduce)
    {
        if (health > 0)
        { health = health - healthToReduce; }
    }

    public int getEnemyShipHealth()
    {
        return health;
    }
}
