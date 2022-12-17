using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateTrash : MonoBehaviour
{
    public GameObject trash;
    public GameObject buoy;
    public GameObject sea;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Create", 0, 1);
    }

    void Create()
    {
        GameObject prefab;
        if (Random.Range(0,10) == 0)
        {
            prefab = buoy;
        }
        else
        {
            prefab = trash;
        }

        Instantiate(prefab, new Vector3(
            Camera.main.orthographicSize * Camera.main.aspect +10, 
            Random.Range(-Camera.main.orthographicSize + 1, sea.transform.position.y), 0), 
            Quaternion.identity);
    }
}
