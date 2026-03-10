using System.IO;
using System.Net.NetworkInformation;
using UnityEngine;

public class playerinput : MonoBehaviour
{

    [SerializeField] private playermovement _MovePlayer;
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
            
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("A key was pressed");
            
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("D key was pressed");
            _MovePlayer.MovePlayer(Vector2.right);
        }
    }
}
