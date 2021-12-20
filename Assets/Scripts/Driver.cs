using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Driver : MonoBehaviour
{

    [SerializeField] float turnSpeed = 0.9f;
    [SerializeField] float moveSpeed = 0.005f;
    [SerializeField] float slowSpeed = 15f;
    [SerializeField] float speedBoost = 25f;


    void Update()
    {
        float turnAmount = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -turnAmount);
        transform.Translate(0, moveAmount, 0);
    }

    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("You hit something!");
        moveSpeed = slowSpeed;
    }

    void OnTriggerEnter2D(Collider2D other) {
        // if you hit a speed boost
        if (other.tag == "Speed Boost")
        {
            Debug.Log("Speeeed Booooooooost!");
            moveSpeed = speedBoost;
        }
        // if you hit a slow
        if (other.tag == "Slow")
        {
            Debug.Log("Oh no! You're super slow!");
            moveSpeed = slowSpeed;
        }
    }
}
