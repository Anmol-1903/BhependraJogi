using UnityEngine;
public class CollisionCheck : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Panel"))
        {
            AudioManager.Instance.PlayCollisionEffect1();
        }
    }
}