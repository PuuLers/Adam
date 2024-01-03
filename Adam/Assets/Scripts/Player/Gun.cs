using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEditorInternal;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject Bullet;
    public float moveSpeed = 2f;
    public Transform shootPoint;
    public float betweenTime;
    private float _zero = 0;
    static public int _damage = 40;
    private Animator _animator;

    private void GetComponent()
    {
        _animator = GetComponent<Animator>();
    }

    private void Start()
    {
        GetComponent();
    }


    private void Animate(int id)
    {
        if (id == 0)
        {
            _animator.SetBool("Shoot", false);
        }
        else if (id == 1)
        {
            _animator.SetBool("Shoot", true);
        }
    }

    private float Follow()
    {
        Vector3 diference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotateZ = Mathf.Atan2(diference.y, diference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotateZ);
        return rotateZ;
    }

    private void FlipGun()
    {
        Vector3 LocalScale = Vector3.one;
        if (Follow() < 90 && Follow() > -90)
        {
            LocalScale.y = LocalScale.y * 1f;
        }
        else
        {
            LocalScale.y = LocalScale.y * -1f;
        }
        transform.localScale = LocalScale;
    }

    private void FixedUpdate()
    {
        Shoot();
        Follow();
        FlipGun();
    }
    private void Shoot()
    {
        _zero += 0.1f;
        if (Input.GetMouseButton(0) && _zero > betweenTime)
        {
            Instantiate(Bullet, shootPoint.position, transform.rotation);
            Animate(1);
            _zero = 0;
        }
        else
        {
            Animate(0);
        }
    }
}