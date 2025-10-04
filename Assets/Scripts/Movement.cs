using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float _speed = 1.0f;

    private Transform _sphere;

    public void Awake()
    {
        _sphere = GetComponent<Transform>();
    }

    public void Update()
    {
        _sphere.position = _sphere.position + Vector3.forward * _speed * Time.deltaTime; 
    }
}
