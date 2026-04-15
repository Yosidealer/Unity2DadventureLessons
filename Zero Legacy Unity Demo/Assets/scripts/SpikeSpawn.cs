using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeSpawner : MonoBehaviour
{

    [SerializeField] private float _maxTime;
    [SerializeField] private float _heightRange;
    [SerializeField] private GameObject _spike;

    private float _timer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        SpawnSpike();
    }

    private void SpawnSpike()
    {
        Vector3 spawnPosition = transform.position + new Vector3(0, Random.Range(-_heightRange, _heightRange) * 1.5f); 
        GameObject spike = Instantiate(_spike, spawnPosition, Quaternion.identity);

        Destroy(spike, 30f); // Destroy the spike after 30 seconds to prevent memory leaks
    }

    // Update is called once per frame
    private void Update()
    {
        if (_timer > _maxTime)
        {
            SpawnSpike();
            _timer = 0;
        }
        _timer += Time.deltaTime;
    }
}
