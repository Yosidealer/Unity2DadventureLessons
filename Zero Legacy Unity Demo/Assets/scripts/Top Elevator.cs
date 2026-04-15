using UnityEngine;
using UnityEngine.Audio;

public class ElevatorTopFloor : MonoBehaviour
{
    public Transform player1; // sleep je Player hierheen in inspector

    void OnMouseDown()
    {
        GetComponent<AudioSource>().Play();
        player1.position = new Vector3(20.3f, -3f, player1.position.z);
    }
}