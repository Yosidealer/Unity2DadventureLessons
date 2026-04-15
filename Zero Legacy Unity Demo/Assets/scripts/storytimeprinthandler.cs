using TMPro;
using UnityEngine;

public class storytimeprinthandler : MonoBehaviour
{
    public TextMeshProUGUI text; // reference to the TextMeshProUGUI 

    void Update()
    {
        text.text = "Time: " + GameplayHandler.storytime; // Update the text with the current story time
    }
}