using UnityEngine;
using UnityEngine.SceneManagement;

public class Deathscreen : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("deathscreen", 7);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void deathscreen()
    {
        SceneManager.LoadScene("Menu");
    }
}
