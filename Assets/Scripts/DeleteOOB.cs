using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteOOB : MonoBehaviour
{
    private float verticalBound = 15;
    private float horizontalBound = 15;

    void Update(){
        // Check when any enemy, collectible, or projectile goes out of sight and delete them
        if ((transform.position.z > verticalBound)||(transform.position.z < -verticalBound)||(transform.position.x < -horizontalBound)||(transform.position.x > horizontalBound)){
            Destroy(gameObject);
        }
    }
}
