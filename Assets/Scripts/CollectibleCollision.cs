using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleCollision : MonoBehaviour
{
    public int score = 0;
    // Delete the collectible, but not the player/projectile that touches it
    void OnTriggerEnter(Collider other){
        Destroy(gameObject);
        // Can't get this score function working.
        // I know the problem is that it's counting the score for each individual collectible, so it never rises above 1, but I don't know how to make it more "universal".
        // I can't store the int on the player cube because then I would need to put rigidbodies on the collectibles
        // and then that would cause problems with them getting deleted by enemies.
        // score = score + 1;
        // Debug.Log("Score: " + score);
    }
}
