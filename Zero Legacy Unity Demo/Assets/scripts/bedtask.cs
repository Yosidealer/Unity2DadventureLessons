using UnityEngine;
using UnityEngine.SceneManagement;

public class Bed : MonoBehaviour
{
    public TaskManager manager;

    void OnMouseDown()
    {
        if (manager.allDone)
        {
            Debug.Log("Sleep / next scene");
            GameplayHandler.storytime = 251;
            SceneManager.LoadScene("menu");
        }
    }
}