using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionChecker : MonoBehaviour
{
    public GameObject player; // the player object
    public GameObject platform; // the platform object
    private bool isColliding; // flag to track if the player is colliding with the platform

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == player) // check if the collision is with the player
        {
            isColliding = true;
            player.transform.SetParent(platform.transform, true); // parent the player object to the platform object
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject == player) // check if the collision is with the player
        {
            isColliding = false;
            player.transform.SetParent(null, true); // unparent the player object from the platform object
        }
    }

    void FixedUpdate()
    {
        if (isColliding)
        {
            // move the player along with the platform
            Vector3 newPos = player.transform.position + (platform.transform.position - platform.transform.position);
            player.transform.position = newPos;
        }
    }
}
