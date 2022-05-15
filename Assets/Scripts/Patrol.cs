using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public Transform[] waypoints;
    private int _currentWaypointIndex;
    private float _speed = 2f;

    private float _waitTime = 1f;
    private float _waitCounter = 0f;
    private bool _waiting = false;

    private void Update()
    {
        if (_waiting)
        {
            _waitCounter += Time.deltaTime;
            if (_waitCounter < _waitTime)
                return;
            _waiting = false;
        }

        Transform wp = waypoints[_currentWaypointIndex];
        if (Vector3.Distance(transform.position, wp.position) < 0.01f)
        {
            transform.position = wp.position;
            _waitCounter = 0f;
            _waiting = true;

            _currentWaypointIndex = (_currentWaypointIndex + 1) % waypoints.Length;
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, wp.position, _speed * Time.deltaTime);
            transform.LookAt(wp.position);
        }
    }
}

