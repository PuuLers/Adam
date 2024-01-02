using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class LayerSorter : MonoBehaviour
{
    private GameObject _player;
    private void Awake()
    {
        _player = GameObject.Find("Adam");
    }

    void FixedUpdate()
    {
        if (_player.transform.position.y - 0.928f > gameObject.transform.position.y)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, -5f);
        }
        else
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0);
        }
    }
}
