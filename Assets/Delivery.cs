using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    private string PACKAGE_TAG = "Package";
    private string CUSTOMER_TAG = "Customer";

    [SerializeField] float destroyDelay = 0.2f;
    bool hasPackage;

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Car collide with something");
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag == PACKAGE_TAG && !hasPackage)
        {
            Debug.Log("Package picked up");
            hasPackage = true;
            Destroy(collider.gameObject, destroyDelay);
        }

        if(collider.tag == CUSTOMER_TAG && hasPackage)
        {
            Debug.Log("Package delivered");
            hasPackage = false;
        }
    }
}
