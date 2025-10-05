using UnityEngine;

public class Scale : MonoBehaviour
{    
    [SerializeField]
    private float _speed = 1f;

    private Transform _scalableTransform;

    private void Awake()
    {
        _scalableTransform = gameObject.transform; 
    }

    public void Update()
    {
        _scalableTransform.localScale += Vector3.one * Time.deltaTime * _speed;
        
    }
}
