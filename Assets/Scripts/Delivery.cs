using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] float destDelay = 1f;
    [SerializeField] Color32 havePackColor = new Color32(255,255,255,255);
    [SerializeField] Color32 noPackColor = new Color32(141,141,141,255);
    SpriteRenderer sprRender;

    void Start()
    {
        sprRender = GetComponent<SpriteRenderer>();
    }
    private bool havePack = false;
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision happened");
    }

    void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.tag == "Package" && !havePack)
        {
            Debug.Log("Package picked up.");
            havePack = true;
            Destroy(trigger.gameObject, destDelay);
            sprRender.color = havePackColor;
        }
        if (trigger.tag == "Customer" && havePack)
        {
            Debug.Log("Package delivered.");
            havePack = false;
            sprRender.color = noPackColor;
            CountTracker.packNum ++;
            if (CountTracker.packNum >= 3)
            {
                CountTracker.victory = true;
            }
        }
    }
}
