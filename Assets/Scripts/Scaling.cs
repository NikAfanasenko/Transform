using UnityEngine;

public class Scaling : MonoBehaviour
{
    private int _direction = 1; 
    private int _minValue = 1; 
    private int _maxValue = 3;

    [SerializeField]
    private float _speed = 1f;

    private Transform _capsule; 

    public void Awake()
    {
        _capsule = GetComponent<Transform>();
    }

    public void Update()
    {
        if (_capsule.localScale.z > _maxValue && _direction > 0)
        {
            _direction = (int)Vector3.back.z;            
        }

        if (_capsule.localScale.z < _minValue && _direction < 0)
        {
            _direction = (int)Vector3.forward.z;
        }
    
        _capsule.localScale += new Vector3(Time.deltaTime, Time.deltaTime, Time.deltaTime)  * _speed * _direction;
    }
}
