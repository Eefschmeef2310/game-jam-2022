using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<GameObject> enemyList;
    public AnimationCurve curve;
    private float spawnTimer = 0f;

    void Start()
    {
        Invoke("spawn", curve.Evaluate(spawnTimer));
    }

    void spawn()
    {
        Instantiate(enemyList[Random.Range(0, enemyList.Count)]);
        Invoke("spawn", curve.Evaluate(spawnTimer));
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;
    }
}
