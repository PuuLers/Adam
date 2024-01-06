using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class LayerSorter : MonoBehaviour
{
    public float offset;
    private GameObject _player;
    private void Awake()
    {
        _player = GameObject.Find("Adam");
    }

    void FixedUpdate()
    {
        Sorting();
    }

    private void Sorting()
    {

        if (_player.transform.position.y - 0.928f > gameObject.transform.position.y)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, offset);
        }
        else
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, offset + 6);
        }
    }



}
