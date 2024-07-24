using UnityEngine;

public class Cube : Shape
{
    private void Start()
    {
        message = "Click on Cube";
    }

    public override void DisplayText()
    {
        MessageText.Instance.DispayMessage(message);
    }
}
