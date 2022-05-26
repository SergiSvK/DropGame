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

    public float distanceToAttackPlayer, chaseSpeed;
    
    public float waitAfterAttack;
    private Vector2 _attackTarget;
    private float _attackCounter;
    

    void Start()
    {
        foreach (var t in points)
        {
            t.parent = null;
        }
    }

    void Update()
    {

        if (_attackCounter > 0)
        {
            _attackCounter -= Time.deltaTime;
        }
        else
        {
            if (Vector2.Distance(transform.position,PlayerController.intance.transform.position) > distanceToAttackPlayer)
            {

                _attackTarget = Vector2.zero;
            
                transform.position = Vector2.MoveTowards(transform.position, points[_currentPoint].position,
                    moveSpeed * Time.deltaTime);

                if (Vector2.Distance(transform.position, points[_currentPoint].position) < .05f)
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
            else
            {
                if (_attackTarget == Vector2.zero)
                {
                    _attackTarget = PlayerController.intance.transform.position;
                }
                transform.position = Vector2.MoveTowards(transform.position,_attackTarget, chaseSpeed * 
                    Time.deltaTime);

                if (!(Vector2.Distance(transform.position, _attackTarget) <= .1f)) return;
                _attackCounter = waitAfterAttack;
                _attackTarget = Vector2.zero;

            }
        }

    }
}
