using UnityEngine;
using UnityEngine.SceneManagement;


public class DiaryHandler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("diaryvid", 221); //call diaryvid after 221 seconds
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void diaryvid() //function to load gameplay scene
    {
        SceneManager.LoadScene("Gameplay"); //load gameplay scene
    }
}
