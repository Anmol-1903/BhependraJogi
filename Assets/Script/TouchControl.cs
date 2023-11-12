using UnityEngine;

public class TouchControl : MonoBehaviour
{
    [SerializeField] GameObject _obstacle;
    [SerializeField] Camera _mainCam;
    [SerializeField] float _obstacleDestroyTimer;
    GameObject obstacleClone;

    // Update is called once per frame
    void Update()
    {
        Touch();
    }
    void Touch()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 touchPos = _mainCam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 20f));
            obstacleClone =  Instantiate(_obstacle, touchPos, Quaternion.identity);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Destroy(obstacleClone, _obstacleDestroyTimer);
        }
    }
}
