using UnityEngine;

public class Interactable : MonoBehaviour
{
    [SerializeField] private Material lightOnMaterial;

    private Renderer _renderer;

    private void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    public void Interact()
    {
        _renderer.material = lightOnMaterial;
    }
}
