using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public GameObject Bullet;
    private Vector3 mousePosition;
    public float moveSpeed = 2f;

    void Update()
    {
        Shoot();
        Vector3 diference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotateZ = Mathf.Atan2(diference.y, diference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotateZ);
    }

    private void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(Bullet, transform.position, transform.rotation);
        }

    }
}