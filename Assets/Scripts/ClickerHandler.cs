using UnityEngine;

public class ClickerHandler : MonoBehaviour
{
    [SerializeField] Camera _camera;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Shape shape = hit.collider.gameObject.GetComponent<Shape>();

                if (shape != null)
                    shape.DisplayText();
            }
        }
    }
}
