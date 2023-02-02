using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisitorController : MonoBehaviour

{
    [SerializeField] float _mouseSensitivity = 100f;

    [SerializeField] CameraLook _cameraLook;
    [SerializeField] VisitorMovement _playerMovement;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * _mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * _mouseSensitivity * Time.deltaTime;

        _cameraLook.UpdateLook(mouseX, mouseY);

        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        _playerMovement.Move(moveX, moveZ);
    }
}
