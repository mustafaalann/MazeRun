using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void returnToBase(){
        gameObject.transform.position = new Vector3(5, 4, 5);
        resetTimer();
    }


    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.collider.CompareTag("obstacle"))
        {
            audioSource.Play();
            returnToBase();
        }
    }

    void resetTimer(){

        GameObject timeManagerObject = GameObject.Find("TimeManager");

        TimeManager timeManagerScript = timeManagerObject.GetComponent<TimeManager>();
        
        timeManagerScript.ResetTimer();
        
    }
}
