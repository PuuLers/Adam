using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class Gun : Adam
{

    public GameObject Bullet;
    public float moveSpeed = 2f;
    public Transform shootPoint;
    public float betweenTime;
    private float _zero = 0;
    
    private void Follow()
    {
        Adam adam = new Adam();
        transform.rotation = Quaternion.Euler(0f, 0f, adam.CursorPosition());
        Debug.Log(adam.CursorPosition());
    }
    private void Flip()
    {
        Adam adam = new Adam();
        Vector3 LocalScale = Vector3.one;
        if (adam.CursorPosition() < 90 && adam.CursorPosition() > 180)
        {
            LocalScale.x = LocalScale.x * 1f;
        }
        else
        {
            LocalScale.x = LocalScale.x * -1f;
        }
        transform.localScale = LocalScale;
    }

    private void FixedUpdate()
    {
        Shoot();
        Follow();
        //Flip();
    }
    private void Shoot()
    {
        _zero += 0.1f;
        if (Input.GetMouseButton(0) && _zero > betweenTime)
        {
                Instantiate(Bullet, shootPoint.position, transform.rotation);
                _zero = 0;  
        }
    }
}