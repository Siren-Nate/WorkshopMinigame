using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleSpawner : MonoBehaviour
{
    public GameObject Collectible;
    private float spawnRange = 12;
    private float spawnPoint = 14;

    private float startDelay = 2;
    private float spawnInterval = 0.5f;

    void Start() {
        InvokeRepeating("SpawnCollectible", startDelay, spawnInterval);
    }

    void SpawnCollectible() {
        // Randomly generate collectibles, always at the top but at random X positions
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRange, spawnRange), 0, spawnPoint);
        Instantiate(Collectible, spawnPos, Collectible.transform.rotation);
    }
}
