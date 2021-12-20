using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour {
    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Oof..");
    }

    void OnTriggerEnter2D(Collider2D other) {
        // if the collision is with a package
        if (other.tag == "Package")
        {
            Debug.Log("Package has been picked up!");
        }
        // if the collision is with the drop-off
        if (other.tag == "Drop-off")
        {
            Debug.Log("You've dropped off the package!");
        }
    }
}
