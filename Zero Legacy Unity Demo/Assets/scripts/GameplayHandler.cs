using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplayHandler : MonoBehaviour
{
    public static float storytime; // global variable to keep track of story progress, used for loading scenes in menuhandler
    private float timer = 0; // timer variable to keep track of time for storytime increment

    void Start()
    {
        DontDestroyOnLoad(gameObject); //keep storytime value when loading new scenes
    }

    void Update()
    {
        timer += Time.deltaTime; // increment timer by the time elapsed since the last frame

        if (timer >= 1f) // if timer reaches 1 second, increment storytime and reset timer
        {
            storytime += 1;
            timer = 0;

            Debug.Log(storytime);
        }

        if (storytime >= 250 && storytime < 251 ||
            storytime >= 500 && storytime < 501 ||
            storytime >= 750 && storytime < 751) // if storytime is at a point where the player should be in gameplay, load menu scene
        {
            SceneManager.LoadScene("Menu"); //load menu scene
        }

        if (Input.GetKeyDown(KeyCode.Escape)) //escape button, quits game
        {
            SceneManager.LoadScene("Menu"); //load menu scene
        }
    }
}