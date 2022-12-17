using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<GameObject> enemyList;
    public float enemySpawnIntervalMax = 7f;
    public float enemySpawnIntervalMin = 1f;
    public float enemySpawnIntervalModifier = -0.1f;

    private float spawnTimer = 0f;
    private float currentInterval;

    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = enemySpawnIntervalMax;
        currentInterval = enemySpawnIntervalMax;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0f)
        {
            // Spawn an enemy
            Instantiate(enemyList[0]);
            Debug.Log("Spawn");

            // Reset the timer
            currentInterval = Mathf.Max(currentInterval - enemySpawnIntervalModifier, enemySpawnIntervalMin);
            spawnTimer = currentInterval;
        }
    }
}
