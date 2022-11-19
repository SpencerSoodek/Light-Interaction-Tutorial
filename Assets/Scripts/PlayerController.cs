using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Camera camera;

    private Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GetComponent<Transform>();
        camera = FindObjectOfType<Camera>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Transform cameraTransform = camera.transform;
        playerTransform.rotation = cameraTransform.rotation;

    }

    private void OnApplicationFocus(bool hasFocus)
    {
        if (hasFocus)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
