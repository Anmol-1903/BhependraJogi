using UnityEngine;
public class RagDoll : MonoBehaviour
{
    [SerializeField] GameObject armature;
    [SerializeField] Animator _anim;
    private void Awake()
    {
        _anim = GetComponent<Animator>();
    }
    public void ActivateRagdoll()
    {
        _anim.enabled = false;
        armature.SetActive(true);
    }
}
