using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaStretch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, (Camera.main.orthographicSize / 2) * 0.75f, transform.position.z);
        transform.localScale = new Vector3(Camera.main.orthographicSize * Camera.main.aspect * 2, Camera.main.orthographicSize * 1.4f, 1);
    }
}
