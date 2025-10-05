using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float _speed = 2f;

    public void Update()
    {
        transform.position = transform.position + transform.forward * _speed * Time.deltaTime;
    }
}
