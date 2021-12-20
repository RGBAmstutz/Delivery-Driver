using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour {

    [SerializeField] float destroyDelay = 0.5f;
    [SerializeField] Color32 hasPackageColor = new Color32(1,1,1,1);
    [SerializeField] Color32 noPackageColor = new Color32(1,0,0,1);
    bool hasPackage = false;
    SpriteRenderer spriteRenderer;

    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();   
    }
    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Oof..");
    }

    void OnTriggerEnter2D(Collider2D other) {
        // if the collision is with a package
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package has been picked up!");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroyDelay);
        }
        // if the collision is with the drop-off
        if (other.tag == "Drop-off" && hasPackage)
        {
            Debug.Log("You've dropped off the package!");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
