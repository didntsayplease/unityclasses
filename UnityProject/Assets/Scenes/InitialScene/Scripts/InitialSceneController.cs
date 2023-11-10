using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InitialSceneController : MonoBehaviour
{
    private GameInput gameInput;

    void Start()
    {
        gameInput.Playerinmenu.Start.performed += context => OnStartPressed(context);
    }

    private void OnStartPressed(InputAction.CallbackContext context)
    {
        Debug.Log("OnStartPressed");
    }

    private void OnEnable()
    {
        gameInput = new GameInput();
        gameInput.Enable();
    }

    private void OnDisable()
    {
        gameInput.Disable();
    }
}
