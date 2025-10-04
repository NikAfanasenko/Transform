using UnityEngine;

public class Scaling : MonoBehaviour
{    
    [SerializeField]
    private float _speed = 1f;

    private Transform _scalableTransform;

    public void Awake()
    {
        _scalableTransform = GetComponent<Transform>();
    }

    public void Update()
    {
        _scalableTransform.localScale += new Vector3(1,1,1).normalized * Time.deltaTime * _speed ;
    }
}
