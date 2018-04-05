﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA.Persistence;

public class Waypoints : MonoBehaviour {
    private Moving _mv;

    [SerializeField]private GameObject[] _points;
    public GameObject[] Points { get { return _points; } }
    private int _pointIndex;
    public int PointIndex { get { return _pointIndex; } set { _pointIndex = value;} }
    private int _currentPointIndex;
    public int CurrentPointIndex { get { return _currentPointIndex; } set { _currentPointIndex = value; } }
    private Vector3 _nextPosition;
    public Vector3 NextPosition { get { return _nextPosition; } set { _nextPosition = value; } }
    private Vector3 _lastPosition;
    public Vector3 LastPosition { get { return _lastPosition; } set { _lastPosition = value; } }
    private float _movementSpeed;
    public float MovementSpeed { get { return _movementSpeed; } }
    private float _startTime;
    public float StartTime { get { return _startTime; } set { _startTime = value; } }
    private float _distance;
    public float Distance { get { return _distance; } set { _distance = value; } }

    private void Start ()
    {
        _mv = this.GetComponent<Moving>();

        _pointIndex = Random.Range(0, _points.Length);
        _nextPosition = new Vector3 (_points[_pointIndex].transform.position.x, 0, _points[_pointIndex].transform.position.z);
        _lastPosition = this.transform.position;
        _movementSpeed = 1;
        _startTime = Time.time;
        _distance = Vector3.Distance(_lastPosition, _nextPosition);
    }
	
	private void Update ()
	{
	    _mv.Move();
	}
}
