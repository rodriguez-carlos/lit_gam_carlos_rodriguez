using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public float xAxisSensitivity;
    public float yAxisSensitivity;

    public Transform playerOrientation;
    public Transform cameraHolder;

    float xRotation;
    float yRotation;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float xAxisMouse = Input.GetAxisRaw("Mouse X") * Time.deltaTime * xAxisSensitivity;
        float yAxisMouse = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * yAxisSensitivity;

        yRotation += xAxisMouse;

        xRotation -= yAxisMouse;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        cameraHolder.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        playerOrientation.rotation = Quaternion.Euler(0, yRotation, 0);


    }
}
