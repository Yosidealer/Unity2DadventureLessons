using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour
{

    [SerializeField] public float _backgroundSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        transform.position += Vector3.left * _backgroundSpeed * Time.deltaTime;

        if (transform.position.x < -22.92282f)
        {
            transform.position = new Vector3(15.68f, transform.position.y, transform.position.z);
        }
    }
}
