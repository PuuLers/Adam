using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Solid : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet") && Bulllet.destroyed == false)
        {
            collision.gameObject.SetActive(false);
        }
    }
}
