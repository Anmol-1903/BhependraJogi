using UnityEngine;
public class MapProgress : MonoBehaviour
{
    [SerializeField] float _speed = 5f;
    private void FixedUpdate()
    {
        transform.Translate(-Vector3.forward * _speed * Time.deltaTime);
    }
}