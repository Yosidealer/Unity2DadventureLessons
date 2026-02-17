using System.IO;
using System.Net.NetworkInformation;
using UnityEngine;

public class playerinput : MonoBehaviour

{
    [SerializeField] private float _speed = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("W key was pressed");
            transform.position += (new Vector3(0, 1, 0) * Time.deltaTime * _speed);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("A key was pressed");
            transform.position += (new Vector3(-1, 0, 0) * Time.deltaTime * _speed);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("D key was pressed");
            transform.position += (new Vector3(1, 0, 0) * Time.deltaTime * _speed);
        }
    }
}
