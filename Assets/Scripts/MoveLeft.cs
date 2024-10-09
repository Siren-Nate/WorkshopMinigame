using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 7.0f;

    void Update(){
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
