using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffSpawn : MonoBehaviour
{
    public GameObject bola;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    public void SpawnObject()
    {
        Instantiate(bola, transform.position, Quaternion.identity);
        
        if (stopSpawning)
        {
            CancelInvoke("SpawnObject");
        }
    }
}
