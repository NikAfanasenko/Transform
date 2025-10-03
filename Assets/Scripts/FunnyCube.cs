using UnityEngine;

public class FunnyCube : MonoBehaviour
{
    private const int MinDegree = -5;
    private const int MaxDegree = 5;

    private const int MinScaling = 1;
    private const int MaxScaling = 2;

    private int _directionScale = 1;

    private Transform _cube;
    private float _speed = 0.5f;

    private float _speedScale = 1f;     

    public void Awake()
    {
        _cube = GetComponent<Transform>();
    }

    public void Update()
    {
        Quaternion angle = Quaternion.Euler(0, Random.Range(MinDegree, MaxDegree), 0);

        _cube.rotation *= angle;

        _cube.position += new Vector3(Mathf.Sin(angle.eulerAngles.y), 0, Mathf.Cos(angle.eulerAngles.y)).normalized * _speed;

        if (_cube.localScale.z > MaxScaling && _directionScale > 0)
        {
            _directionScale = (int)Vector3.back.z;
        }

        if (_cube.localScale.z < MinScaling && _directionScale < 0)
        {
            _directionScale = (int)Vector3.forward.z;
        }

        _cube.localScale += new Vector3(Time.deltaTime, Time.deltaTime, Time.deltaTime) * _speedScale * _directionScale;
    }
}
