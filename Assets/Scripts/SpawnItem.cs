using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{

    [SerializeField]
    private GameObject enemyShipPrefab;
    [SerializeField]
    private GameObject enemyUFOPrefab;
    [SerializeField]
    private GameObject meteorPrefab;

    [SerializeField]
    private int randomSelected = 1;

    [SerializeField]
    private float waitTime = 15f;
    [SerializeField]
    private float timeSinceLastSpawn;

    private SceneManager sceneManager;

    void Start()
    {
        sceneManager = FindAnyObjectByType<SceneManager>();
    }

    void Update()
    {
        timeSinceLastSpawn++;

        if (timeSinceLastSpawn >= waitTime)
        {

            randomSelected = Random.Range(1, 4);

            if (randomSelected == 1 && sceneManager.getNumOfEnemyShips() < sceneManager.getMaxNumOfEnemyShips())
            {
                Instantiate(enemyShipPrefab, transform.position, Quaternion.identity);
                sceneManager.updateNumOfEnemyShips(1);
            }
            else if (randomSelected == 2 && sceneManager.getNumOfUFOShips() < sceneManager.getMaxNumOfUFOShips())
            {
                Instantiate(enemyUFOPrefab, transform.position, Quaternion.identity);
                sceneManager.updateNumOfUFOShips(1);
            }
            else if(randomSelected == 3 && sceneManager.getNumOfMeteors() < sceneManager.getMaxNumOfMeteors())
            {
                Instantiate(meteorPrefab, transform.position, Quaternion.identity);
                sceneManager.updateNumOfMeteors(1);
            }

            timeSinceLastSpawn = 0; 
        }
    }
}
