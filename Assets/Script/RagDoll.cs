using UnityEngine;

public class RagDoll : MonoBehaviour
{
    [SerializeField] GameObject armature;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Panel"))
        {
            gameObject.GetComponent<Animator>().enabled = false;
            armature.SetActive(true);
        }
    }
}
