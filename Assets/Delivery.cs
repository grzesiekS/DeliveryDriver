using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    private string PackageTag = "Package";
    private string CustomerTag = "Customer";

    [SerializeField] float destroyDelay = 0.2f;
    [SerializeField] Color32 hasPackageColor = new Color32(255, 255, 255, 255);
    [SerializeField] Color32 withoutPackageColor = new Color32(255, 255, 255, 255);

    bool hasPackage;
    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Car collide with something");
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag == PackageTag && !hasPackage)
        {
            Debug.Log("Package picked up");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(collider.gameObject, destroyDelay);
        }

        if(collider.tag == CustomerTag && hasPackage)
        {
            Debug.Log("Package delivered");
            hasPackage = false;
            spriteRenderer.color = withoutPackageColor;
        }
    }
}
