using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNew : MonoBehaviour
{
    public bool spawnReady;
    public bool ready;
    private void Start()
    {
        spawnReady = false;
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        spawnReady = true;
    }
    public bool Ready()
    {
        return spawnReady;
    }
}
