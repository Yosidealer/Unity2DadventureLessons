using UnityEngine;

public class BoosterFlame : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particleSystem;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.LeftArrow))
        {
            _particleSystem.Play();
             //GetComponent<SpriteRenderer>().enabled = true;
        }
        else
        {
            GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
