using UnityEngine;
using UnityEngine.SceneManagement;


public class DiaryHandler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("diaryvid", 221);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void diaryvid()
    {
        SceneManager.LoadScene("Gameplay");
    }
}
