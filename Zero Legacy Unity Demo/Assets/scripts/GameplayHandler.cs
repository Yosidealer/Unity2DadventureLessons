using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement; // ❗ puntkomma vergeten

public class GameplayHandler : MonoBehaviour
{
    public static float storytime;
    private float timer = 0;

    void Start()
    {
        DontDestroyOnLoad(gameObject); // ❗ zorgt dat hij niet reset
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 1f)
        {
            storytime += 1;
            timer = 0;

            Debug.Log(storytime);
        }

        // ❗ floats vergelijken met == is risky → gebruik >=
        if (storytime >= 250 && storytime < 251 ||
            storytime >= 500 && storytime < 501 ||
            storytime >= 750 && storytime < 751)
        {
            SceneManager.LoadScene("Menu");
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }
    }
}