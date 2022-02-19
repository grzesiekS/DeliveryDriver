using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    private string PACKAGE_TAG = "Package";
    private string CUSTOMER_TAG = "Customer";

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Car collide with something");
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag == PACKAGE_TAG)
        {
            Debug.Log("Package picked up");
        }

        if(collider.tag == CUSTOMER_TAG)
        {
            Debug.Log("Package delivered");
        }
    }
}
