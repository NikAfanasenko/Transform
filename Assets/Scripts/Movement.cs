using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float _speed = 2f;

    public void Update()
    {
        gameObject.transform.position = gameObject.transform.position + gameObject.transform.forward * _speed * Time.deltaTime;
    }
}
