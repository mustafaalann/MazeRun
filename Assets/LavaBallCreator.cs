using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaBallCreator : MonoBehaviour
{
    public GameObject lavaBallPrefab;  

    void Start()
    {
        InvokeRepeating("SpawnLavaBall", 0f, 2f);
    }

    void SpawnLavaBall()
    {
        Instantiate(lavaBallPrefab, transform.position, transform.rotation);
    }

    
}
