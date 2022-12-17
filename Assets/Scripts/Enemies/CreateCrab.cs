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
        
   }
}
