using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeSlide : MonoBehaviour
{
    public float raiseForce = 0.1f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody2D playerRb = collision.gameObject.GetComponent<Rigidbody2D>();
            Vector2 raiseVector = new Vector2(0f, raiseForce);
            playerRb.AddForce(raiseVector, ForceMode2D.Impulse);
        }
    }
}