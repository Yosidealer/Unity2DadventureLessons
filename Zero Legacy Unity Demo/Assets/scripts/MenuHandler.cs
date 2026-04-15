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
        if (Input.GetKeyDown(KeyCode.Escape)) //escape button, quits game
        {
            Application.Quit();
        }
    }

    public void StartGame() //gamestartbutton, loads scenes based on storytime variable in GameplayHandler
    {

        //begin spel, load diary
        if (GameplayHandler.storytime == 0)
        {
            SceneManager.LoadScene("Diary");
        }

        //diary finished, load gameplay
        if (GameplayHandler.storytime > 0 && GameplayHandler.storytime < 250)
        {
            SceneManager.LoadScene("Gameplay");
        }

        //gameplay finished, load rocket
        if (GameplayHandler.storytime == 250)
        {
            SceneManager.LoadScene("InRocket");
        }

        //rocket finished, load gameplay
        if (GameplayHandler.storytime > 250 && GameplayHandler.storytime < 500)
        {
            SceneManager.LoadScene("Gameplay");
        }

        //gameplay finished, load on land
        if (GameplayHandler.storytime == 500)
        {
            GameplayHandler.storytime = 501;
            SceneManager.LoadScene("OnLand");
        }

        //on land finished, load gameplay
        if (GameplayHandler.storytime > 500 && GameplayHandler.storytime < 750)
        {
            SceneManager.LoadScene("Gameplay");
        }

        //gameplay finished, load boss battle
        if (GameplayHandler.storytime == 750)
        {
            GameplayHandler.storytime = 751;
            SceneManager.LoadScene("BossBattle");
        }
    }

    public void StartSettings() //settingsbutton, loads settings scene
    {
        SceneManager.LoadScene("Settings");
    }

    public void StartAbout() //aboutbutton, loads credits scene
    {
        SceneManager.LoadScene("Credits");
    }
}
