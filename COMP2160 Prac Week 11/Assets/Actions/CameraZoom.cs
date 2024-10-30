using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraZoom : MonoBehaviour
{

    public InputActionReference zoomAction;
    public float zoomSpeed = 2f;
    public float minOrthographicSize = 5f;
    public float maxOrthographicSize = 20f;
    public float minFieldOfView = 30f;
    public float maxFieldOfView = 70f;

    private Camera mainCamera;

    private void Awake()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        float zoomValue = zoomAction.action.ReadValue<float>();

        if (mainCamera.orthographic)
        {
            mainCamera.orthographicSize -= zoomValue * zoomSpeed * Time.deltaTime;
            mainCamera.orthographicSize = Mathf.Clamp(mainCamera.orthographicSize, minOrthographicSize, maxOrthographicSize);
        }
        else
        {
            mainCamera.fieldOfView -= zoomValue * zoomSpeed * Time.deltaTime;
            mainCamera.fieldOfView = Mathf.Clamp(mainCamera.fieldOfView, minFieldOfView, maxFieldOfView);
        }
    }
}
