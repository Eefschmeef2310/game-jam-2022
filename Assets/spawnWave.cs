using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnWave : MonoBehaviour
{
    public GameObject wave;
    public GameObject sea;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("create", Random.Range(1, 4));
    }

    void create()
    {
        Instantiate(wave, new Vector3(
            Camera.main.orthographicSize * Camera.main.aspect +10, 
            Random.Range(-Camera.main.orthographicSize + 1, sea.transform.position.y), 0), 
            new Quaternion(0,180,0,0));
        Invoke("create", Random.Range(1, 4));
    }
}
