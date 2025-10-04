using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float _speed = 1.0f;

    private Transform _movableTransform;

    public void Awake()
    {
        _movableTransform = GetComponent<Transform>();
    }

    public void Update()
    {
        _movableTransform.position = _movableTransform.position + _movableTransform.rotation * Vector3.forward * _speed * Time.deltaTime;        
    }
}
