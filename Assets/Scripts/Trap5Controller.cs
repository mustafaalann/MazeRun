using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap5Controller : MonoBehaviour
{
    public GameObject trap1;
    public GameObject trap2;
    public GameObject trap3;

    public GameObject trapWall;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            trap1.SetActive(true);

            trap2.SetActive(true);
        
            trap3.SetActive(true);

            trapWall.SetActive(true);
        }

    }


    
}
