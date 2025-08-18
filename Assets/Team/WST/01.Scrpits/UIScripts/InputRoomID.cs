using TMPro;
using UnityEngine;

public class InputRoomID : MonoBehaviour
{
    [SerializeField] private TMP_InputField roomID;
    [SerializeField] private TextMeshProUGUI displayText;
    public string room { get; private set; }

    public void OnConfirmBTN()
    {
        room = roomID.text;

        if (room == null)
        {
            displayText.text = "Please input words";
        }
        else
        {
            displayText.text = "";
        }

        Debug.Log(room);
    }
}
