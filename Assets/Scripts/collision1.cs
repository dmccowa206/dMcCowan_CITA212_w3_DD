using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision1 : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision happened");
    }

    void OnTriggerEnter2D(Collider2D trigger)
    {
        Debug.Log("Entered trigger");
    }
}
