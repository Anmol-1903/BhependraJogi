using UnityEngine;
public class BombExplosion : MonoBehaviour
{
    [SerializeField] float _radius , _force , _Force_Height = 0.25f;
    AudioSource audioSource;
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayDelayed(0.2f);
    }
    public void Explosion()
    {   
        Collider[] colliders =  Physics.OverlapSphere(transform.position, _radius);
        foreach (Collider nearbyObjects in colliders)
        {
            Rigidbody rb = nearbyObjects.GetComponent<Rigidbody>();
            if(rb)
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
