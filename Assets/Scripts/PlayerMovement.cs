using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed;

    public Transform playerOrientation;

    Vector3 movementDirection;

    float horizontalInput;
    float verticalInput;

    Rigidbody rb;

    public float groundDrag;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    void Update()
    {
        MyInput();
        rb.drag = groundDrag;
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }
    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }

    private void MovePlayer()
    {
        movementDirection = playerOrientation.forward * verticalInput + playerOrientation.right * horizontalInput;

        rb.AddForce(movementDirection.normalized * movementSpeed * 10f, ForceMode.Force);
    }
}
