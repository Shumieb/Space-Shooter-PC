using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorHealth : MonoBehaviour
{
    [SerializeField]
    private int health = 5;

    public void reduceMeteorHealth(int healthToReduce)
    {
        if (health > 0)
        { health = health - healthToReduce; }
    }

    public int getMeteorHealth()
    {
        return health;
    }
}
