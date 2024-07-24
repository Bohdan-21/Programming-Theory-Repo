using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShapeInfo : MonoBehaviour
{
    public static ShapeInfo Instance { get; private set; }

    [SerializeField] private TMP_InputField _nameField;
    
    [SerializeField] private TMP_InputField _rValueField;
    [SerializeField] private TMP_InputField _gValueField;
    [SerializeField] private TMP_InputField _bValueField;

    [SerializeField] private TextMeshProUGUI _shapeName;

    [SerializeField] private Image _colorShape;

    [SerializeField] private Shape _selectedShape;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void SetSelectedShape(Shape shape)
    {
        _selectedShape = shape;
        
        UpdateInfo();
    }

    public void ChangeShapeName()
    {
        if (_selectedShape == null)
            return;

        SetNewShapeName();
    }

    public void ChangeShapeColor()
    {
        if (_selectedShape == null)
            return;

        SetNewShapeColor();
    }


    private void UpdateInfo()
    {
        _shapeName.text = _selectedShape.name;

        Color color = _selectedShape.GetComponent<MeshRenderer>().material.color;

        _colorShape.color = color;
    }


    private void SetNewShapeName()
    {
        _selectedShape.Name = _nameField.text;

        UpdateInfo();

        _nameField.text = "";
    }

    private void SetNewShapeColor()
    {
        int.TryParse(_rValueField.text, out int r);
        int.TryParse(_gValueField.text, out int g);
        int.TryParse(_bValueField.text, out int b);

        Renderer shapeRenderer = _selectedShape.GetComponent<Renderer>();

        shapeRenderer.material = new Material(shapeRenderer.material);

        shapeRenderer.material.color = new Color(r, g, b);

        UpdateInfo();

        _rValueField.text = _gValueField.text = _bValueField.text = "";
    }
}
