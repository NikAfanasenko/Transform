using UnityEngine;

public class FunnyCube : MonoBehaviour
{
    [SerializeField]
    private float _speedScale = 1f;

    [SerializeField]
    private float _speedRotation = 1f;

    [SerializeField]
    private float _speed = 1f;

    private Transform _cube;

    public void Awake()
    {
        _cube = GetComponent<Transform>();       
    }

    public void Update()
    {
        _cube.rotation *= Quaternion.Euler(0, _speedRotation, 0);

        _cube.position = _cube.position + _cube.rotation * Vector3.forward * _speed * Time.deltaTime;

        _cube.localScale += new Vector3(1, 1, 1).normalized * Time.deltaTime * _speedScale;
    }
}
