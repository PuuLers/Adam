using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulllet : MonoBehaviour
{
    public float timeDestroy = 3f;
    public float speed = 3f;
    public Rigidbody2D rb;

    void Start()
    {
        Invoke("DestroyBullet", timeDestroy);
    }

    private void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    void DestroyBullet()
    {
        Destroy(gameObject);
    }
}