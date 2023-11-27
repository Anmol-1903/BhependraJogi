using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float _speed;
    private void FixedUpdate()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("DinVich") || other.CompareTag("YoHoney"))          // Player collide with character
        {
            ScoringSystem.Instance.AddScore(1);
            if (other.GetComponent<RagDoll>())
            {
                other.GetComponent<RagDoll>().ActivateRagdoll();
            }
        }
    }
}