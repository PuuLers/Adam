using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] private int _healthPoint;
    [SerializeField] private int _damage;
    [SerializeField] private float _speed;
    public Transform player;


    private void Update()
    {
        Hunt();
    }
    private void Hunt()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.position, _speed * Time.fixedDeltaTime);
        Vector3 LocalScale = Vector3.one;
        if (transform.position.x > player.position.x)
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
