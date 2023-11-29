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
    private int characterSelected = 0;

    private Color selectedColor = new Color(1, 1, 1);
    private Color notSelectedColor = new Color(94f / 255f, 94f / 255f, 94f / 255f);

    void Start()
    {
        gameInput.Playerinmenu.Directions.performed += context => OnDirectionsPressed(context);

        SetupCharactersColors();
    }

    private void SetupCharactersColors()
    {
        foreach (var gameCharacter in characters)
        {
            SetGameCharacterColor(gameCharacter, notSelectedColor);
        }
        SelectCharacter(0);
    }

    private void OnDirectionsPressed(InputAction.CallbackContext context)
    {
        var direction = context.ReadValue<Vector2>();

        Debug.Log("X: "+direction.x + " y: "+ direction.y);

        if (direction.x > 0 && characterSelected != 1)
        {
            SelectCharacter(1);
        }
        else if (direction.x < 0 && characterSelected != 0)
        {
            SelectCharacter(0);
        }
    }

    private void SelectCharacter(int characterSelected)
    {
        this.characterSelected = characterSelected;

        var character = characters[characterSelected];

        foreach(var gameCharacter in characters)
        {
            SetGameCharacterColor(gameCharacter, notSelectedColor);
        }

        SetGameCharacterColor(character, selectedColor);
    }

    private void SetGameCharacterColor(GameObject gameCharacter, Color color)
    {
        var spriteRenderer = gameCharacter.GetComponent<SpriteRenderer>();

        if(spriteRenderer != null)
        {
            spriteRenderer.color = color;
        }
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
