using UnityEngine;

public class Scale : MonoBehaviour
{    
    [SerializeField]
    private float _speed = 1f;

    public void Update()
    {
        gameObject.transform.localScale += Vector3.one * Time.deltaTime * _speed;        
    }
}
