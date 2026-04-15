using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroHandler: MonoBehaviour
{
    [SerializeField] SpriteRenderer _spriterenderer; // reference to the sprite renderer of the main background
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _spriterenderer.enabled = false; // hide main background initially
        Invoke("introvid", 28); // call introvid function after 28 seconds
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space)) // if the player presses space, skip the intro
        {
            GameplayHandler.storytime = 0; // reset storytime
            SceneManager.LoadScene("Menu"); // load menu scene
        }
    }

    void introvid()
    {
        _spriterenderer.enabled = true; // show main background after 28 seconds
    }
}
