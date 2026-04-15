using UnityEngine;
using UnityEngine.SceneManagement;

public class Deathscreen : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("deathscreen", 7); //call deathscreen function after 7 seconds, which loads menu scene
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void deathscreen() //function to load menu scene
    {
        SceneManager.LoadScene("Menu"); //load menu scene
    }
}
