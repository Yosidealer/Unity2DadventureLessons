using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpike : MonoBehaviour
{

    [SerializeField] public float _spikeSpeed = 2f; //speed of spike movement

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        transform.position += Vector3.left * _spikeSpeed * Time.deltaTime; //moves spike left
    }
}
