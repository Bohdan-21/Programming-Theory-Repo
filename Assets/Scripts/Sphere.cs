using UnityEngine;

public class Sphere : Shape
{
    private void Start()
    {
        message = "Click on Sphere";
    }

    public override void DisplayText()
    {
        MessageText.Instance.DispayMessage(message);
    }
}
