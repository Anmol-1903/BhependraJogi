using UnityEngine;
public class RagDoll : MonoBehaviour
{
    [SerializeField] GameObject armature;
    [SerializeField] Animator _anim;
    private void Awake()
    {
        armature = transform.GetChild(0).gameObject;
        armature.SetActive(false);
        _anim = GetComponent<Animator>();
    }
    public void ActivateRagdoll()
    {
        _anim.enabled = false;
        armature.SetActive(true);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Panel"))
        {
            ActivateRagdoll();
            GetComponent<AudioSource>().enabled = false;
            AudioManager.Instance.PlayCollisionEffect2();
        }
    }
}
