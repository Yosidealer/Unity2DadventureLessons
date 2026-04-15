using UnityEngine;

public class task : MonoBehaviour
{
    public bool done = false; // whether the task is done or not

    void OnMouseDown()
    {
        if (!done) // if the task is not done, mark it as done and play the sound
        {
            GetComponent<AudioSource>().Play(); // play sound
            done = true; // mark task as done
        }
    }
}