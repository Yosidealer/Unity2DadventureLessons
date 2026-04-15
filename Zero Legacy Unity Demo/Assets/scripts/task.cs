using UnityEngine;

public class task : MonoBehaviour
{
    public bool done = false;

    void OnMouseDown()
    {
        if (!done)
        {
            GetComponent<AudioSource>().Play();
            done = true;
        }
    }
}