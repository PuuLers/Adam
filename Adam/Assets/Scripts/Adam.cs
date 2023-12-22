using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Adam : MonoBehaviour
{
    public float Speed;
    private Vector2 _direction;
    private Rigidbody2D _rb;
    private Animator _animator;
    public GameObject hand;
    public Transform handPoint;
    private void GetComponent()
    {
        _rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    void Start()
    {
        GetComponent();
    }
    private void Hand()
    {
        hand.transform.position = handPoint.position;
    }

    public float CursorPosition()
    {
        Vector3 diference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotateZ = Mathf.Atan2(diference.y, diference.x) * Mathf.Rad2Deg;
        return rotateZ;
    }
    private void Animate()
    {
        if (_direction.x != 0 || _direction.y != 0)
        {
            _animator.SetBool("Move", true);
        }
        else
        {
            _animator.SetBool("Move", false);
        }
    }

    private void Move(float speed)
    {
        _direction.x = Input.GetAxisRaw("Horizontal");
        _direction.y = Input.GetAxisRaw("Vertical");
        _rb.MovePosition(_rb.position + _direction * speed * Time.fixedDeltaTime);
    }
    private void Mirrored()
    {
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
        Mirrored();
        CursorPosition();
        Hand();
        Animate();
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
