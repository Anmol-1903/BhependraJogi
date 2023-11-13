using UnityEngine;

public class TouchControl : MonoBehaviour
{
    [SerializeField] GameObject _obstacle;
    [SerializeField] Camera _mainCam;
    [SerializeField] float _obstacleDestroyTimer;
    [SerializeField] LayerMask _whatIsGround;
    [SerializeField] Vector3 offset;
    float _maxDis;
    GameObject obstacleClone;
    Ray ray;

    private void Start()
    {
        _maxDis = Mathf.Infinity;
    }
    // Update is called once per frame
    void Update()
    {
        Touch();
    }
    void Touch()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = _mainCam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            Physics.Raycast(ray, out hit);
            if (hit.transform.CompareTag("Floor"))
            { 
                
                GameObject temp = Instantiate(_obstacle , hit.point + offset, Quaternion.identity);
                temp.tag = "Obstacle";
            }
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawRay(ray);
    }
}
