using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float rotValue = 0;
    [SerializeField] float transValue = 0;
    [SerializeField] float moveSpeed = 0.2f;
    [SerializeField] float turnSpeed = -1f;
    [SerializeField] float boostSpeed = 0.3f;
    [SerializeField] float crashSpeed = 0.15f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Text goes here lmao");
    }

    // Update is called once per frame
    void Update()
    {
        rotValue = Input.GetAxis("Horizontal") * turnSpeed;
        transValue = Input.GetAxis("Vertical") * moveSpeed;
        transform.Rotate(0,0,rotValue);
        // need translations added
        transform.Translate(0,transValue, 0);
    }
    void OnTriggerEnter2D(Collider2D boost)
    {
        if (boost.tag == "Boost")
        {
            moveSpeed = boostSpeed;
        }
    }
    void OnCollisionEnter2D(Collision2D crash)
    {
        moveSpeed = crashSpeed;
    }
}
