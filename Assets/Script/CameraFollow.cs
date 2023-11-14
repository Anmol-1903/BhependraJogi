using UnityEngine;
public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform _target;
    [SerializeField] bool _takeOffsetFromInitialPosition;
    [SerializeField] Vector3 _offset;
    [Range(0f,0.2f)]
    [SerializeField] float _laziness;
    private void Start()
    {
        if(_takeOffsetFromInitialPosition)
        {
            _offset = transform.position - _target.position;
        }
    }
    private void FixedUpdate()
    {
        Vector3 currentVelocity = Vector3.zero;
        transform.position = Vector3.SmoothDamp(transform.position, _target.position + _offset, ref currentVelocity, _laziness);
    }
    private void LateUpdate()
    {
        transform.LookAt(_target.position);
    }
}