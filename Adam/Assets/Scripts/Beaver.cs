using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beaver : Enemy
{
    private Animator _animator;
   

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _animator.SetBool("Die", false);
    }

    void Update()
    {
        HuntFollow();
        die();
    }

    private void die()
    {
        if (_die == true)
        {
            _animator.SetBool("Die", true);
        }
    }
}
