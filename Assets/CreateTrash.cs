using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateTrash : MonoBehaviour
{
    public GameObject trash;
    public float borderWidth = 1;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Create", 0, 1);
    }

    void Create()
    {
        Instantiate(trash, new Vector3(
            Random.Range(-Camera.main.orthographicSize * Camera.main.aspect + borderWidth, Camera.main.orthographicSize * Camera.main.aspect - borderWidth), 
            Random.Range(-Camera.main.orthographicSize + borderWidth, Camera.main.orthographicSize - borderWidth), 0), 
            Quaternion.identity);
    }
}
