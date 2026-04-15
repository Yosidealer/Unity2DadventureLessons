using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void StartGame()
    {
        if (GameplayHandler.storytime == 0)
        {
            SceneManager.LoadScene("Diary");
        }

        if (GameplayHandler.storytime > 0 && GameplayHandler.storytime < 250)
        {
            SceneManager.LoadScene("Gameplay");
        }

        if (GameplayHandler.storytime == 250)
        {
            SceneManager.LoadScene("InRocket");
        }

        if (GameplayHandler.storytime > 250 && GameplayHandler.storytime < 500)
        {
            SceneManager.LoadScene("Gameplay");
        }

        if (GameplayHandler.storytime == 500)
        {
            GameplayHandler.storytime = 501;
            SceneManager.LoadScene("OnLand");
        }

        if (GameplayHandler.storytime > 500 && GameplayHandler.storytime < 750)
        {
            SceneManager.LoadScene("Gameplay");
        }

        if (GameplayHandler.storytime == 750)
        {
            GameplayHandler.storytime = 751;
            SceneManager.LoadScene("BossBattle");
        }
    }

    public void StartSettings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void StartAbout()
    {
        SceneManager.LoadScene("Credits");
    }
}
