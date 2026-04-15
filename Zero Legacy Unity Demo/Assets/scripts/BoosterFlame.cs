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
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.LeftArrow)) //if speedboost button is pressed, play particle system and show sprite
        {
            _particleSystem.Play(); //play particle system
        }
        else
        {
            GetComponent<SpriteRenderer>().enabled = false; //hide sprite
        }
    }
}
