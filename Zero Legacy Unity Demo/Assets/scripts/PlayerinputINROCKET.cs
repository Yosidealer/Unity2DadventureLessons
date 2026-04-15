using System.IO;
using System.Net.NetworkInformation;
using UnityEngine;

public class PlayerinputINROCKET : MonoBehaviour
{
    [SerializeField] private float _speed = 5;
    private int _score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space))
        {
            print("Wpressed");
            transform.position += (new Vector3(0, 1, 0) * Time.deltaTime * _speed);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            print("Apressed");
            transform.position += (new Vector3(-1, 0, 0) * Time.deltaTime * _speed);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            print("Spressed");
            transform.position += (new Vector3(0, -1, 0) * Time.deltaTime * _speed);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            print("Dpressed");
            transform.position += (new Vector3(1, 0, 0) * Time.deltaTime * _speed);
        }
    }
}
