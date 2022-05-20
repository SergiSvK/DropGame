using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class FlyEnemyController : MonoBehaviour
{
    public Transform[] points;
    public float moveSpeed;
    private int _currentPoint;

    public SpriteRenderer spriteRenderer;

    void Start()
    {
        foreach (var t in points)
        {
            t.parent = null;
        }
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, points[_currentPoint].position,
            moveSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, points[_currentPoint].position) < .05f)
        {
            _currentPoint++;

            if (_currentPoint >= points.Length)
            {
                _currentPoint = 0;
            }
        }

        if (transform.position.x < points[_currentPoint].position.x)
        {
            spriteRenderer.flipX = true;
        }
        else if(transform.position.x > points[_currentPoint].position.x)
        {
            spriteRenderer.flipX = false;
        }
    }
}
