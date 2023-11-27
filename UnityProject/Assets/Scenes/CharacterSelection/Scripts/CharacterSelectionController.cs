using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterSelectionController : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> characters = new List<GameObject>();

    private GameInput gameInput;

    void Start()
    {
        gameInput.Playerinmenu.Directions.performed += context => OnDirectionsPressed(context);
    }

    private void OnDirectionsPressed(InputAction.CallbackContext context)
    {
        var direction = context.ReadValue<Vector2>();

        Debug.Log("X: "+direction.x + " y: "+ direction.y);
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
