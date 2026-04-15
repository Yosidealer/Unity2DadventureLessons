using UnityEngine;

public class ElevatorBottomFloor : MonoBehaviour
{
    public Transform player; // reference to player transform

    void OnMouseDown() // when the elevator is clicked
    {
        player.position = new Vector3(20.12f, 8f, player.position.z); // move player to the top floor
        GetComponent<AudioSource>().Play(); // play elevator sound
    }
}