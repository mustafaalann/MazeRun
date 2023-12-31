using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingingControl : MonoBehaviour
{
    public Transform pivotPoint;
    
    public float rotationSpeed = 50f;

    public bool turnClockwise = true;

    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(transform.rotation.x > 0.3f){
            turnClockwise = false;
            audioSource.Play();
        }

        if(transform.rotation.x < -0.3f){
            turnClockwise = true;
            audioSource.Play();

        }
        // Ensure the pivot point is not null before attempting to rotate
        if (pivotPoint != null)
        {
            // Calculate the direction vector from the pivot to the object
            Vector3 pivotToObject = transform.position - pivotPoint.position;

            if(turnClockwise == true){
                transform.RotateAround(pivotPoint.position, Vector3.right, rotationSpeed * Time.deltaTime);
            }
            else{
                transform.RotateAround(pivotPoint.position, Vector3.left, rotationSpeed * Time.deltaTime);
            }
            
        }
    }
}
