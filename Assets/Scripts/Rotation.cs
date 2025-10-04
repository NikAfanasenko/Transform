using UnityEngine;

public class Rotation : MonoBehaviour
{
    private Transform _rotatableTransform;

    [SerializeField]
    private float _speed = 5.0f; 

    public void Awake()
    {
        _rotatableTransform = GetComponent<Transform>();
    }
    
    public void Update()
    {
        _rotatableTransform.rotation *= Quaternion.Euler(0, _speed, 0);
    }

}
