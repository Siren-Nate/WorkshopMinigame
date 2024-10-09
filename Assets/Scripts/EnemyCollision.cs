using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    // Delete the enemy AND the player/projectile that touches it, as well as display a Game Over message
    void OnTriggerEnter(Collider other){
        Destroy(gameObject);
        Destroy(other.gameObject);
        Debug.Log("Game Over!");
    }
}