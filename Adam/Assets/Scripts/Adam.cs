using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Adam : MonoBehaviour
{
    static public float healthPoint = 100;
    public GameObject healthPointBar;
    public float fieldSize;
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

    private void Bar()
    {
        float hp = healthPoint / 100f;
        healthPointBar.transform.localScale = new Vector3(hp, 0.1f, 1);
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
    private void Mirrored(float offset)
    {
        if (transform.position.x <= -fieldSize)
        {
            transform.position = new Vector3(fieldSize - 0.01f, transform.position.y, offset);
        }
        if (transform.position.x >= fieldSize)
        {
            transform.position = new Vector3(-fieldSize + 0.01f, transform.position.y, offset);
        }
        if (transform.position.y <= -fieldSize)
        {
            transform.position = new Vector3(transform.position.x, fieldSize - 0.01f, offset);
        }
        if (transform.position.y >= fieldSize)
        {
            transform.position = new Vector3(transform.position.x, -fieldSize + 0.01f , offset);
        }
    }



    void FixedUpdate()
    {
        Move(Speed);
        Mirrored(-4f);
        CursorPosition();
        Hand();
        Animate();
        Bar();
    }

}
