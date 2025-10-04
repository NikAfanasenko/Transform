using UnityEngine;

public class Scaling : MonoBehaviour
{    
    [SerializeField]
    private float _speed = 1f;

    private Transform _capsule;

    public void Awake()
    {
        _capsule = GetComponent<Transform>();
    }

    public void Update()
    {
        _capsule.localScale += new Vector3(1,1,1).normalized * Time.deltaTime * _speed ;
    }
}
