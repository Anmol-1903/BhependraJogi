using UnityEngine;

public class BombExplosion : MonoBehaviour
{
    [SerializeField] float delay , _radius , _force , _Force_Height = 0.25f;

    float counter;

    private void Start()
    {
        counter = delay;

    }

    private void Update()
    {
        counter -= Time.deltaTime;

        if(counter <= 0)
        {
            Explosion();
        }
    }
    void Explosion()
    {   
        Collider[] colliders =  Physics.OverlapSphere(transform.position, _radius);
        foreach (Collider nearbyObjects in colliders)
        {
            Rigidbody rb = nearbyObjects.GetComponent<Rigidbody>();
            if(rb != null)
            {
                Vector3 dir = (nearbyObjects.transform.position - transform.position).normalized;
                dir.z = 0;
                dir.y = _Force_Height;
                rb.AddForce(dir * _force, ForceMode.Impulse);
            }
        }
        Destroy(gameObject);
    }
}
