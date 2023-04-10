using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlatform : MonoBehaviour
{
    public GameObject player;
    private bool isPlayerFollowing;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            isPlayerFollowing = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            isPlayerFollowing = false;
        }
    }

    private void Update()
    {
        if (isPlayerFollowing)
        {
            Vector3 newPosition = player.transform.position;
            newPosition.x = transform.position.x;
            player.transform.position = newPosition;
        }
    }
}
