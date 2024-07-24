using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    [SerializeField] Renderer _renderer;
    protected string message;

    public string Name { get => gameObject.name; set => gameObject.name = value; }

    public Color ShapeColor 
    { 
        get => _renderer.material.color;
        set 
        {
            _renderer.material = new Material(_renderer.material);
            _renderer.material.color = value;
        }
    }

    public abstract void DisplayText();
}
