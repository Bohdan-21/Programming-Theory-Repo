using UnityEngine;

public class Capsule : Shape
{
    private void Start()
    {
        message = "Click on Capsule";
    }

    public override void DisplayText()
    {
        MessageText.Instance.DispayMessage(message);
    }
}
