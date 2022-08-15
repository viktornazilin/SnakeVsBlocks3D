using UnityEngine;
using TMPro;

public class LevelNumber : MonoBehaviour
{
    public ButtonHandler ButtonHandler;
    public TMP_Text text;

    void Start()
    {
        text.text = (ButtonHandler.NextScene - 1).ToString();
    }
}
