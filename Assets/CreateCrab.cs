using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCrab : MonoBehaviour
{
    public GameObject crab;
    void Start()
    {
        InvokeRepeating("create", 0, 1f);
    }

   void create()
   {
        Vector3 position = Vector3.zero;
        switch(Random.Range(0,4)) //randomly pick a side, then spawn a cherry at a random spot along that axis
        {
            case 0: //top
                position = new Vector3(Random.Range(-Camera.main.orthographicSize * Camera.main.aspect, Camera.main.orthographicSize * Camera.main.aspect), (Camera.main.orthographicSize * Camera.main.aspect)/2);
                break;
            case 1: //bottom
                position = new Vector3(Random.Range(-Camera.main.orthographicSize * Camera.main.aspect, Camera.main.orthographicSize * Camera.main.aspect), -(Camera.main.orthographicSize * Camera.main.aspect)/2);
                break;
            case 2: //left
                position = new Vector3(-Camera.main.orthographicSize * Camera.main.aspect, Random.Range(-(Camera.main.orthographicSize * Camera.main.aspect)/2, (Camera.main.orthographicSize * Camera.main.aspect)/2));
                break;
            case 3: //right
                position = new Vector3(Camera.main.orthographicSize * Camera.main.aspect, Random.Range(-(Camera.main.orthographicSize * Camera.main.aspect)/2, (Camera.main.orthographicSize * Camera.main.aspect)/2));
                break;
        }
        Instantiate(crab, position, Quaternion.identity); 

   }
}
