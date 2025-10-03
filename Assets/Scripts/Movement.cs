using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private int _minValue = -5;

    [SerializeField]
    private int _maxValue = 5;

    [SerializeField]
    private float _speed = 1.0f;

    private Transform _sphere;

    private int _direction = 1; 

    public void Awake()
    {
        _sphere = GetComponent<Transform>();
    }

    public void Update()
    {        
        if (_sphere.position.z > _maxValue && _direction > 0)
        {            
            _direction = (int)Vector3.back.z;
        }

        if (_sphere.position.z < _minValue && _direction < 0)
        {
            _direction = (int)Vector3.forward.z;
        }

        _sphere.position = new Vector3(_sphere.position.x, _sphere.position.y, _sphere.position.z + _direction * _speed * Time.deltaTime);
    }
}
