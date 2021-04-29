using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject obs;
    public float spawnDelay = 1;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn",0, spawnDelay);
    }

    void Spawn()
    {
        Instantiate(obs, transform.position, Quaternion.identity);
    }

}
