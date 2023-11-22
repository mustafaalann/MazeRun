using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    private Vector3 moveDirection = Vector3.zero;
    private CharacterController controller;
    private Transform playerCamera;
    private Vector3 cameraOriginalPosition;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        // let the gameObject fall down
        gameObject.transform.position = new Vector3(5, 4, 5);

        playerCamera = Camera.main.transform;
        cameraOriginalPosition = playerCamera.localPosition;
    }

    void Update()
    {


        if (controller.isGrounded)
        {

            float walkingEffect = Mathf.Sin(Time.time*5) * 0.1f;
            playerCamera.localPosition = new Vector3(cameraOriginalPosition.x, cameraOriginalPosition.y + walkingEffect, cameraOriginalPosition.z);

            // We are grounded, so recalculate
            // move direction directly from axes

            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection = moveDirection * speed;

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }

        // Apply gravity
        moveDirection.y = moveDirection.y - (gravity * Time.deltaTime);

        // Move the controller
        controller.Move(moveDirection * Time.deltaTime);
    }

    
}
