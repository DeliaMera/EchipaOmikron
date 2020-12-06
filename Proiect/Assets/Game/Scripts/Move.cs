using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float Speed = 1;

    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * Speed);
    }
}
