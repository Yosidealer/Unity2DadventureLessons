using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroHandler: MonoBehaviour
{
    [SerializeField] SpriteRenderer _spriterenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _spriterenderer.enabled = false;
        Invoke("introvid", 28);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            GameplayHandler.storytime = 0;
            SceneManager.LoadScene("Menu");
        }
    }

    void introvid()
    {
        _spriterenderer.enabled = true;
    }
}
