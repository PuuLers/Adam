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
    }

    void FixedUpdate()
    {

        Move(Speed);
    }
    private void Update()
    {
        Vector3 LocalScale = new Vector3();
        LocalScale.x = LocalScale.x + 0.1f;
        transform.localScale = LocalScale;
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
