using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Adam : MonoBehaviour
{
    public float Speed;
    private Vector2 _direction;
    private Rigidbody2D _rb;


    private void GetComponent()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        GetComponent();
    }

    private void Move(float speed)
    {
        _direction.x = Input.GetAxisRaw("Horizontal");
        _direction.y = Input.GetAxisRaw("Vertical");
        _rb.MovePosition(_rb.position + _direction * speed * Time.fixedDeltaTime);

        if (transform.position.x <= -10f)
        {
            transform.position = new Vector2(9.99f, transform.position.y);
        }

        if (transform.position.x >= 10f)
        {
            transform.position = new Vector2(-9.99f, transform.position.y);
        }

        if (transform.position.y <= -5f)
        {
            transform.position = new Vector2(transform.position.x, 4.99f);
        }

        if (transform.position.y >= 5f)
        {
            transform.position = new Vector2(transform.position.x, -4.99f);
        }
    }

    void FixedUpdate()
    {
        Move(Speed);       
    }

    private void Update()
    {
       
    }


    //public void flip(bool fliped, float parametr)
    //{
    //    Vector3 LocalScale = Vector3.one;
    //    if (fliped == false && LocalScale.x <= 1)
    //    {
    //        LocalScale.x = LocalScale.x + parametr;
    //    }
    //    else if (fliped == true && LocalScale.x >= -1)
    //    {
    //        LocalScale.x = LocalScale.x - parametr;
    //    }
    //    transform.localScale = LocalScale;
    //}
}
