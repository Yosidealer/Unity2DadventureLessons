using UnityEngine;

public class ElevatorBottomFloor : MonoBehaviour
{
    public Transform player; // sleep je Player hierheen in inspector

    void OnMouseDown()
    {
        player.position = new Vector3(20.12f, 8f, player.position.z);
        GetComponent<AudioSource>().Play();
    }
}