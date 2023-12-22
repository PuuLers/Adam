using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body : Adam
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Flip();
    }
    public void Flip()
    {
        Vector3 LocalScale = Vector3.one;
        if (CursorPosition() < 90 && CursorPosition() > -90)
        {
            LocalScale.x = LocalScale.x * 1f;

        }
        else
        {
            LocalScale.x = LocalScale.x * -1f;

        }
        transform.localScale = LocalScale;
    }
}
