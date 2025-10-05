using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField]
    private float _speed = 1.0f;

    public void Update()
    {
        transform.rotation *= Quaternion.Euler(0, _speed, 0);
    }
}
