using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUFOHealth : MonoBehaviour
{
    [SerializeField]
    private int health = 5;

    public void reduceEnemyUFOHealth(int healthToReduce)
    {
        if (health > 0)
        { health = health - healthToReduce; }
    }

    public int getEnemyUFOHealth()
    {
        return health;
    }
}
