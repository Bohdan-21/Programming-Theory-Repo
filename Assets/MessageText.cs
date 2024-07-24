using UnityEngine;
using TMPro;

public class MessageText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _messageText;

    public static MessageText Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void DispayMessage(string message)
    {
        _messageText.text = message;
    }
}
