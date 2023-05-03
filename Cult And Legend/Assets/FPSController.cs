using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSController : MonoBehaviour
{


    public float speed = 5.0f;
    public float sensitivity = 5.0f;
    public float jumpSpeed = 5.0f;
    public float gravity = -9.81f;

    private CharacterController controller;
    private float verticalRotation = 0.0f;
    private Vector3 velocity = Vector3.zero;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // Calculate horizontal movement
        float horizontal = Input.GetAxis("Horizontal") * speed;
        float vertical = Input.GetAxis("Vertical") * speed;
        Vector3 movement = new Vector3(horizontal, 0, vertical);

        // Apply gravity
        if (controller.isGrounded)
        {
            velocity.y = 0;
            if (Input.GetButtonDown("Jump"))
            {
                velocity.y = jumpSpeed;
            }
        }
        velocity.y += gravity * Time.deltaTime;

        // Calculate vertical rotation
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        transform.Rotate(0, mouseX, 0);
        verticalRotation -= Input.GetAxis("Mouse Y") * sensitivity;
        verticalRotation = Mathf.Clamp(verticalRotation, -90, 90);
        Camera.main.transform.localRotation = Quaternion.Euler(verticalRotation, 0, 0);

        // Apply movement
        movement = transform.rotation * movement;
        controller.Move(movement * Time.deltaTime + velocity * Time.deltaTime);
    }


}
