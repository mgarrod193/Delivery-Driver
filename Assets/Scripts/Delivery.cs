using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    public  void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ouch!");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Package")
        {
            Debug.Log("You picked up the package");
        }

        else
        {
            Debug.Log("Package delivered");
        }
    }
}
