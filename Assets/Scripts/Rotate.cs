using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField]
    private float _speed = 1.0f;

    private Transform _rotatableTransform;

    private void Awake()
    {
        _rotatableTransform = gameObject.transform;
    }

    public void Update()
    {
        _rotatableTransform.rotation *= Quaternion.Euler(0, _speed, 0);
    }
}
