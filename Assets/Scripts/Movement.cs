using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float _speed = 1.0f;

    private Transform _movableTransform;

    private void Awake()
    {
        _movableTransform = gameObject.transform; 
    }

    public void Update()
    {
        _movableTransform.position = _movableTransform.position + _movableTransform.rotation * Vector3.forward * _speed * Time.deltaTime;        
    }
}
