using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] private int _healthPoint;
    [SerializeField] private int _damage;
    [SerializeField] private float _speed;
    private GameObject _player;
    protected bool _die = false;

    private void Awake()
    {
        _player = GameObject.Find("Adam");
    }
    protected void HuntFollow()
    {
        Vector3 offset = new Vector3(0, -0.6f, 0);
        if (_die == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, _player.transform.position + offset, _speed * Time.fixedDeltaTime);
            Vector3 LocalScale = Vector3.one;
            if (transform.position.x > _player.transform.position.x)
            {
                LocalScale.x = LocalScale.x * -1;
            }
            else
            {
                LocalScale.x = LocalScale.x * 1;
            }
            transform.localScale = LocalScale;
        }
    }

    protected void CheckHealthPoint()
    {
        if (_healthPoint <= 0)
        {
            Die();
        }
    }
    protected void Damage()
    {
        _healthPoint -= Gun._damage;
        CheckHealthPoint();
    }

    protected void Die()
    {
        _die = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet") && Bulllet.destroyed == false)
        {
            Damage();
            collision.gameObject.SetActive(false);
        }
        else if (collision.CompareTag("Bullet"))
        {
            Damage();
        }
    }
}
