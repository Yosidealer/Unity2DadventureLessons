using UnityEngine;
using UnityEngine.Audio;

public class ElevatorTopFloor : MonoBehaviour
{
    public Transform player1; // reference to player transform

    void OnMouseDown()
    {
        GetComponent<AudioSource>().Play(); // play elevator sound
        player1.position = new Vector3(20.3f, -3f, player1.position.z); // move player to the bottom floor
    }
}