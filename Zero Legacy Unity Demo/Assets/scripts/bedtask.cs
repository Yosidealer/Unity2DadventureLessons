using UnityEngine;
using UnityEngine.SceneManagement;

public class Bed : MonoBehaviour
{
    public TaskManager manager; // reference to task manager

    void OnMouseDown()
    {
        if (manager.allDone) // if all tasks are done, sleep and go to next scene
        {
            Debug.Log("Sleep / next scene");
            GameplayHandler.storytime = 251;
            SceneManager.LoadScene("menu");
        }
    }
}