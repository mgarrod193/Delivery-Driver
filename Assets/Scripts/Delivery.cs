using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    private bool hasPackage = false;

    private Color32 noPackageColor = new Color32(255, 255, 255, 255);
    private SpriteRenderer spriteRenderer;
    private SpriteRenderer packageColor;

    private void Start()
    {
        Debug.Log(hasPackage);
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = noPackageColor;
    }
    public  void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ouch!");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Package" && !hasPackage)
        {
            packageColor = collision.gameObject.GetComponent<SpriteRenderer>();
            Debug.Log("You picked up the package");
            hasPackage = true;
            Destroy(collision.gameObject, 0.5f);
            spriteRenderer.color = packageColor.color;
        }

        else if (collision.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package delivered");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
