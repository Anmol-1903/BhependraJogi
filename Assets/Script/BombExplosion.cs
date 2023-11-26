using UnityEngine;

public class BombExplosion : MonoBehaviour
{
    [SerializeField] float delay , _radius , _force , _Force_Height = 0.25f;
   

    float counter;

    public AudioSource audioSource;

    // Drag and drop your audio clip in the Inspector
    public AudioClip myAudioClip;

    private void Start()
    {
       

        counter = delay;

        GameObject targetObject = GameObject.Find("BombSound");

        AudioSource targetAudioSource = targetObject.GetComponent<AudioSource>();

        targetAudioSource.clip = myAudioClip;
        targetAudioSource.Play();

        //audioSource = GetComponent<AudioSource>();

        // Assign the audio clip to the AudioSource component
        //audioSource.clip = myAudioClip;
       // audioSource.Play();


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
