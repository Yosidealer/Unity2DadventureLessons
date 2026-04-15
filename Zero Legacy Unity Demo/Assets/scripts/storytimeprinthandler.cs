using TMPro;
using UnityEngine;

public class storytimeprinthandler : MonoBehaviour
{
    public TextMeshProUGUI text;
    public int storyTime;

    void Update()
    {
        text.text = "Time: " + GameplayHandler.storytime;
    }
}