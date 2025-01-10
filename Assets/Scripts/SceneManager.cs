using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    [SerializeField]
    private int maxNumOfEnemyShips = 5;

    [SerializeField]
    private int numOfEnemyShips;

    [SerializeField]
    private int maxNumOfEnemyUFOShips = 5;

    [SerializeField]
    private int numOfEnemyUFOShips;

    [SerializeField]
    private int maxNumOfMeteors = 5;

    [SerializeField]
    private int numOfMeteors;

   public int getMaxNumOfEnemyShips()
    {
        return maxNumOfEnemyShips;
    }

    public int getNumOfEnemyShips()
    {
        return numOfEnemyShips;
    }

    public void updateNumOfEnemyShips(int numToAdd)
    {
        numOfEnemyShips += numToAdd;
    }

    public int getMaxNumOfUFOShips()
    {
        return maxNumOfEnemyUFOShips;
    }

    public int getNumOfUFOShips()
    {
        return numOfEnemyUFOShips;
    }

    public void updateNumOfUFOShips(int numToAdd)
    {
        numOfEnemyUFOShips += numToAdd;
    }

    public int getMaxNumOfMeteors()
    {
        return maxNumOfMeteors;
    }

    public int getNumOfMeteors()
    {
        return numOfMeteors;
    }

    public void updateNumOfMeteors(int numToAdd)
    {
        numOfMeteors += numToAdd;
    }


}
