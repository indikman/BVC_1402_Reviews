using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public event Action OnInteract;

    private PlayerInput _playerInput;
    
    void OnEnable()
    {
        _playerInput = new PlayerInput();
        _playerInput.Player.Interact.performed += ctx =>
        {
            OnInteract?.Invoke();
        };
        _playerInput.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
