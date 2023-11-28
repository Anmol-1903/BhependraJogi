using UnityEngine;
using System.Collections;
public class TouchControl : MonoBehaviour
{
    [SerializeField] GameObject _obstacle , _bombExpoEffect;
    [SerializeField] Camera _mainCam;
    [SerializeField] float _obstacleDestroyTimer;
    [SerializeField] LayerMask _whatIsGround;
    [SerializeField] Vector3 offset;
    Ray ray;

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
                GameObject temp = Instantiate(_obstacle, hit.point + offset, Quaternion.identity);
                temp.tag = "Obstacle";
                StartCoroutine(Timer(temp));
            }
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawRay(ray);
    }
    IEnumerator Timer(GameObject temp)
    {
        yield return new WaitForSeconds(_obstacleDestroyTimer);
        temp.GetComponent<BombExplosion>().Explosion();
        GameObject tempParticle = Instantiate(_bombExpoEffect, temp.transform.position + offset, Quaternion.identity);
        Destroy(tempParticle, 1f);
    }
}
