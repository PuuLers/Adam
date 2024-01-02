using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject helthPointBar;


    [SerializeField] protected int _healthPoint;
    [SerializeField] protected int _damage;
    [SerializeField] protected float _speed;
    protected GameObject _player;
    protected bool _die = false;

    private void Bar()
    {
        float hp = _healthPoint / 100f;
        helthPointBar.transform.localScale = new Vector3(hp, 0.1f, 1);
    }

    private void Awake()
    {
        _player = GameObject.Find("Adam");

    }

    private Vector3 GetPlayerPosition()
    {
        Transform player = _player.transform;
        return player.position;
    }
    private void Update()
    {
        CheckHealthPoint();
        Bar();
    }

    protected void HuntFollow()
    {

        Vector3 offset = new Vector3(0, -0.6f, 0);
        transform.position = Vector3.MoveTowards(transform.position, GetPlayerPosition(), _speed * Time.fixedDeltaTime);
    }


    private void flip()
    {
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


    protected void CheckHealthPoint()
    {
        if (_healthPoint <= 0)
        {
            _die = true;
            _healthPoint = 0;
        }
        else
        {
            flip();
        }
    }
    protected void Damage()
    {
        _healthPoint -= Gun._damage;
        CheckHealthPoint();
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
