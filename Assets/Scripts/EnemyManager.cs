using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyManager : MonoBehaviour
{
    public GameObject spawnee;
    public Text textElement;
    private int i = 1;
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
        Instantiate(spawnee, transform.position, Quaternion.identity);
        textElement.text = "Round "+ i;
        i = i+1;
        
        if (stopSpawning)
        {
            CancelInvoke("SpawnObject");
        }
    }
}
