using UnityEngine;

public class Scalation : MonoBehaviour
{    
    [SerializeField]
    private float _speed = 1f;

    public void Update()
    {
        transform.localScale += Vector3.one * Time.deltaTime * _speed;        
    }
}
