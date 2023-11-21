using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaBallCreator : MonoBehaviour
{
    public GameObject lavaBallPrefab;  
    public float seconds = 2f;

    void Start()
    {
        InvokeRepeating("SpawnLavaBall", 0f, seconds);
    }

    void SpawnLavaBall()
    {
        Instantiate(lavaBallPrefab, transform.position, transform.rotation);
    }

    
}
