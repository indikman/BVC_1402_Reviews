using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactor : MonoBehaviour
{
    [SerializeField] private InputManager inputManager;
    
    private Interactable _interactable;

    private void OnEnable()
    {
        inputManager.OnInteract += Interact;
    }

    private void Interact()
    {
        if (_interactable != null)
        {
            _interactable.Interact();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        _interactable = other.GetComponent<Interactable>();
        
    }

    private void OnTriggerExit(Collider other)
    {
        _interactable = null;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
