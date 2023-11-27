using UnityEngine;
public class DeSpawner : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DinVich") || other.CompareTag("YoHoney"))          // Despawner collide with character
        {
            Destroy(other.gameObject, .5f);
        }
    }
}