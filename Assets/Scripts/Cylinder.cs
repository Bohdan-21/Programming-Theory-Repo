using UnityEngine;

public class Cylinder : Shape
{
    private void Start()
    {
        message = "Click on Cylinder";
    }

    public override void DisplayText()
    {
        MessageText.Instance.DispayMessage(message);
    }
}
