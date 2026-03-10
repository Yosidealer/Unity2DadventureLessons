using UnityEngine;

public class playermovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    public void MovePlayer(Vector2 direction)
    {

        transform.position += new Vector3(direction.x, direction.y, 0) * _speed * Time.deltaTime;
    }

}
