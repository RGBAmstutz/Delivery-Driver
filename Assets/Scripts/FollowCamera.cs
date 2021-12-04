using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
[SerializeField] GameObject whatToFollow;
    // The camera position should be the same as the car position
    void LateUpdate()
    {
        transform.position = whatToFollow.transform.position + new Vector3(0,0,-50); 
    }
}
