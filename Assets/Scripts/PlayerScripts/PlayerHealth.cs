using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    private int health = 5;

    public void reducePlayerHealth(int healthToReduce)
    {
        if (health > 0) { health = health - healthToReduce; }
    }

    public int getPlayerHealth()
    {
        return health;
    }
}
