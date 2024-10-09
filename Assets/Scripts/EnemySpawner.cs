using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject Enemy;
    private float spawnRange = 11.5f;
    private float spawnPoint = -14;

    private float startDelay = 2;
    private float spawnInterval = 0.5f;

    void Start() {
        InvokeRepeating("SpawnEnemy", startDelay, spawnInterval);
    }

    void SpawnEnemy() {
        // Randomly generate enemies, always at the left but at random Z positions
        Vector3 spawnPos = new Vector3(spawnPoint, 0, Random.Range(-spawnRange, spawnRange));
        Instantiate(Enemy, spawnPos, Enemy.transform.rotation);
    }
}
