using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bear : Enemy
{
    private Animator _animator;
    private void Start()
    {
        _animator = GetComponent<Animator>();
        _animator.SetBool("Die", false);
    }

    void FixedUpdate()
    {
        HuntFollow();
        Die();
    }

    private void Die()
    {
        if (_die == true)
        {
            _speed = 0;
            _damage = 0;
            _animator.SetBool("Die", true);
        }
    }
}

