using UnityEngine;

public class Rotation : MonoBehaviour
{
    private Transform _cube;

    [SerializeField]
    private float _speed = 5.0f; 

    public void Awake()
    {
        _cube = GetComponent<Transform>();
    }
    
    public void Update()
    {
        _cube.rotation *= Quaternion.Euler(0, _speed, 0);      
    }

}
