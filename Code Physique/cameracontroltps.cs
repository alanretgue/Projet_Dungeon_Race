using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroltps : MonoBehaviour
{

    // Script à appliqué sur la deuxième caméra afin de changer les angles maximum

    public float sensitivity = 100f;

    public Transform playerBody;

    float xRot = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        xRot -= mouseY;
        xRot = Mathf.Clamp(xRot, -10f, 35f);

        transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
