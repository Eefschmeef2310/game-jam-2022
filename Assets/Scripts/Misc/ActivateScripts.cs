using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateScripts : MonoBehaviour
{
    public CreateTrash trash;
    public EnemySpawner spawner;
    public ScoreManager scoreManager;
    public LifeManager life;
    public spawnWave spawnWave;
    void Start()
    {
        trash.enabled = true;
        spawner.enabled = true;
        scoreManager.enabled = true;
        life.enabled = true;
        spawnWave.enabled = true;
    }
}
